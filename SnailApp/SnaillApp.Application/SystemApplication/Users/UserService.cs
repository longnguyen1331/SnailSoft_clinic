﻿using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.AppUserTypes;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.System.AppRoles;
using SnailApp.ViewModels.System.MenuAppRoles;
using SnailApp.Application.Common;
using SnailApp.ViewModels.HR.Payrolls;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.IO;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http.Headers;

namespace SnailApp.Application.SystemApplication.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);
        Task<ApiResult<int>> ChangePasswordAsync(ChangePasswordRequest request);
        Task<PagedResult<UserDto>> GetStaffManageListPaging(ManageUserPagingRequest request);
        Task<ApiResult<UserDto>> GetById(UserRequest request);
        Task<ApiResult<UserDto>> GetByUserName(UserRequest request);
        Task<ApiResult<int>> DeleteByIds(UserDeleteRequest request);
        Task<ApiResult<UserDto>> GetRolesByUserId(UserRoleRequest request);
        Task<ApiResult<UserDto>> GetStaffProfileDetailByUserId(UserRequest request);
        Task<ApiResult<UserDto>> GetStaffSecurityByUserId(UserRequest request);
        Task<ApiResult<UserDto>> GetCustomerSecurityByUserId(UserRequest request);
        Task<ApiResult<string>> AddOrUpdateSecurityAsync(UserRequest request);
        Task<ApiResult<string>> DeleteAvatarByUserId(string userId);
    }
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly ClinicDbContext _context;
        private readonly IFileStorageService _storageService;

        public UserService(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration configuration,
            IFileStorageService storageService,
            ClinicDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _storageService = storageService;
            _context = context;
        }

        public async Task<ApiResult<string>> Authencate(LoginRequest request)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(request.UserName);
                if (user == null)
                {
                    return new ApiErrorResult<string>("Account not found.");
                }
                else if (!user.IsActive)
                {
                    return new ApiErrorResult<string>("Account not active.");
                }

                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                if (!result.Succeeded)
                {
                    return new ApiErrorResult<string>("Password incorrect");
                }

                var roles = await _userManager.GetRolesAsync(user);
                var claims = new[]
                {
                    new Claim(ClaimTypes.PrimarySid, user.Id.ToString()),
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim(ClaimTypes.GivenName,user.FirstName  + " " + user.LastName),
                    new Claim(ClaimTypes.Role, string.Join(";",roles)),
                    new Claim(ClaimTypes.Name, request.UserName)
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_configuration["Tokens:Issuer"],
                    _configuration["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(3),
                    signingCredentials: creds);

                return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }            
        }
        public async Task<ApiResult<UserDto>> GetById(UserRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.Id);
            if (user == null)
            {
                return new ApiErrorResult<UserDto>("User not found");
            }
            
            var userDto = new UserDto()
            {
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FirstName = user.FirstName,
                Dob = user.Dob,
                Id = user.Id.ToString(),
                LastName = user.LastName,
                UserName = user.UserName,
                Avatar = (!string.IsNullOrEmpty(user.Avatar) ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + user.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                IsActive = user.IsActive,
            };
            return new ApiSuccessResult<UserDto>(userDto);
        }
        public async Task<ApiResult<UserDto>> GetByUserName(UserRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
            {
                return new ApiErrorResult<UserDto>("User not found");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var userViewModel = new UserDto()
            {
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FirstName = user.FirstName,
                Dob = user.Dob,
                Id = user.Id.ToString(),
                LastName = user.LastName,
                UserName = user.UserName,
                Avatar = (!string.IsNullOrEmpty(user.Avatar) ? (_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + user.Avatar) : SystemConstants.AppConstants.FileNoImagePerson),
                IsActive = user.IsActive,
            };
            return new ApiSuccessResult<UserDto>(userViewModel);
        }
        public async Task<PagedResult<UserDto>> GetStaffManageListPaging(ManageUserPagingRequest request)
        {
            try
            {
                var query = from u in _context.Users
                            select new UserDto()
                            {
                                Id = u.Id.ToString(),
                                Avatar = (!string.IsNullOrEmpty(u.Avatar) ? (_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + u.Avatar) : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                                LastName = u.LastName,
                                FirstName = u.FirstName,
                                Address = u.Address,
                                Email = u.Email,
                                PhoneNumber = u.PhoneNumber,
                                UserName = u.UserName,
                                StrCreatedDate = u.CreatedDate.ToString("dd/MM/yyyy")
                            };

                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.UserName.Contains(request.TextSearch)
                     || (x.LastName + " " + x.FirstName).Contains(request.TextSearch)
                     || (x.Email).Contains(request.TextSearch)
                     );
                }

                //3. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                    .Take(request.PageSize);
                }

                var data = await query.AsNoTracking().ToListAsync();

                foreach (var user in data)
                {
                    List<AppRoleDto> appRoles = await (from ur in _context.UserRoles
                                                       join r in _context.Roles on ur.RoleId equals r.Id
                                                       join rt in _context.AppRoleTranslations on r.Id equals rt.AppRoleId into rrt
                                                       from rt in rrt.DefaultIfEmpty()
                                                       where rt.LanguageId == request.LanguageId && ur.UserId == Guid.Parse(user.Id)
                                                       select new AppRoleDto()
                                                       {
                                                           Code = r.Name,
                                                           Name = rt.Name
                                                       }).ToListAsync();

                    user.AppRoles = appRoles;
                }

                //4. Select and projection
                var pagedResult = new PagedResult<UserDto>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedResult;
            }
            catch (Exception ex)
            {
                return new PagedResult<UserDto>()
                {
                    TotalRecords = 0,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = null,
                    Message = ex.Message
                };
            }

        }
        public async Task<ApiResult<string>> AddOrUpdateSecurityAsync(UserRequest request)
        {
            try
            {
                bool isNew = false;
                AppUser user = null;
                DateTime ngayValue;
                if (string.IsNullOrEmpty(request.Id))
                {
                    isNew = true;

                    user = await _userManager.FindByEmailAsync(request.Email);
                    if (user != null)
                    {
                        return new ApiErrorResult<string>("Email account is exits.");
                    }

                    user = new AppUser() { 
                        UserName = request.Email,
                        Email = request.Email,
                        CreatedDate = DateTime.Now,
                        CreatedUserId =Guid.Parse(request.CreatedUserId),
                        ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        GenderId = request.GenderId,
                        Dob= (DateTime.TryParseExact(request.Dob, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>()),
                        IsActive = request.IsActive,
                        Address = request.Address,
                        ModifiedDate = DateTime.Now
                    };

                    if (request.Avatar != null)
                    {
                        if (!string.IsNullOrEmpty(user.Avatar))
                        {
                            await DeleteFile(user.Avatar);
                        }

                        user.Avatar = await this.SaveFile(request.Avatar);
                    }
                }
                else
                {
                    user = await _userManager.FindByIdAsync(request.Id.ToString());
                    if (await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.Id != Guid.Parse(request.Id)))
                    {
                        return new ApiErrorResult<string>("Emai account is exits.");
                    }
                }

                if (isNew == true)
                {
                    var result = await _userManager.CreateAsync(user, request.Password);
                    if (!result.Succeeded)
                    {
                        return new ApiErrorResult<string>("Create is failed.");
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(request.Password))
                    {
                        if (user.PasswordHash != null)
                        {
                            if (!(await _userManager.RemovePasswordAsync(user)).Succeeded)
                            {
                                return new ApiErrorResult<string>("Change password is failed..");
                            }
                        }

                        if (!(await _userManager.AddPasswordAsync(user, request.Password)).Succeeded)
                        {
                            return new ApiErrorResult<string>("Change password is failed.");
                        }
                    }

                    var result = await _userManager.UpdateAsync(user);
                    if (!result.Succeeded)
                    {
                        return new ApiErrorResult<string>("Update is failed.");
                    }
                }

                await _userManager.RemoveFromRolesAsync(user, await _userManager.GetRolesAsync(user));
                if (request.AppRoleCodes != null)
                {
                    foreach (string roleCode in request.AppRoleCodes)
                    {
                        await _userManager.AddToRoleAsync(user, roleCode);
                    }
                }                

                return new ApiSuccessResult<string>(user.Id.ToString());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> ChangePasswordAsync(ChangePasswordRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.Id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<int>("Not found.");
            }

            var newPassword = _userManager.PasswordHasher.HashPassword(user, request.NewPassword) ;
            user.PasswordHash = newPassword;            

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<int>();
            }
            return new ApiErrorResult<int>("Update is failed.");
        }
        private async Task<ApiResult<int>> DeleteById(Guid id)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(id.ToString());
                if (user == null)
                {
                    return new ApiErrorResult<int>("Not found.");
                }

                if (!string.IsNullOrEmpty(user.Avatar))
                {
                    await this.DeleteFile(user.Avatar);
                }


                var transactions = _context.Transactions.Where(m => m.AppUserId == id).ToList();
                if (transactions != null)
                {
                    foreach (var item in transactions)
                    {
                        item.IsDeleted = true;
                    }
                }

                await _context.SaveChangesAsync();

                var userResult = await _userManager.DeleteAsync(user);

                if (userResult.Succeeded)
                {
                    return new ApiSuccessResult<int>(1);
                }

                return new ApiErrorResult<int>("Xóa UserId: " + id.ToString() + " không thành công");
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>("UserId: " + id.ToString() + ": " + ex.Message);
            }
        }
        public async Task<ApiResult<int>> DeleteByIds(UserDeleteRequest request)
        {
            var ids = request.Ids.Select(m => Guid.Parse(m)).ToList();
            bool check = true;
            int n = 0;
            while (check == true && n < ids.Count)
            {
                var result = await DeleteById(ids[n]);
                if (result.IsSuccessed)
                {
                    n++;
                }
                else
                {
                    return result;
                }
            }

            return new ApiSuccessResult<int>();
        }
        public async Task<ApiResult<UserDto>> GetRolesByUserId(UserRoleRequest request)
        {
            var queryMenuAppRoles = from mar in _context.MenuAppRoles
                                    join m in _context.Menus on mar.MenuId equals m.Id
                                    join ar in _context.Roles on mar.AppRoleId equals ar.Id
                                        join art in _context.AppRoleTranslations on ar.Id equals art.AppRoleId into ar_art
                                        from art in ar_art.DefaultIfEmpty()
                                        join ur in _context.UserRoles on ar.Id equals ur.RoleId
                                    where art.LanguageId == request.LanguageId && ur.UserId == Guid.Parse(request.UserId)
                                            && !string.IsNullOrEmpty(m.ControllerName) && !string.IsNullOrEmpty(m.ActionName)
                                    select new { mar, m, art, ur };

            if (!string.IsNullOrEmpty(request.UserId))
            {
                queryMenuAppRoles = queryMenuAppRoles.Where(x => x.ur.UserId == Guid.Parse(request.UserId));
            }

            if (!string.IsNullOrEmpty(request.ControllerName))
            {
                queryMenuAppRoles = queryMenuAppRoles.Where(x => x.m.ControllerName == request.ControllerName);
            }

            if (!string.IsNullOrEmpty(request.ActionName))
            {
                queryMenuAppRoles = queryMenuAppRoles.Where(x => x.m.ActionName == request.ActionName);
            }

            var user = new UserDto()
            {
                Id = request.UserId,
                MenuAppRoles = await queryMenuAppRoles.Select(x => new MenuAppRoleDto(){
                                                                ControllerName = x.m.ControllerName,
                                                                ActionName = x.m.ActionName,
                                                                MenuId = x.m.Id,
                                                                MenuAppRoleType = (int)x.mar.MenuAppRoleType,
                                                                IsAllow = x.mar.IsAllow
                                                            }).AsNoTracking().ToListAsync()
            };

            return new ApiSuccessResult<UserDto>(user);
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            try
            {
                await _storageService.SaveFileAsync(file.OpenReadStream(), _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + fileName);
                return fileName;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
           
        }
        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFileAsync(_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + fileName);
        }
        public async Task<ApiResult<UserDto>> GetStaffProfileDetailByUserId(UserRequest request)
        {
            try
            {
                var user = await (from u in _userManager.Users
                                  where u.Id == Guid.Parse(request.Id)
                                  select new UserDto()
                                  {
                                      Id = u.Id.ToString(),
                                      Code = u.Code,
                                      FirstName = u.FirstName,
                                      LastName = u.LastName,
                                      Dob = u.Dob,
                                      PhoneNumber = u.PhoneNumber,
                                      Address = u.Address,
                                      Avatar = (!string.IsNullOrEmpty(u.Avatar) ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + u.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson])
                                  }
                            ).AsNoTracking().FirstOrDefaultAsync();

                if (user == null)
                {
                    return new ApiErrorResult<UserDto>("User not found.");
                }


                return new ApiSuccessResult<UserDto>(user);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<UserDto>(ex.Message);
            }            
        }
        public async Task<ApiResult<UserDto>> GetStaffSecurityByUserId(UserRequest request)
        {
            try
            {
                var user = await (from u in _userManager.Users
                                  where u.Id == Guid.Parse(request.Id)
                                  select new UserDto()
                                  {
                                      Id = u.Id.ToString(),
                                      Code = u.Code,
                                      FirstName = u.FirstName,
                                      LastName = u.LastName,
                                      Dob = u.Dob,
                                      PhoneNumber = u.PhoneNumber,
                                      Address = u.Address,
                                      Avatar = (u.Avatar != null ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + u.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                                      UserName = u.UserName,
                                      Email = u.Email,
                                      IsActive = u.IsActive,
                                  }
                            ).AsNoTracking().FirstOrDefaultAsync();

                if (user == null)
                {
                    return new ApiErrorResult<UserDto>("User not found.");
                }

                List<AppRoleDto> appRoles = await (from ur in _context.UserRoles
                                                   join r in _context.Roles on ur.RoleId equals r.Id
                                                   join rt in _context.AppRoleTranslations on r.Id equals rt.AppRoleId into rrt
                                                   from rt in rrt.DefaultIfEmpty()
                                                   where rt.LanguageId == request.LanguageId && ur.UserId == Guid.Parse(user.Id)
                                                   select new AppRoleDto()
                                                   {
                                                       Code = r.Name,
                                                       Name = rt.Name
                                                   }).ToListAsync();

                user.AppRoles = appRoles;

                return new ApiSuccessResult<UserDto>(user);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<UserDto>(ex.Message);
            }
        }
        public async Task<ApiResult<UserDto>> GetCustomerSecurityByUserId(UserRequest request)
        {
            try
            {
                var user = await (from u in _context.Users
                                  where u.Id == Guid.Parse(request.Id)
                                  select new UserDto()
                                  {
                                      Id = u.Id.ToString(),
                                      Code = u.Code,
                                      FirstName = u.FirstName,
                                      LastName = u.LastName,
                                      Dob = u.Dob,
                                      PhoneNumber = u.PhoneNumber,
                                      Address = u.Address,
                                      Avatar = (u.Avatar != null ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + u.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                                      UserName = u.UserName,
                                      Email= u.Email,
                                      IsActive = u.IsActive,
                                  }
                            ).AsNoTracking().FirstOrDefaultAsync();

                if (user == null)
                {
                    return new ApiErrorResult<UserDto>("User not found.");
                }

                return new ApiSuccessResult<UserDto>(user);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<UserDto>(ex.Message);
            }
        }
        public async Task<ApiResult<string>> DeleteAvatarByUserId(string userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    return new ApiErrorResult<string>("User not found");
                }

                if (!string.IsNullOrEmpty(user.Avatar))
                {
                    await this.DeleteFile(user.Avatar);
                }

                await _userManager.UpdateAsync(user);

                return new ApiSuccessResult<string>(_configuration[SystemConstants.AppConstants.NoImageAvailable]);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
    }
}


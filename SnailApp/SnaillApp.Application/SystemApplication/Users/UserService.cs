using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.AppUserTypes;
using SnailApp.ViewModels.Catalog.Genders;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.System.AppRoles;
using SnailApp.ViewModels.System.MenuAppRoles;
using SnailApp.ViewModels.Sales.AppUserFeedbacks;
using SnailApp.ViewModels.Sales.AppUserHelps;
using SnailApp.ViewModels.System.AppUser_AppUserTypes;
using SnailApp.Application.Common;
using SnailApp.ViewModels.HR.Payrolls;
using SnailApp.Utilities.Exceptions;
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
using ExcelDataReader;

namespace SnailApp.Application.SystemApplication.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);
        Task<ApiResult<int>> ChangePasswordAsync(ChangePasswordRequest request);
        Task<PagedResult<UserDto>> GetStaffManageListPaging(ManageUserPagingRequest request);
        Task<PagedResult<PayrollDto>> GetStaffSalaryManageListPaging(ManageUserPagingRequest request);
        Task<ApiResult<UserDto>> GetById(UserRequest request);
        Task<ApiResult<UserDto>> GetByUserName(UserRequest request);
        Task<ApiResult<int>> DeleteByIds(UserDeleteRequest request);
        Task<ApiResult<UserDto>> GetRolesByUserId(UserRoleRequest request);
        Task<ApiResult<UserDto>> GetStaffProfileDetailByUserId(UserRequest request);
        Task<ApiResult<UserDto>> GetCustomerProfileDetailByUserId(UserRequest request);
        Task<ApiResult<UserDto>> GetStaffSecurityByUserId(UserRequest request);
        Task<ApiResult<UserDto>> GetCustomerSecurityByUserId(UserRequest request);
        Task<ApiResult<UserDto>> GetSupplierSecurityByUserId(UserRequest request);
        Task<ApiResult<string>> AddOrUpdateStaffProfileDetailAsync(UserRequest request);        Task<ApiResult<string>> AddOrUpdateSecurityAsync(UserRequest request);
        Task<ApiResult<string>> CustomerRegisterFromMobile(UserRequest request);
        Task<ApiResult<string>> DeleteAvatarByUserId(string userId);
        Task<ApiResult<string>> AddOrUpdateCustomerProfileDetailAsync(UserRequest request);
        Task<ApiResult<string>> AddOrUpdateSupplierProfileDetailAsync(UserRequest request);
        Task<PagedResult<UserDto>> GetCustomerManageListPaging(ManageUserPagingRequest request);
        Task<PagedResult<UserDto>> GetSupplierManageListPaging(ManageUserPagingRequest request);
        Task<ApiResult<UserDto>> GetCustomerProfileFromMobile(string id);
        Task<ApiResult<string>> SaveCustomerProfileFromMobile(MobileUserProfileRequest request);
        Task<ApiResult<int>> SaveCustomerFeedbackFromMobile(MobileAppUserFeedbackRequest request);
        Task<ApiResult<int>> SaveCustomerHelpFromMobile(MobileAppUserHelpRequest request);
        Task<ApiResult<string>> ImportDataCustomerFromExcelFile(UserRequest request);
        Task<ApiResult<string>> CustomerPinCheckFromMobile(MobileUserPinCheckRequest request);


    }
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _storageService;

        public UserService(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration configuration,
            IFileStorageService storageService,
            EShopDbContext context)
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
                    return new ApiErrorResult<string>("Tài khoản không tồn tại");
                }
                else if (!user.IsActive)
                {
                    return new ApiErrorResult<string>("Tài khoản chưa được kích hoạt");
                }
                else if (!user.IsStillInUse)
                {
                    return new ApiErrorResult<string>("Tài khoản không còn được sử dụng.");
                }

                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                if (!result.Succeeded)
                {
                    return new ApiErrorResult<string>("Mật khẩu không đúng");
                }

                var roles = await _userManager.GetRolesAsync(user);
                var claims = new[]
                {
                    new Claim(ClaimTypes.PrimarySid, user.Id.ToString()),
                    new Claim(ClaimTypes.Email,user.Email),
                    //new Claim(ClaimTypes.GivenName,user.FirstName),
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
                return new ApiErrorResult<UserDto>("User không tồn tại");
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
                IsStillInUse = user.IsStillInUse
            };
            return new ApiSuccessResult<UserDto>(userDto);
        }
        public async Task<ApiResult<UserDto>> GetByUserName(UserRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
            {
                return new ApiErrorResult<UserDto>("User không tồn tại");
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
                IsStillInUse = user.IsStillInUse
            };
            return new ApiSuccessResult<UserDto>(userViewModel);
        }
        public async Task<PagedResult<UserDto>> GetStaffManageListPaging(ManageUserPagingRequest request)
        {
            try
            {
                var query = from u in _context.Users
                            where !u.AppUser_AppUserTypes.Any() || u.AppUser_AppUserTypes.Any(n => n.AppUserType.Code == _configuration[SystemConstants.UserConstants.AppUserType_Staff])
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
        public async Task<PagedResult<UserDto>> GetCustomerManageListPaging(ManageUserPagingRequest request)
        {
            DateTime fromDate, toDate;

            try
            {
                List<GenderDto> genders = await (from g in _context.Genders
                                                 join gt in _context.GenderTranslations on g.Id equals gt.GenderId into g_gt
                                                 from gt in g_gt.DefaultIfEmpty()
                                                 where gt.LanguageId == request.LanguageId
                                                 select new GenderDto()
                                                 {
                                                     Id = g.Id,
                                                     Code = g.Code,
                                                     Name = gt.Name
                                                 }).AsNoTracking().ToListAsync();

                var query = from u in _userManager.Users
                            where u.AppUser_AppUserTypes.Any(n => n.AppUserType.Code == _configuration[SystemConstants.UserConstants.AppUserType_Customer])
                            select new { u };

                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.u.UserName.Contains(request.TextSearch)
                     || (x.u.LastName + " " + x.u.FirstName).Contains(request.TextSearch)
                     || (x.u.Email).Contains(request.TextSearch)
                     );
                }

                if (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out fromDate))
                {
                    query = query.Where(x => x.u.CreatedDate >= fromDate);
                }

                if (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out toDate))
                {
                    query = query.Where(x => x.u.CreatedDate <= new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 0));
                }

                //3. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                    .Take(request.PageSize);
                }

                var data = await query.Select(x => new UserDto()
                {
                    Id = x.u.Id.ToString(),
                    Code = x.u.Code,
                    Avatar = (!string.IsNullOrEmpty(x.u.Avatar) ? (_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + x.u.Avatar) : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                    FullName = x.u.LastName + " " + x.u.FirstName,
                    PhoneNumber = x.u.PhoneNumber,
                    StrLastimePurchase = (x.u.LastimePurchase != null ? x.u.LastimePurchase.Value.ToString("dd/MM/yyyy") : string.Empty),
                    StrTotalMoney = x.u.TotalMoney.ToString(),
                    StrTotalDebt = x.u.TotalDebt.ToString(),
                    StrTongTienTraHang = x.u.TongTienTraHang.ToString(),
                    Address = x.u.Address,
                    StrDob = (x.u.Dob != null ? x.u.Dob.Value.ToString("dd/MM/yyyy"): string.Empty),
                    Email = x.u.Email,
                    GhiChu = x.u.GhiChu,
                    GenderId = x.u.GenderId
                }).AsNoTracking().ToListAsync();

                foreach (var user in data)
                {
                    user.Gender = (user.GenderId != null ? genders.FirstOrDefault(m => m.Id == user.GenderId.Value) : null);
                }

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
        public async Task<PagedResult<UserDto>> GetSupplierManageListPaging(ManageUserPagingRequest request)
        {
            DateTime fromDate, toDate;
            try
            {
                List<GenderDto> genders = await (from g in _context.Genders
                                                 join gt in _context.GenderTranslations on g.Id equals gt.GenderId into g_gt
                                                 from gt in g_gt.DefaultIfEmpty()
                                                 where gt.LanguageId == request.LanguageId
                                                 select new GenderDto()
                                                 {
                                                     Id = g.Id,
                                                     Code = g.Code,
                                                     Name = gt.Name
                                                 }).AsNoTracking().ToListAsync();

                var query = from u in _userManager.Users
                            where u.AppUser_AppUserTypes.Any(n => n.AppUserType.Code == _configuration[SystemConstants.UserConstants.AppUserType_Supplier])
                            select new { u };

                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.u.UserName.Contains(request.TextSearch)
                     || (x.u.LastName + " " + x.u.FirstName).Contains(request.TextSearch)
                     || (x.u.Email).Contains(request.TextSearch)
                     );
                }

                if (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out fromDate))
                {
                    query = query.Where(x => x.u.CreatedDate >= fromDate);
                }

                if (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out toDate))
                {
                    query = query.Where(x => x.u.CreatedDate <= new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 0));
                }

                //3. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                    .Take(request.PageSize);
                }

                var data = await query.Select(x => new UserDto()
                {
                    Id = x.u.Id.ToString(),
                    Code = x.u.Code,
                    Avatar = (!string.IsNullOrEmpty(x.u.Avatar) ? (_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + x.u.Avatar) : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                    FullName = x.u.LastName + " " + x.u.FirstName,
                    PhoneNumber = x.u.PhoneNumber,
                    StrLastimePurchase = (x.u.LastimePurchase != null ? x.u.LastimePurchase.Value.ToString("dd/MM/yyyy") : string.Empty),
                    StrTotalMoney = x.u.TotalMoney.ToString(),
                    StrTotalDebt = x.u.TotalDebt.ToString(),
                    StrNoNhaCungCap = x.u.NoNhaCungCap.ToString(),
                    StrTongTienTraHang = x.u.TongTienTraHang.ToString(),
                    Address = x.u.Address,
                    Email = x.u.Email,
                    TaxCode = x.u.TaxCode,
                    GhiChu = x.u.GhiChu,
                    GenderId = x.u.GenderId
                }).AsNoTracking().ToListAsync();

                foreach (var user in data)
                {
                    user.Gender = (user.GenderId != null ? genders.FirstOrDefault(m => m.Id == user.GenderId.Value) : null);
                }



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
                DateTime registerDateValue;
                AppUser user = null;

                if (string.IsNullOrEmpty(request.Id))
                {
                    isNew = true;

                    user = await _userManager.FindByNameAsync(request.UserName);
                    if (user != null)
                    {
                        return new ApiErrorResult<string>("Tài khoản đã tồn tại");
                    }
                    else if (await _userManager.FindByEmailAsync(request.Email) != null)
                    {
                        return new ApiErrorResult<string>("Emai đã tồn tại");
                    }

                    user = new AppUser() { 
                        CreatedDate = DateTime.Now
                    };
                }
                else
                {
                    user = await _userManager.FindByIdAsync(request.Id.ToString());
                    if (await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.Id != Guid.Parse(request.Id)))
                    {
                        return new ApiErrorResult<string>("Emai đã tồn tại");
                    }
                }

                user.UserName = request.UserName;
                user.Email = request.Email;
                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    user.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }
                user.IsActive = request.IsActive;
                if (request.IsActive == true)
                {
                    user.ActivateDate = DateTime.Now;
                }
                user.IsStillInUse = request.IsStillInUse;
                user.RegisterDate = (DateTime.TryParseExact(request.RegisterDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out registerDateValue) ? registerDateValue : DateTime.Now);
                user.ModifiedDate = DateTime.Now;

                if (isNew == true)
                {
                    var result = await _userManager.CreateAsync(user, request.Password);
                    if (!result.Succeeded)
                    {
                        return new ApiErrorResult<string>("Đăng ký không thành công");
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
                                return new ApiErrorResult<string>("Xóa mật khẩu cũ không thành công.");
                            }
                        }

                        if (!(await _userManager.AddPasswordAsync(user, request.Password)).Succeeded)
                        {
                            return new ApiErrorResult<string>("Đổi mật khẩu không thành công.");
                        }
                    }

                    var result = await _userManager.UpdateAsync(user);
                    if (!result.Succeeded)
                    {
                        return new ApiErrorResult<string>("Cập nhật không thành công");
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

                if (!string.IsNullOrEmpty(request.AppUserTypeCodes))
                {
                    List<string> appUserTypeCodes = request.AppUserTypeCodes.Split(',').ToList();
                    List<AppUserType> appUserTypes = await _context.AppUserTypes.Where(m => appUserTypeCodes.Contains(m.Code)).ToListAsync();

                    foreach (var appUserType in appUserTypes)
                    {
                        if (await _context.AppUser_AppUserTypes.CountAsync(m => m.AppUserId == user.Id && m.AppUserTypeId == appUserType.Id) == 0)
                        {
                            _context.AppUser_AppUserTypes.Add(new AppUser_AppUserType()
                            {
                                AppUserTypeId = appUserType.Id,
                                AppUserId = user.Id
                            });

                            await _context.SaveChangesAsync();
                        }
                    }                    
                }

                return new ApiSuccessResult<string>(user.Id.ToString());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        public async Task<ApiResult<string>> AddOrUpdateStaffProfileDetailAsync(UserRequest request)
        {
            try
            {
                DateTime ngayValue;
                var user = await _userManager.FindByIdAsync(request.Id);
                if (user == null)
                {
                    return new ApiErrorResult<string>("User này tồn tại");
                }

                user.Code = request.Code;
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.GenderId = request.GenderId;
                user.Dob = (DateTime.TryParseExact(request.Dob, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                user.PhoneNumber = request.PhoneNumber;
                user.Address = request.Address;
                user.TaxCode = request.TaxCode;
                user.Description = request.Description;
                user.ContactPerson = request.ContactPerson;
                user.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                user.StartingDate = (DateTime.TryParseExact(request.StartingDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now);
                if (!string.IsNullOrEmpty(request.LeaveDate))
                {
                    user.LeaveDate = (DateTime.TryParseExact(request.LeaveDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                }
                

                if (request.Avatar != null)
                {
                    if (!string.IsNullOrEmpty(user.Avatar))
                    {
                        await DeleteFile(user.Avatar);
                    }

                    user.Avatar = await this.SaveFile(request.Avatar);
                }

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    var appUser_AppUserTypes = await _context.AppUser_AppUserTypes.Where(m => m.AppUserId == user.Id).ToListAsync();
                    if (appUser_AppUserTypes != null)
                    {
                        _context.AppUser_AppUserTypes.RemoveRange(appUser_AppUserTypes);
                    }
                    
                    if (!string.IsNullOrEmpty(request.StrAppUserTypeIds))
                    {
                        appUser_AppUserTypes = new List<AppUser_AppUserType>();
                        foreach (string item in request.StrAppUserTypeIds.Split(',').ToList())
                        {
                            appUser_AppUserTypes.Add(new AppUser_AppUserType()
                            {
                                AppUserTypeId = Convert.ToInt32(item),
                                AppUserId = user.Id
                            });
                        }

                        _context.AppUser_AppUserTypes.AddRange(appUser_AppUserTypes);
                        await _context.SaveChangesAsync();
                    }

                    return new ApiSuccessResult<string>(user.Id.ToString());
                }

                return new ApiErrorResult<string>("Cập nhật không thành công");
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
                return new ApiErrorResult<int>("Không tìm thấy nhân viên này");
            }

            var newPassword = _userManager.PasswordHasher.HashPassword(user, request.NewPassword) ;
            user.PasswordHash = newPassword;            

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<int>();
            }
            return new ApiErrorResult<int>("Cập nhật không thành công");
        }
        private async Task<ApiResult<int>> DeleteById(Guid id)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(id.ToString());
                if (user == null)
                {
                    return new ApiErrorResult<int>("User không tồn tại");
                }

                if (!string.IsNullOrEmpty(user.Avatar))
                {
                    await this.DeleteFile(user.Avatar);
                }

                var appUser_AppUserTypes = await _context.AppUser_AppUserTypes.Where(m => m.AppUserId == user.Id).AsNoTracking().ToListAsync().ConfigureAwait(false);
                if(appUser_AppUserTypes != null)
                {
                    if(appUser_AppUserTypes.Count > 0)
                    {
                        _context.AppUser_AppUserTypes.RemoveRange(appUser_AppUserTypes);
                    }
                }

                var appUser_BasicSalaries = await _context.AppUser_BasicSalarys.Where(m => m.AppUserId == user.Id).AsNoTracking().ToListAsync().ConfigureAwait(false);
                if (appUser_BasicSalaries != null)
                {
                    if (appUser_BasicSalaries.Count > 0)
                    {
                        _context.AppUser_BasicSalarys.RemoveRange(appUser_BasicSalaries);
                    }
                }

                var appUser_CommissionDiscounts = await _context.AppUser_CommissionDiscounts.Where(m => m.AppUserId == user.Id).AsNoTracking().ToListAsync().ConfigureAwait(false);
                if (appUser_CommissionDiscounts != null)
                {
                    if (appUser_CommissionDiscounts.Count > 0)
                    {
                        _context.AppUser_CommissionDiscounts.RemoveRange(appUser_CommissionDiscounts);
                    }
                }

                var appUser_Promotions = await _context.AppUser_Promotions.Where(m => m.AppUserId == user.Id).AsNoTracking().ToListAsync().ConfigureAwait(false);
                if (appUser_Promotions != null)
                {
                    if (appUser_Promotions.Count > 0)
                    {
                        _context.AppUser_Promotions.RemoveRange(appUser_Promotions);
                    }
                }

                var appUserFeedbacks = await _context.AppUserFeedbacks.Where(m => m.AppUserId == user.Id).AsNoTracking().ToListAsync().ConfigureAwait(false);
                if (appUserFeedbacks != null)
                {
                    if (appUserFeedbacks.Count > 0)
                    {
                        _context.AppUserFeedbacks.RemoveRange(appUserFeedbacks);
                    }
                }

                var appUserHelps = await _context.AppUserHelps.Where(m => m.AppUserId == user.Id).AsNoTracking().ToListAsync().ConfigureAwait(false);
                if (appUserHelps != null)
                {
                    if (appUserHelps.Count > 0)
                    {
                        _context.AppUserHelps.RemoveRange(appUserHelps);
                    }
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

                bool checkPhieuKeToan = _context.PhieuKeToans.Any(x => x.AppUser == user || x.Customer == user || x.SaleStaff == user);
                if (!checkPhieuKeToan)
                {
                    var userResult = await _userManager.DeleteAsync(user);

                    if (userResult.Succeeded)
                    {
                        return new ApiSuccessResult<int>(1);
                    }

                    return new ApiErrorResult<int>("Xóa UserId: " + id.ToString() + " không thành công");
                }
                else
                {
                    return new ApiSuccessResult<int>(1);
                }
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
                                      StartingDate = u.StartingDate,
                                      Avatar = (!string.IsNullOrEmpty(u.Avatar) ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + u.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson])
                                  }
                            ).AsNoTracking().FirstOrDefaultAsync();

                if (user == null)
                {
                    return new ApiErrorResult<UserDto>("User không tồn tại.");
                }

                List<AppUserTypeDto> appUserTypes = await (from au_aut in _context.AppUser_AppUserTypes
                                                               join aut in _context.AppUserTypes on au_aut.AppUserTypeId equals aut.Id
                                                                    join autt in _context.AppUserTypeTranslations on aut.Id equals autt.AppUserTypeId into aut_autt
                                                                    from autt in aut_autt.DefaultIfEmpty()
                                                               where autt.LanguageId == request.LanguageId && au_aut.AppUserId == Guid.Parse(user.Id)
                                                               select new AppUserTypeDto()
                                                               {
                                                                   Id = aut.Id,
                                                                   Name = autt.Name
                                                               }).ToListAsync();

                user.AppUserTypes = appUserTypes;

                return new ApiSuccessResult<UserDto>(user);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<UserDto>(ex.Message);
            }            
        }
        public async Task<ApiResult<UserDto>> GetCustomerProfileDetailByUserId(UserRequest request)
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
                                      StartingDate = u.StartingDate,
                                      Avatar = (!string.IsNullOrEmpty(u.Avatar) ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + u.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                                      TotalDebt = u.TotalDebt,
                                      TotalMoney = u.TotalMoney,
                                      TongTienTraHang = u.TongTienTraHang,
                                      RewardPoints = u.RewardPoints,
                                      GenderId = u.GenderId,                                      
                                      CompanyName = u.CompanyName,
                                      TaxCode = u.TaxCode,
                                      GhiChu = u.GhiChu,
                                      SoDonHang = u.SoDonHang
                                  }
                            ).AsNoTracking().FirstOrDefaultAsync();

                if (user == null)
                {
                    return new ApiErrorResult<UserDto>("User không tồn tại.");
                }

                if(user.GenderId != null)
                {
                    var gender = await (from g in _context.Genders
                                        join gt in _context.GenderTranslations on g.Id equals gt.GenderId into g_gt
                                        from gt in g_gt.DefaultIfEmpty()
                                        where g.Id == user.GenderId && gt.LanguageId == request.LanguageId
                                        select new GenderDto(){
                                            Id = g.Id,
                                            Name = gt.Name
                                        }).AsNoTracking().FirstOrDefaultAsync().ConfigureAwait(false);

                    if (gender != null)
                    {
                        user.Gender = gender;
                    }
                }
                

                List <AppUserTypeDto> appUserTypes = await (from au_aut in _context.AppUser_AppUserTypes
                                                           join aut in _context.AppUserTypes on au_aut.AppUserTypeId equals aut.Id
                                                           join autt in _context.AppUserTypeTranslations on aut.Id equals autt.AppUserTypeId into aut_autt
                                                           from autt in aut_autt.DefaultIfEmpty()
                                                           where autt.LanguageId == request.LanguageId && au_aut.AppUserId == Guid.Parse(user.Id)
                                                           select new AppUserTypeDto()
                                                           {
                                                               Id = aut.Id,
                                                               Name = autt.Name
                                                           }).ToListAsync();

                user.AppUserTypes = appUserTypes;

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
                                      IsStillInUse = u.IsStillInUse
                                  }
                            ).AsNoTracking().FirstOrDefaultAsync();

                if (user == null)
                {
                    return new ApiErrorResult<UserDto>("User không tồn tại.");
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
                                      IsStillInUse = u.IsStillInUse,
                                      TotalDebt = u.TotalDebt,
                                      TotalMoney = u.TotalMoney,
                                      TongTienTraHang = u.TongTienTraHang,
                                      RewardPoints = u.RewardPoints,
                                      SoDonHang = u.SoDonHang
                                  }
                            ).AsNoTracking().FirstOrDefaultAsync();

                if (user == null)
                {
                    return new ApiErrorResult<UserDto>("User không tồn tại.");
                }

                return new ApiSuccessResult<UserDto>(user);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<UserDto>(ex.Message);
            }
        }
        public async Task<ApiResult<UserDto>> GetSupplierSecurityByUserId(UserRequest request)
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
                                      IsStillInUse = u.IsStillInUse
                                  }
                            ).AsNoTracking().FirstOrDefaultAsync();

                if (user == null)
                {
                    return new ApiErrorResult<UserDto>("User không tồn tại.");
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
        public async Task<ApiResult<string>> DeleteAvatarByUserId(string userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    return new ApiErrorResult<string>("User không tồn tại");
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
        public async Task<ApiResult<string>> AddOrUpdateCustomerProfileDetailAsync(UserRequest request)
        {
            try
            {
                DateTime ngayValue;
                AppUser user;

                if (string.IsNullOrEmpty(request.Id))
                {
                    var hasher = new PasswordHasher<AppUser>();

                    user = new AppUser()
                    {
                        Email = request.Email,
                        FirstName = request.FirstName,
                        UserName = request.PhoneNumber.Trim(),
                        LastName = request.LastName,
                        GenderId = request.GenderId,
                        Dob = (DateTime.TryParseExact(request.Dob, _configuration[SystemConstants.AppConstants.DateFormat],
                                        null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>()),
                        PasswordHash = string.IsNullOrEmpty(request.Password) ? hasher.HashPassword(null, "123Abc!!!") : hasher.HashPassword(null, request.Password),
                        Address = request.Address,
                        PhoneNumber = request.PhoneNumber,
                        TaxCode = request.TaxCode,
                        ContactPerson = request.ContactPerson,
                        Description = request.Description,
                        ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                        CreatedUserId = Guid.Parse(request.CreatedUserId),
                        CompanyName = request.CompanyName,
                        GhiChu = request.GhiChu
                    };

                    if (request.Avatar != null)
                    {
                        if (!string.IsNullOrEmpty(user.Avatar))
                        {
                            await DeleteFile(user.Avatar);
                        }

                        user.Avatar = await this.SaveFile(request.Avatar);
                    }
                    var result = await _userManager.CreateAsync(user);

                    if (result.Succeeded)
                    {

                        if (!string.IsNullOrEmpty(request.StrAppUserTypeIds))
                        {
                            List<AppUser_AppUserType> appUser_AppUserTypes = new List<AppUser_AppUserType>();
                            foreach (string item in request.StrAppUserTypeIds.Split(',').ToList())
                            {
                                appUser_AppUserTypes.Add(new AppUser_AppUserType()
                                {
                                    AppUserTypeId = Convert.ToInt32(item),
                                    AppUserId = user.Id
                                });
                            }

                            _context.AppUser_AppUserTypes.AddRange(appUser_AppUserTypes);
                            await _context.SaveChangesAsync();
                        }

                        return new ApiSuccessResult<string>(user.Id.ToString());
                    }
                    else
                    {
                        return new ApiErrorResult<string>("Thêm mới không thành công");
                    }
                }
                else
                {
                    user = await _userManager.FindByIdAsync(request.Id);
                    if (user == null)
                    {
                        return new ApiErrorResult<string>("Không tìm thấy user");
                    }

                    user.Code = request.Code;
                    user.FirstName = request.FirstName;
                    user.LastName = request.LastName;
                    user.GenderId = request.GenderId;
                    user.Dob = (DateTime.TryParseExact(request.Dob, _configuration[SystemConstants.AppConstants.DateFormat],
                                        null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                    user.PhoneNumber = request.PhoneNumber;
                    user.Address = request.Address;
                    user.TaxCode = request.TaxCode;
                    user.Description = request.Description;
                    user.ContactPerson = request.ContactPerson;
                    user.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                    user.CompanyName = request.CompanyName;
                    user.GhiChu = request.GhiChu;

                    if (request.Avatar != null)
                    {
                        if (!string.IsNullOrEmpty(user.Avatar))
                        {
                            await DeleteFile(user.Avatar);
                        }

                        user.Avatar = await this.SaveFile(request.Avatar);
                    }

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var appUser_AppUserTypes = await _context.AppUser_AppUserTypes.Where(m => m.AppUserId == user.Id).ToListAsync();
                        if (appUser_AppUserTypes != null)
                        {
                            _context.AppUser_AppUserTypes.RemoveRange(appUser_AppUserTypes);
                        }

                        if (!string.IsNullOrEmpty(request.StrAppUserTypeIds))
                        {
                            appUser_AppUserTypes = new List<AppUser_AppUserType>();
                            foreach (string item in request.StrAppUserTypeIds.Split(',').ToList())
                            {
                                appUser_AppUserTypes.Add(new AppUser_AppUserType()
                                {
                                    AppUserTypeId = Convert.ToInt32(item),
                                    AppUserId = user.Id
                                });
                            }

                            _context.AppUser_AppUserTypes.AddRange(appUser_AppUserTypes);
                            await _context.SaveChangesAsync();
                        }

                        return new ApiSuccessResult<string>(user.Id.ToString());
                    }

                    return new ApiErrorResult<string>("Cập nhật không thành công");
                }
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        public async Task<ApiResult<string>> AddOrUpdateSupplierProfileDetailAsync(UserRequest request)
        {
            try
            {
                DateTime ngayValue;
                AppUser user;

                if (string.IsNullOrEmpty(request.Id))
                {
                    var hasher = new PasswordHasher<AppUser>();

                    user = new AppUser()
                    {
                        Email = request.Email,
                        FirstName = request.FirstName,
                        UserName = request.PhoneNumber.Trim(),
                        LastName = request.LastName,
                        GenderId = request.GenderId > 0 ? request.GenderId : null,
                        Dob = (DateTime.TryParseExact(request.Dob, _configuration[SystemConstants.AppConstants.DateFormat],
                                        null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>()),
                        PasswordHash = string.IsNullOrEmpty(request.Password) ? hasher.HashPassword(null, "123Abc!!!") : hasher.HashPassword(null, request.Password),
                        Address = request.Address,
                        PhoneNumber = request.PhoneNumber,
                        TaxCode = request.TaxCode,
                        ContactPerson = request.ContactPerson,
                        Description = request.Description,
                        ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                        CreatedUserId = Guid.Parse(request.CreatedUserId)
                    };


                    if (request.Avatar != null)
                    {
                        if (!string.IsNullOrEmpty(user.Avatar))
                        {
                            await DeleteFile(user.Avatar);
                        }

                        user.Avatar = await this.SaveFile(request.Avatar);
                    }
                    var result = await _userManager.CreateAsync(user);

                    if (result.Succeeded)
                    {

                        if (!string.IsNullOrEmpty(request.StrAppUserTypeIds))
                        {
                            List<AppUser_AppUserType> appUser_AppUserTypes = new List<AppUser_AppUserType>();
                            foreach (string item in request.StrAppUserTypeIds.Split(',').ToList())
                            {
                                appUser_AppUserTypes.Add(new AppUser_AppUserType()
                                {
                                    AppUserTypeId = Convert.ToInt32(item),
                                    AppUserId = user.Id
                                });
                            }

                            _context.AppUser_AppUserTypes.AddRange(appUser_AppUserTypes);
                            await _context.SaveChangesAsync();
                        }

                        return new ApiSuccessResult<string>(user.Id.ToString());
                    }
                    else
                    {
                        return new ApiErrorResult<string>("Thêm mới không thành công");
                    }
                }
                else
                {
                    user = await _userManager.FindByIdAsync(request.Id);
                    if (user == null)
                    {
                        return new ApiErrorResult<string>("Không tìm thấy user");
                    }

                    user.Code = request.Code;
                    user.FirstName = request.FirstName;
                    user.LastName = request.LastName;
                    user.GenderId = request.GenderId;
                    user.Dob = (DateTime.TryParseExact(request.Dob, _configuration[SystemConstants.AppConstants.DateFormat],
                                        null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                    user.PhoneNumber = request.PhoneNumber;
                    user.Address = request.Address;
                    user.TaxCode = request.TaxCode;
                    user.Description = request.Description;
                    user.ContactPerson = request.ContactPerson;
                    user.ModifiedUserId = Guid.Parse(request.ModifiedUserId);

                    if (request.Avatar != null)
                    {
                        if (!string.IsNullOrEmpty(user.Avatar))
                        {
                            await DeleteFile(user.Avatar);
                        }

                        user.Avatar = await this.SaveFile(request.Avatar);
                    }

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var appUser_AppUserTypes = await _context.AppUser_AppUserTypes.Where(m => m.AppUserId == user.Id).ToListAsync();
                        if (appUser_AppUserTypes != null)
                        {
                            _context.AppUser_AppUserTypes.RemoveRange(appUser_AppUserTypes);
                        }

                        if (!string.IsNullOrEmpty(request.StrAppUserTypeIds))
                        {
                            appUser_AppUserTypes = new List<AppUser_AppUserType>();
                            foreach (string item in request.StrAppUserTypeIds.Split(',').ToList())
                            {
                                appUser_AppUserTypes.Add(new AppUser_AppUserType()
                                {
                                    AppUserTypeId = Convert.ToInt32(item),
                                    AppUserId = user.Id
                                });
                            }

                            _context.AppUser_AppUserTypes.AddRange(appUser_AppUserTypes);
                            await _context.SaveChangesAsync();
                        }

                        return new ApiSuccessResult<string>(user.Id.ToString());
                    }

                    return new ApiErrorResult<string>("Cập nhật không thành công");
                }
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        public async Task<PagedResult<PayrollDto>> GetStaffSalaryManageListPaging(ManageUserPagingRequest request)
        {
            try
            {
                var query = from pd in _context.PayrollDetails
                            join p in _context.Payrolls on pd.PayrollId equals p.Id
                            join pt in _context.PayrollTranslations on p.Id equals pt.PayrollId
                            where pd.AppUserId == Guid.Parse(request.AppUserId) && pt.LanguageId == request.LanguageId
                            select new { pd, p, pt };
                            

                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.pt.Name.Contains(request.TextSearch));
                }
                //3.Sort

                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.p.Id) :
                                query.OrderByDescending(x => x.p.Id);

                            break;

                        case "StrFromDate":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.p.FromDate) :
                                query.OrderByDescending(x => x.p.FromDate);

                            break;

                        default:
                            query = query.OrderByDescending(x => x.p.FromDate);
                            break;
                    }
                }


                //4. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                    .Take(request.PageSize);
                }

                var data = await query.Select(x => new PayrollDto()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    StrFromDate = x.p.FromDate.ToString("dd/MM/yyyy"),
                    StrToDate = x.p.ToDate.ToString("dd/MM/yyyy"),
                    BasicSalary = x.pd.BasicSalary,
                    Discount = x.pd.Discount,
                    Commission = x.pd.Commission,
                    Total = x.pd.Total
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<PayrollDto>()
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
                return new PagedResult<PayrollDto>()
                {
                    TotalRecords = 0,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = null,
                    Message = ex.Message
                };
            }

        }
        public async Task<ApiResult<string>> CustomerRegisterFromMobile(UserRequest request)
        {
            try
            {
                bool isNew = false;
                DateTime registerDateValue;
                AppUser user = null;

                if (string.IsNullOrEmpty(request.Id))
                {
                    isNew = true;

                    user = await _userManager.FindByNameAsync(request.UserName);
                    if (user != null)
                    {
                        return new ApiErrorResult<string>("Tài khoản đã tồn tại");
                    }
                    else if (await _userManager.FindByEmailAsync(request.Email) != null)
                    {
                        return new ApiErrorResult<string>("Emai đã tồn tại");
                    }

                    user = new AppUser()
                    {
                        CreatedDate = DateTime.Now
                    };
                }
                else
                {
                    user = await _userManager.FindByIdAsync(request.Id.ToString());
                    if (await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.Id != Guid.Parse(request.Id)))
                    {
                        return new ApiErrorResult<string>("Emai đã tồn tại");
                    }
                }

                user.UserName = request.UserName;
                user.Email = request.Email;
                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    user.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }
                user.IsActive = request.IsActive;
                if (request.IsActive == true)
                {
                    user.ActivateDate = DateTime.Now;
                }
                user.IsStillInUse = request.IsStillInUse;
                user.RegisterDate = (DateTime.TryParseExact(request.RegisterDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out registerDateValue) ? registerDateValue : DateTime.Now);
                user.ModifiedDate = DateTime.Now;

                if (isNew == true)
                {
                    var result = await _userManager.CreateAsync(user, request.Password);
                    if (!result.Succeeded)
                    {
                        return new ApiErrorResult<string>("Đăng ký không thành công");
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
                                return new ApiErrorResult<string>("Xóa mật khẩu cũ không thành công.");
                            }
                        }

                        if (!(await _userManager.AddPasswordAsync(user, request.Password)).Succeeded)
                        {
                            return new ApiErrorResult<string>("Đổi mật khẩu không thành công.");
                        }
                    }

                    var result = await _userManager.UpdateAsync(user);
                    if (!result.Succeeded)
                    {
                        return new ApiErrorResult<string>("Cập nhật không thành công");
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

                if (!string.IsNullOrEmpty(request.AppUserTypeCodes))
                {
                    List<string> appUserTypeCodes = request.AppUserTypeCodes.Split(',').ToList();
                    List<AppUserType> appUserTypes = await _context.AppUserTypes.Where(m => appUserTypeCodes.Contains(m.Code)).ToListAsync();

                    foreach (var appUserType in appUserTypes)
                    {
                        if (await _context.AppUser_AppUserTypes.CountAsync(m => m.AppUserId == user.Id && m.AppUserTypeId == appUserType.Id) == 0)
                        {
                            _context.AppUser_AppUserTypes.Add(new AppUser_AppUserType()
                            {
                                AppUserTypeId = appUserType.Id,
                                AppUserId = user.Id
                            });

                            await _context.SaveChangesAsync();
                        }
                    }
                }

                return new ApiSuccessResult<string>(user.Id.ToString());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        public async Task<ApiResult<UserDto>> GetCustomerProfileFromMobile(string id)
        {
            try
            {
                var user = await (from u in _context.Users
                                  join c in _context.Countries on u.CountryId equals c.Id
                                  where u.Id == Guid.Parse(id)
                                  select new UserDto()
                                  {
                                      Id = u.Id.ToString(),
                                      FullName = u.LastName + " " + u.FirstName,
                                      CountryCode = c.Code,
                                      PhoneNumber = u.PhoneNumber,
                                      Email = u.Email,
                                      AddressStreet = u.AddressStreet,
                                      AddressDistrict = u.AddressDistrict,
                                      AddressWard = u.AddressWard,
                                      AddressCity = u.AddressCity,
                                      DateOfBirth = (u.Dob != null ? u.Dob.Value.ToString("dd/MM/yyyy") : string.Empty),
                                      //IsEmailVerified = u.IsEmailVerified,
                                      //IsPhoneVerified = u.IsPhoneVerified,
                                      //Pin = u.Pin,
                                      //RewardPoints = u.RewardPoints
                                  }).AsNoTracking().FirstOrDefaultAsync();

                if (user != null)
                {
                    //var promotionIds = await _context.AppUser_Promotions.Where(m => m.AppUserId == Guid.Parse(user.Id)).Select(m => m.Id).ToListAsync();
                    //if (promotionIds != null)
                    //{
                    //    user.RewardList = promotionIds;
                    //}

                    //var favoriteProductIds = await _context.FavoriteProducts.Where(m => m.AppUserId == Guid.Parse(user.Id)).Select(m => m.Id).ToListAsync();
                    //if (favoriteProductIds != null)
                    //{
                    //    user.FavoriteProductIds = favoriteProductIds;
                    //}
                }
                else
                {
                    return new ApiErrorResult<UserDto>("Không tìm thấy Profile");
                }

                return new ApiSuccessResult<UserDto>(user);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<UserDto>(ex.Message);
            }            
        }
        public async Task<ApiResult<string>> SaveCustomerProfileFromMobile(MobileUserProfileRequest request)
        {
            DateTime dateOfBirthValue;

            try 
            {
                var user = await _userManager.FindByIdAsync(request.Id);
                if (user == null)
                {
                    return new ApiErrorResult<string>("User không tồn tại");
                }

                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    user.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }

                user.FirstName = request.FirstName;
                user.ModifiedDate = DateTime.Now;
                user.CountryId = request.CountryId;
                user.PhoneNumber = request.PhoneNumber;
                user.Email = request.Email;
                user.AddressStreet = request.AddressStreet;
                user.AddressDistrict = request.AddressDistrict;
                user.AddressWard = request.AddressWard;
                user.AddressCity = request.AddressCity;
                user.CustomerTypeId = request.AccountType;
                user.Dob = (DateTime.TryParseExact(request.DateOfBirth, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out dateOfBirthValue) ? dateOfBirthValue : DateTime.Now);
                //user.IsEmailVerified = false;
                //user.IsPhoneVerified = false;
                //user.Pin = string.Empty;
                //user.RewardPoints = 0;

                var appUser_AppUserType = await _context.AppUser_AppUserTypes.Where(m => m.AppUserId == user.Id && m.AppUserTypeId == request.AccountType).ToListAsync().ConfigureAwait(false);
                if (appUser_AppUserType == null)
                {
                    _context.AppUser_AppUserTypes.Add(new AppUser_AppUserType() {
                        AppUserId = user.Id,
                        AppUserTypeId = request.AccountType
                    });
                }

                //var appUser_Promotions = await _context.AppUser_Promotions.Where(m => m.AppUserId == user.Id).ToListAsync();
                //if (appUser_Promotions != null)
                //{
                //    _context.AppUser_Promotions.RemoveRange(appUser_Promotions);
                //}
                //if(request.RewardList != null)
                //{
                //    foreach (var item in request.RewardList)
                //    {
                //        _context.AppUser_Promotions.Add(new AppUser_Promotion() { 
                //            AppUserId = user.Id,
                //            PromotionId = item
                //        });
                //    }
                //}

                //var favoriteProducts = await _context.FavoriteProducts.Where(m => m.AppUserId == user.Id).ToListAsync();
                //if (favoriteProducts != null)
                //{
                //    _context.FavoriteProducts.RemoveRange(favoriteProducts);
                //}
                //if (request.FavoriteProducts != null)
                //{
                //    foreach (var item in request.FavoriteProducts)
                //    {
                //        _context.FavoriteProducts.Add(new FavoriteProduct()
                //        {
                //            AppUserId = user.Id,
                //            ProductId = item
                //        });
                //    }
                //}

                await _userManager.UpdateAsync(user);

                return new ApiSuccessResult<string>(user.Id.ToString());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> SaveCustomerFeedbackFromMobile(MobileAppUserFeedbackRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.UserId))
                {
                    return new ApiErrorResult<int>("UserId không được phép để trống.");
                }
                
                _context.AppUserFeedbacks.Add(new AppUserFeedback()
                {
                    AppUserId = Guid.Parse(request.UserId),
                    Rate = request.Rate,
                    Description = request.Note
                });

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> SaveCustomerHelpFromMobile(MobileAppUserHelpRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.UserId))
                {
                    return new ApiErrorResult<int>("UserId không được phép để trống.");
                }

                var help = _context.AppUserHelps.Add(new AppUserHelp()
                {
                    AppUserId = Guid.Parse(request.UserId),
                    Description = request.Note
                });

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<ApiResult<string>> CustomerPinCheckFromMobile(MobileUserPinCheckRequest request)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(request.UserId);
                if (user == null)
                {
                    return new ApiErrorResult<string>("User không tồn tại");
                }

                return new ApiSuccessResult<string>();
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        
        public async Task<ApiResult<string>> ImportDataCustomerFromExcelFile(UserRequest request)
        {
            string message = string.Empty;
            try
            {
                if (request.ImportDataExcelFiles.Count > 0)
                {
                    foreach (var file in request.ImportDataExcelFiles)
                    {
                        if (file.Length > 0)
                        {
                            Stream stream = file.OpenReadStream();

                            IExcelDataReader reader = null;

                            if (file.FileName.EndsWith(".xls"))
                            {
                                reader = ExcelReaderFactory.CreateBinaryReader(stream);
                            }
                            else if (file.FileName.EndsWith(".xlsx"))
                            {
                                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                            }
                            else
                            {
                                return new ApiErrorResult<string>("Không đọc được file.");
                            }


                            DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = false
                                }
                            });
                            reader.Close();

                            if (ds.Tables.Count > 0)
                            {
                                message += await ImportDataCustomerAsyn(ds);
                            }
                        }
                    }
                }

                return new ApiSuccessResult<string>(message);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        private async Task<string> ImportDataCustomerAsyn(DataSet ds)
        {
            bool isNew = false;
            DateTime dateOfBirthValue, ngayMuaCuoiValue;
            double doubleValue;
            int soDonHangValue;
            string message = string.Empty;
            BHSNetCoreLib.ConvertFont convertFont = new BHSNetCoreLib.ConvertFont();

            foreach (DataTable dt in ds.Tables)
            {
                if (dt.Rows.Count > 0)
                {
                    int rowIndex = 6;
                    while (rowIndex < dt.Rows.Count)
                    {
                        string error = string.Empty;
                        isNew = false;
                        string code = (!string.IsNullOrEmpty(dt.Rows[rowIndex][1].ToString()) ? dt.Rows[rowIndex][1].ToString().Trim() : string.Empty);
                        string lastName = string.Empty;
                        string firstName = dt.Rows[rowIndex][2].ToString();
                        string phoneNumber = (!string.IsNullOrEmpty(dt.Rows[rowIndex][3].ToString()) ? dt.Rows[rowIndex][3].ToString().Trim() : string.Empty);
                        string email = (!string.IsNullOrEmpty(dt.Rows[rowIndex][4].ToString()) ? dt.Rows[rowIndex][4].ToString().Trim() : string.Empty);
                        string address = (!string.IsNullOrEmpty(dt.Rows[rowIndex][5].ToString()) ? dt.Rows[rowIndex][5].ToString().Trim() : string.Empty);
                        string genderName = (!string.IsNullOrEmpty(dt.Rows[rowIndex][6].ToString()) ? dt.Rows[rowIndex][6].ToString().Trim() : string.Empty);
                        string dob = (!string.IsNullOrEmpty(dt.Rows[rowIndex][7].ToString()) ? dt.Rows[rowIndex][7].ToString().Trim() : string.Empty);
                        string ngayMuaCuoi = (!string.IsNullOrEmpty(dt.Rows[rowIndex][8].ToString()) ? dt.Rows[rowIndex][8].ToString().Trim() : string.Empty);
                        string soDonHang = (!string.IsNullOrEmpty(dt.Rows[rowIndex][9].ToString()) ? dt.Rows[rowIndex][9].ToString().Trim() : string.Empty);
                        string tongTienMuaHang = (!string.IsNullOrEmpty(dt.Rows[rowIndex][10].ToString()) ? dt.Rows[rowIndex][10].ToString().Trim() : string.Empty);
                        string tongTienTraHang = (!string.IsNullOrEmpty(dt.Rows[rowIndex][11].ToString()) ? dt.Rows[rowIndex][11].ToString().Trim() : string.Empty);
                        string conNo = (!string.IsNullOrEmpty(dt.Rows[rowIndex][12].ToString()) ? dt.Rows[rowIndex][12].ToString().Trim() : string.Empty);
                        string nhomKhachHang = (!string.IsNullOrEmpty(dt.Rows[rowIndex][13].ToString()) ? dt.Rows[rowIndex][13].ToString().Trim() : string.Empty);
                        string diemTichLuy = (!string.IsNullOrEmpty(dt.Rows[rowIndex][14].ToString()) ? dt.Rows[rowIndex][14].ToString().Trim() : string.Empty);
                        string ghiChu = (!string.IsNullOrEmpty(dt.Rows[rowIndex][15].ToString()) ? dt.Rows[rowIndex][15].ToString().Trim() : string.Empty);

                        if (!string.IsNullOrEmpty(code))
                        {
                            var user = await _userManager.Users.FirstOrDefaultAsync(m => m.Code.Trim().ToLower() == code.Trim().ToLower());

                            if (user == null)
                            {
                                isNew = true;

                                if ((await _userManager.FindByNameAsync(phoneNumber)) != null)
                                {
                                    error = "Số điện thoại " + phoneNumber + " đã tồn tại. ";
                                }
                                
                                if (string.IsNullOrEmpty(error))
                                {
                                    user = new AppUser()
                                    {
                                        CreatedDate = DateTime.Now,
                                        Code = code
                                    };
                                }
                            }
                            
                            if (string.IsNullOrEmpty(error))
                            {
                                user.UserName = phoneNumber;
                                user.IsActive = true;
                                user.ActivateDate = DateTime.Now;
                                user.IsStillInUse = true;
                                user.RegisterDate = DateTime.Now;
                                user.ModifiedDate = DateTime.Now;
                                user.LastName = lastName;
                                user.FirstName = firstName;
                                user.PhoneNumber = phoneNumber;
                                user.Address = address;
                                user.Email = email;
                                user.Dob = (!string.IsNullOrEmpty(dob) ? (DateTime.TryParseExact(dob, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out dateOfBirthValue) ? dateOfBirthValue : new Nullable<DateTime>()) : new Nullable<DateTime>());
                                if(Int32.TryParse(soDonHang, out soDonHangValue))
                                {
                                    user.SoDonHang = soDonHangValue;
                                }
                                else
                                {
                                    user.SoDonHang = 0;
                                }

                                user.GhiChu = ghiChu;
                                user.LastimePurchase = (!string.IsNullOrEmpty(ngayMuaCuoi) ? (DateTime.TryParseExact(ngayMuaCuoi, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayMuaCuoiValue) ? ngayMuaCuoiValue : new Nullable<DateTime>()) : new Nullable<DateTime>());
                                user.TotalDebt = (!string.IsNullOrEmpty(conNo) ? (double.TryParse(conNo, out doubleValue) ? doubleValue : 0) : 0);
                                user.TotalMoney = (!string.IsNullOrEmpty(tongTienMuaHang) ? (double.TryParse(tongTienMuaHang, out doubleValue) ? doubleValue : 0) : 0);
                                user.TongTienTraHang = (!string.IsNullOrEmpty(tongTienTraHang) ? (double.TryParse(tongTienTraHang, out doubleValue) ? doubleValue : 0) : 0);
                                user.RewardPoints = (!string.IsNullOrEmpty(diemTichLuy) ? (double.TryParse(diemTichLuy, out doubleValue) ? doubleValue : 0) : 0);
                                user.UserName = phoneNumber.Trim();

                                if (!string.IsNullOrEmpty(genderName))
                                {
                                    var gender = await (from g in _context.Genders
                                                        join gt in _context.GenderTranslations on g.Id equals gt.GenderId
                                                        join l in _context.Languages on gt.LanguageId equals l.Id
                                                        where l.Code == _configuration[SystemConstants.AppConstants.VietnameseLanguageCode]
                                                                && gt.Name == genderName
                                                        select new GenderDto() {
                                                            Id = g.Id
                                                        }
                                                ).AsNoTracking().FirstOrDefaultAsync();
                                    if (gender != null)
                                    {
                                        user.GenderId = gender.Id;
                                    }                                    
                                }

                                if (isNew == true)
                                {
                                    var result = await _userManager.CreateAsync(user, phoneNumber);
                                    if (!result.Succeeded)
                                    {
                                        error = "Mã khách hàng: " + code + " tạo tài khoản không thành công. ";
                                    }
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(phoneNumber))
                                    {
                                        if (user.PasswordHash != null)
                                        {
                                            if (!(await _userManager.RemovePasswordAsync(user)).Succeeded)
                                            {
                                                error = "Mã khách hàng: " + code + ", xóa mật khẩu cũ không thành công. ";
                                            }
                                        }

                                        if (string.IsNullOrEmpty(error) && !(await _userManager.AddPasswordAsync(user, phoneNumber)).Succeeded)
                                        {
                                            error = "Mã khách hàng: " + code + ", Đổi mật khẩu không thành công. ";
                                        }
                                    }

                                    if (string.IsNullOrEmpty(error))
                                    {
                                        var result = await _userManager.UpdateAsync(user);
                                        if (!result.Succeeded)
                                        {
                                            error = "Mã khách hàng: " + code + ", Cập nhật không thành công. ";
                                        }
                                    }
                                }

                                if(string.IsNullOrEmpty(error))
                                {
                                    await _userManager.RemoveFromRolesAsync(user, await _userManager.GetRolesAsync(user));

                                    _context.AppUser_AppUserTypes.RemoveRange(await _context.AppUser_AppUserTypes.Where(m => m.AppUserId == user.Id).ToListAsync());

                                    string appUserTypeCustomerCodes = _configuration[SystemConstants.UserConstants.AppUserType_Customer];
                                    List<string> appUserTypeCodes = appUserTypeCustomerCodes.Split(',').ToList();

                                    if (string.IsNullOrEmpty(nhomKhachHang))
                                    {
                                        List<string> appUserTypeNames = nhomKhachHang.Split("||").ToList();

                                        //thêm appUserType mới
                                        foreach (var appUserTypeName in appUserTypeNames)
                                        {
                                            var appUserType = await (from aut in _context.AppUserTypes
                                                                     join autt in _context.AppUserTypeTranslations on aut.Id equals autt.AppUserTypeId into aut_autt
                                                                     from autt in aut_autt.DefaultIfEmpty()
                                                                     join l in _context.Languages on autt.LanguageId equals l.Id
                                                                     where l.Code == _configuration[SystemConstants.AppConstants.VietnameseLanguageCode]
                                                                             && autt.Name.Trim().ToLower() == appUserTypeName.Trim().ToLower()
                                                                     select new AppUserTypeDto()
                                                                     {
                                                                         Code = aut.Code
                                                                     }).AsNoTracking().FirstOrDefaultAsync();

                                            if(appUserType == null)
                                            {
                                                var languages = _context.Languages;
                                                var translations = new List<AppUserTypeTranslation>();
                                                foreach (var language in languages)
                                                {
                                                    if (language.Code == _configuration[SystemConstants.AppConstants.VietnameseLanguageCode])
                                                    {
                                                        translations.Add(new AppUserTypeTranslation()
                                                        {
                                                            Name = appUserTypeName.Trim(),
                                                            LanguageId = language.Id
                                                        });
                                                    }
                                                    else
                                                    {
                                                        translations.Add(new AppUserTypeTranslation()
                                                        {
                                                            Name = SystemConstants.AppConstants.NA,
                                                            LanguageId = language.Id
                                                        });
                                                    }
                                                }

                                                _context.AppUserTypes.Add(new AppUserType()
                                                {
                                                    AppUserTypeTranslations = translations,
                                                    Code = appUserTypeName.Trim()
                                                });
                                                await _context.SaveChangesAsync();
                                            }
                                        }


                                        var queryAppUserTypeCodes = await (from au_aut in _context.AppUser_AppUserTypes
                                                                           join aut in _context.AppUserTypes on au_aut.AppUserTypeId equals aut.Id
                                                                           join autt in _context.AppUserTypeTranslations on aut.Id equals autt.AppUserTypeId into aut_autt
                                                                           from autt in aut_autt.DefaultIfEmpty()
                                                                           join l in _context.Languages on autt.LanguageId equals l.Id
                                                                           where l.Code == _configuration[SystemConstants.AppConstants.VietnameseLanguageCode]
                                                                                   && appUserTypeNames.Contains(autt.Name)
                                                                           select new AppUserTypeDto()
                                                                           {
                                                                               Code = aut.Code
                                                                           }).AsNoTracking().ToListAsync();

                                        foreach(var item in queryAppUserTypeCodes)
                                        {
                                            if(appUserTypeCodes.FirstOrDefault(m => m == item.Code) == null)
                                            {
                                                appUserTypeCodes.Add(item.Code);
                                            }    
                                        }
                                    }

                                    List<AppUserType> appUserTypes = await _context.AppUserTypes.Where(m => appUserTypeCodes.Contains(m.Code)).ToListAsync();

                                    foreach (var appUserType in appUserTypes)
                                    {
                                        _context.AppUser_AppUserTypes.Add(new AppUser_AppUserType()
                                        {
                                            AppUserTypeId = appUserType.Id,
                                            AppUserId = user.Id
                                        });
                                    }

                                    
                                }
                            }

                            message += error;

                            await _context.SaveChangesAsync();
                        }

                        rowIndex++;
                    }
                }
                else
                {
                    message += "Không tìm thấy Số phiếu ở Sheet: " + dt.TableName;
                }
            }

            return message;
        }
    }
}


using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SnailApp.ViewModels.System.User_Clinics;
using AutoMapper;
using SnailApp.Utilities.Exceptions;

namespace SnailApp.Application.SystemApplication.Users
{
    public interface IUser_ClinicService
    {
        Task<List<User_ClinicDto>> GetClinicByUser(ManageUser_ClinicPagingRequest request);
        Task<PagedResult<User_ClinicDto>> GetUserByClinicIdManageListPaging(ManageUser_ClinicPagingRequest request);
        Task<ApiResult<int>> DeleteByIds(User_ClinicDeleteRequest request);
        Task<ApiResult<int>> AddAsync(User_ClinicDto request);

    }
    public class User_ClinicService : IUser_ClinicService
    {
        private readonly IConfiguration _configuration;
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;

        public User_ClinicService(
            IConfiguration configuration,
            ClinicDbContext context,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _configuration = configuration;
            _context = context;
        }
        public async Task<List<User_ClinicDto>> GetClinicByUser(ManageUser_ClinicPagingRequest request)
        {
            try
            {
                var query = from u_c in _context.User_Clinics
                            join c in _context.Clinics on u_c.ClinicID equals c.Id
                            where u_c.UserId == request.UserId
                            select new User_ClinicDto()
                            {
                                ClinicId = c.Id,
                                ClinicName = c.Name
                            };

                int totalRow = await query.CountAsync();
                var data = await query.AsNoTracking().ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<PagedResult<User_ClinicDto>> GetUserByClinicIdManageListPaging(ManageUser_ClinicPagingRequest request)
        {
            try
            {
                var query = from u_c in _context.User_Clinics
                            join u in _context.AppUsers on u_c.UserId equals u.Id
                            where u_c.ClinicID == request.ClinicId
                            select new User_ClinicDto()
                            {
                                Id = u_c.Id,
                                UserId = u.Id,
                                Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + (!string.IsNullOrEmpty(u.Avatar) ? (_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + u.Avatar) : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                                LastName = u.LastName,
                                FirstName = u.FirstName,
                                PhoneNumber = u.PhoneNumber,
                                CreatedDate = u_c.CreatedDate,
                            };

                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x =>
                        (x.FirstName + " " + x.LastName).Contains(request.TextSearch)
                     || (x.PhoneNumber).Contains(request.TextSearch)
                     );
                }

                //3. Sort
                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.Id) :
                                query.OrderByDescending(x => x.Id);

                            break;

                        default:
                            query = query.OrderByDescending(x => x.CreatedDate);
                            break;
                    }
                }

                int totalRow = await query.CountAsync();
                //4. Paging

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                    .Take(request.PageSize);
                }

                var data = await query.AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<User_ClinicDto>()
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
                return new PagedResult<User_ClinicDto>()
                {
                    TotalRecords = 0,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = null,
                    Message = ex.Message
                };
            }

        }
        public async Task<ApiResult<int>> AddAsync(User_ClinicDto request)
        {
            try
            {
                var check = await _context.User_Clinics.FirstOrDefaultAsync(x => x.ClinicID == request.ClinicId && x.UserId == request.UserId);

                if(check == null)
                {
                    var clinic = _mapper.Map<AppUser_Clinic>(request);
                    _context.User_Clinics.Add(clinic);
                    await _context.SaveChangesAsync();
                    return new ApiSuccessResult<int>(clinic.Id);
                }

                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "User is exits in clinic"
                };
            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }
        
        public async Task<ApiResult<int>> DeleteByIds(User_ClinicDeleteRequest request)
        {
            try
            {
                var clinics = await _context.User_Clinics.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (clinics == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                var clinicIds = clinics.Select(m => m.Id).ToList();
                _context.User_Clinics.RemoveRange(clinics);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }
    }
}


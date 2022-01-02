using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.System.AppUser_AppUserTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SnailApp.Application.SystemApplication.AppUser_AppUserTypes
{
    public interface IAppUser_AppUserTypeService
    {
        Task<ApiResult<int>> AddOrUpdateAsync(AppUser_AppUserTypeRequest request);
        Task<ApiResult<List<AppUser_AppUserTypeDto>>> GetAll(ManageAppUser_AppUserTypePagingRequest request);
    }
    public class AppUser_AppUserTypeService : IAppUser_AppUserTypeService
    {
        private readonly EShopDbContext _context;

        public AppUser_AppUserTypeService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<List<AppUser_AppUserTypeDto>>> GetAll(ManageAppUser_AppUserTypePagingRequest request)
        {
            try
            {
                var query = from ma in _context.AppUser_AppUserTypes
                            select new { ma };

                if (!string.IsNullOrEmpty(request.AppUserId))
                {
                    query = query.Where(m => m.ma.AppUserId == Guid.Parse(request.AppUserId));
                }

                if (request.AppUserTypeId != null)
                {
                    query = query.Where(m => m.ma.AppUserTypeId == request.AppUserTypeId.Value);
                }

                return new ApiSuccessResult<List<AppUser_AppUserTypeDto>>(await query.Select(x => new AppUser_AppUserTypeDto()
                {
                    Id = x.ma.Id,
                    AppUserTypeId = x.ma.AppUserTypeId,
                    AppUserId = x.ma.AppUserId.ToString()
                }).AsNoTracking().ToListAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<List<AppUser_AppUserTypeDto>>(ex.Message);
            }

        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(AppUser_AppUserTypeRequest request)
        {
            try
            {
                bool isNewAppUser_AppUserType = false;

                AppUser_AppUserType appUser_AppUserType = _context.AppUser_AppUserTypes.FirstOrDefault(m => m.AppUserTypeId == request.AppUserTypeId
                                                                                && m.AppUserId == Guid.Parse(request.AppUserId));

                if (appUser_AppUserType == null)
                {
                    isNewAppUser_AppUserType = true;
                    appUser_AppUserType = new AppUser_AppUserType()
                    {
                        CreatedDate = DateTime.Now,
                        CreatedUserId = Guid.Parse(request.CreatedUserId),
                        AppUserId = Guid.Parse(request.AppUserId),
                        AppUserTypeId = request.AppUserTypeId
                    };
                }

                appUser_AppUserType.ModifiedDate = DateTime.Now;
                appUser_AppUserType.ModifiedUserId = Guid.Parse(request.ModifiedUserId);

                if (isNewAppUser_AppUserType == true)
                {
                    _context.AppUser_AppUserTypes.Add(appUser_AppUserType);
                }
                else
                {
                    _context.AppUser_AppUserTypes.Update(appUser_AppUserType);
                }

                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appUser_AppUserType.Id);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
    }
}
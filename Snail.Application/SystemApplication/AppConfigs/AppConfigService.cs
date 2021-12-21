using Snail.Application.Common;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
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
using Snail.ViewModels.System.AppConfigs;

namespace Snail.Application.SystemApplication.AppConfigs
{
    public interface IAppConfigService
    {
        Task<ApiResult<int>> CreateAsync(AppConfigRequest request);

        Task<ApiResult<int>> UpdateAsync(AppConfigRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<AppConfigDto>> GetById(int id);

        Task<PagedResult<AppConfigDto>> GetManageListPaging(ManageAppConfigPagingRequest request);
    }
    public class AppConfigService : IAppConfigService
    {
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public AppConfigService(EShopDbContext context, IFileStorageService storageService,
                                IConfiguration configuration)
        {
            _context = context;
            _storageService = storageService;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(AppConfigRequest request)
        {
            var appConfig = new AppConfig()
            {
                Code = request.Code,
                Name = request.Name,
                CreatedDate = DateTime.Now
            };

            _context.AppConfigs.Add(appConfig);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(appConfig.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(AppConfigRequest request)
        {
            try
            {
                var appConfig = await _context.AppConfigs.FindAsync(request.Id);

                if (appConfig == null) throw new EShopException($"Cannot find a AppConfig with id: {request.Id}");

                appConfig.Code = request.Code;
                appConfig.Name = request.Name;
                appConfig.ModifiedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appConfig.Id);

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

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var appConfigs = await _context.AppConfigs.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (appConfigs == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.AppConfigs.RemoveRange(appConfigs);

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

        public async Task<PagedResult<AppConfigDto>> GetManageListPaging(ManageAppConfigPagingRequest request)
        {
            //1. Select join
            var query = from a in _context.AppConfigs
                        select new { a };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.a.Name.Contains(request.TextSearch)
                || x.a.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.a.Id) :
                            query.OrderByDescending(x => x.a.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.a.Code) :
                            query.OrderByDescending(x => x.a.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.a.Name) :
                            query.OrderByDescending(x => x.a.Name);

                        break;

                    default: break;
                }
            }

            //4. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null && request.PageIndex.Value != 0 && request.PageSize != 0)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
            }


            var data = await query.Select(x => new AppConfigDto()
            {
                Id = x.a.Id,
                Code = x.a.Code,
                Name = x.a.Name
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<AppConfigDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<AppConfigDto>> GetById(int id)
        {
            var appConfig = await _context.AppConfigs.FindAsync(id);

            var appConfigDto = new AppConfigDto()
            {
                Id = appConfig.Id,
                Code = appConfig.Code,
                Name = appConfig.Name
            };
            return new ApiSuccessResult<AppConfigDto>(appConfigDto);
        }
    }
}

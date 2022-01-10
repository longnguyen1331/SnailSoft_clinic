using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SnailApp.ViewModels.Catalog.ServiceTypes;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using SnailApp.Utilities.Constants;
using SnailApp.Application.Common;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SnailApp.Application.Catalog.Services
{
    public interface IServiceTypeService
    {
        Task<ApiResult<int>> CreateAsync(ServiceTypeRequest request);

        Task<ApiResult<int>> UpdateAsync(ServiceTypeRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<ServiceTypeDto>> GetById(ServiceTypeRequest request);

        Task<PagedResult<ServiceTypeDto>> GetManageListPaging(ManageServiceTypePagingRequest request);
    }

    public class ServiceTypeService : IServiceTypeService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;
        private readonly IFileStorageService _storageService;
        public ServiceTypeService(ClinicDbContext context,
            IMapper mapper,
            IConfiguration configuration,
            IFileStorageService storageService
            )
        {
            _mapper = mapper;
            _context = context;
            _configuration = configuration;
            _storageService = storageService;
        }

        public async Task<ApiResult<int>> CreateAsync(ServiceTypeRequest request)
        {
            try
            {
                var serviceType = _mapper.Map<ServiceType>(request);


                if (request.Image != null)
                {
                    serviceType.Image = await this.SaveFile(request.Image);
                }

                serviceType.CreatedDate = DateTime.Now;
                serviceType.ModifiedDate = DateTime.Now;
                _context.ServiceTypes.Add(serviceType);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(serviceType.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(ServiceTypeRequest request)
        {
            try
            {
                var check = await _context.ServiceTypes.Where(x=>x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();
                if (check == null ) throw new EShopException($"Cannot find a serviceType with id: {request.Id}");

                var serviceType = _mapper.Map<ServiceType>(request);

                if (request.Image != null)
                {
                    if (!string.IsNullOrEmpty(check.Image))
                    {
                        await this.DeleteFile(check.Image);
                    }
                    serviceType.Image = await this.SaveFile(request.Image);
                }
                else
                {
                    serviceType.Image = check.Image;
                }

                serviceType.ModifiedDate = DateTime.Now;
                _context.ServiceTypes.Update(serviceType);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(serviceType.Id);

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
                var serviceTypes = await _context.ServiceTypes.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (serviceTypes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                foreach(var item in serviceTypes)
                {
                    if (!string.IsNullOrEmpty(item.Image))
                    {
                        await this.DeleteFile(item.Image);
                    }
                }
               
                _context.ServiceTypes.RemoveRange(serviceTypes);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch(Exception ex)
            {
                return new ApiResult<int>(){
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }
        public async Task<PagedResult<ServiceTypeDto>> GetManageListPaging(ManageServiceTypePagingRequest request)
        {
            try
            {
                //1. Select join

                var query = from st in _context.ServiceTypes
                            where st.ClinicId == request.ClinicId
                            select new { st };


                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.st.Name.Contains(request.TextSearch)
                    || x.st.Code.Contains(request.TextSearch));

                //3.Sort

                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Id) :
                                query.OrderByDescending(x => x.st.Id);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Code) :
                                query.OrderByDescending(x => x.st.Code);

                            break;

                        case "name":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Name) :
                                query.OrderByDescending(x => x.st.Name);

                            break;

                        case "sortOrder":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.SortOrder) :
                                query.OrderByDescending(x => x.st.SortOrder);

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

                var data = await query.Select(x=> new ServiceTypeDto() {
                    Id = x.st.Id,
                    Code = x.st.Code,
                    SortOrder = x.st.SortOrder,
                    IsVisibled = x.st.IsVisibled,
                    Image = _configuration[SystemConstants.AppConstants.BaseAddress] + (!string.IsNullOrEmpty(x.st.Image) ? (_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + x.st.Image) : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                    Name =   x.st.Name,
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<ServiceTypeDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
            }
            catch(Exception ex)
            {
                return  new PagedResult<ServiceTypeDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<ServiceTypeDto>> GetById(ServiceTypeRequest request)
        {
            var serviceType = await _context.ServiceTypes.FindAsync(request.Id);
            var serviceTypeDto = _mapper.Map<ServiceTypeDto>(serviceType);
            return new ApiSuccessResult<ServiceTypeDto>(serviceTypeDto);
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
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFileAsync(_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + fileName);
        }
    }
}
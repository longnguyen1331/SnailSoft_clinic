using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SnailApp.ViewModels.Catalog.Services;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using SnailApp.Utilities.Constants;
using SnailApp.Application.Common;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SnailApp.Application.Catalog.Services
{
    public interface IServiceService
    {
        Task<ApiResult<int>> CreateAsync(ServiceRequest request);
        Task<ApiResult<int>> UpdateAsync(ServiceRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<ServiceDto>> GetById(ServiceRequest request);
        Task<PagedResult<ServiceDto>> GetManageListPaging(ManageServicePagingRequest request);
        Task<PagedResult<ServiceDto>> GetManageListFilterPaging(ManageServicePagingRequest request);
    }

    public class ServiceService : IServiceService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;
        private readonly IFileStorageService _storageService;
        public ServiceService(ClinicDbContext context,
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

        public async Task<ApiResult<int>> CreateAsync(ServiceRequest request)
        {
            try
            {
                var service = _mapper.Map<Service>(request);

                if (request.Image != null)
                {
                    service.Image = await this.SaveFile(request.Image);
                }

                service.CreatedDate = DateTime.Now;
                service.ModifiedDate = DateTime.Now;
                _context.Services.Add(service);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(service.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(ServiceRequest request)
        {
            try
            {
                var check = await _context.Services.Where(x=>x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();
                if (check == null ) throw new EShopException($"Cannot find a service with id: {request.Id}");

                var service = _mapper.Map<Service>(request);

                if (request.Image != null)
                {
                    if (!string.IsNullOrEmpty(check.Image))
                    {
                        await this.DeleteFile(check.Image);
                    }
                    service.Image = await this.SaveFile(request.Image);
                }
                else
                {
                    service.Image =check.Image;
                }

                service.ModifiedDate = DateTime.Now;
                _context.Services.Update(service);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(service.Id);

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
                var services = await _context.Services.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (services == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                foreach (var item in services)
                {
                    if (!string.IsNullOrEmpty(item.Image))
                    {
                        await this.DeleteFile(item.Image);
                    }
                }

                _context.Services.RemoveRange(services);

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
        public async Task<PagedResult<ServiceDto>> GetManageListPaging(ManageServicePagingRequest request)
        {
            try
            {
                //1. Select join

                var query = from st in _context.Services
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

                        case "charges":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Charges) :
                                query.OrderByDescending(x => x.st.Charges);

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

                var data = await query.Select(x=> new ServiceDto() {
                    Id = x.st.Id,
                    Code = x.st.Code,
                    IsVisibled = x.st.IsVisibled,
                    Image = _configuration[SystemConstants.AppConstants.BaseAddress] + (!string.IsNullOrEmpty(x.st.Image) ? (_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + x.st.Image) : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                    Name =  x.st.Name,
                    Charges =  x.st.Charges,
                    Description =  x.st.Description,
                    SortOrder = x.st.SortOrder,
                    ServiceTypeId = x.st.ServiceTypeId
                }).AsNoTracking().ToListAsync();

                foreach (var item in data)
                {
                    item.ServiceTypeName = _context.ServiceTypes.FindAsync(item.ServiceTypeId).Result.Name;
                }

                //5. Select and projection
                var pagedResult = new PagedResult<ServiceDto>()
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
                return  new PagedResult<ServiceDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<ServiceDto>> GetById(ServiceRequest request)
        {
            var service = await _context.Services.FindAsync(request.Id);
            var serviceDto = _mapper.Map<ServiceDto>(service);
            return new ApiSuccessResult<ServiceDto>(serviceDto);
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


        public async Task<PagedResult<ServiceDto>> GetManageListFilterPaging(ManageServicePagingRequest request)
        {
            try
            {
                //1. Select join

                var query = from st in _context.Services
                            where st.ClinicId == request.ClinicId
                            && st.IsVisibled == true
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

                var data = await query.Select(x => new ServiceDto()
                {
                    Id = x.st.Id,
                    Code = x.st.Code,
                    Name = x.st.Name,
                    Charges = x.st.Charges,
                    SortOrder = x.st.SortOrder,
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<ServiceDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
            }
            catch (Exception ex)
            {
                return new PagedResult<ServiceDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }

    }
}
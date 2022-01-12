using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Clinics;
using AutoMapper;
using System.Globalization;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Http;
using SnailApp.Application.Common;
using Microsoft.Extensions.Configuration;

namespace SnailApp.Application.Catalog.Clinics
{
    public interface IClinicService
    {
        Task<ApiResult<int>> CreateAsync(ClinicRequest request);

        Task<ApiResult<int>> UpdateAsync(ClinicRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<ClinicDto>> GetById(ClinicRequest request);

        Task<PagedResult<ClinicDto>> GetManageListPaging(ManageClinicPagingRequest request);
    }

    public class ClinicService : IClinicService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public ClinicService(ClinicDbContext context,
            IFileStorageService storageService,
            IConfiguration configuration,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _storageService = storageService;
            _configuration = configuration;
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(ClinicRequest request)
        {
            try
            {
                var clinic = _mapper.Map<Clinic>(request);


                DateTime datetim1, datetime2;
                if (DateTime.TryParseExact(request.StartDate, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                {
                    clinic.StartDate = datetim1;
                }
                else
                {
                    clinic.StartDate = DateTime.Now;
                }

                if (DateTime.TryParseExact(request.ExpirationDate, "yyyy-MM-dd", null, DateTimeStyles.None, out datetime2))
                {
                    clinic.ExpirationDate = datetime2;
                }
                else
                {
                    clinic.ExpirationDate = DateTime.Now;
                }
                clinic.CreatedDate = DateTime.Now;
                clinic.ModifiedDate = DateTime.Now;


                if (request.Logo != null)
                {
                    clinic.Logo = await this.SaveFile(request.Logo);
                }

                _context.Clinics.Add(clinic);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(clinic.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(ClinicRequest request)
        {
            try
            {
                var check = await _context.Clinics.Where(x=>x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();

                if (check == null ) throw new EShopException($"Cannot find a product with id: {request.Id}");

                var clinic = _mapper.Map<Clinic>(request);

                DateTime datetim1, datetime2;
                if (DateTime.TryParseExact(request.StartDate, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                {
                    clinic.StartDate = datetim1;
                }
                else
                {
                    clinic.StartDate = DateTime.Now;
                }

                if (DateTime.TryParseExact(request.ExpirationDate, "yyyy-MM-dd", null, DateTimeStyles.None, out datetime2))
                {
                    clinic.ExpirationDate = datetime2;
                }
                else
                {
                    clinic.ExpirationDate = DateTime.Now;
                }
                clinic.ModifiedDate = DateTime.Now;

                if (request.Logo != null)
                {
                    if (!string.IsNullOrEmpty(clinic.Logo))
                    {
                        await DeleteFile(clinic.Logo);
                    }

                    clinic.Logo = await this.SaveFile(request.Logo);
                }
                else
                {
                    clinic.Logo = check.Logo;
                }

                _context.Clinics.Update(clinic);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(clinic.Id);

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
                var clinics = await _context.Clinics.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (clinics == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");


                foreach(var item in clinics)
                {
                    if (!string.IsNullOrEmpty(item.Logo))
                    {
                        await this.DeleteFile(item.Logo);
                    }
                }
                _context.Clinics.RemoveRange(clinics);

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
        public async Task<PagedResult<ClinicDto>> GetManageListPaging(ManageClinicPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = _context.Clinics.AsQueryable().AsNoTracking();

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.Name.Contains(request.TextSearch)
                    || x.Code.Contains(request.TextSearch)
                    || x.Phone.Contains(request.TextSearch)
                    || x.Email.Contains(request.TextSearch)
                    || x.Address.Contains(request.TextSearch));

                //3.Sort

                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.Id) :
                                query.OrderByDescending(x => x.Id);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.Code) :
                                query.OrderByDescending(x => x.Code);

                            break;

                        case "name":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.Name) :
                                query.OrderByDescending(x => x.Name);

                            break;

                        case "phone":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.Phone) :
                                query.OrderByDescending(x => x.Phone);

                            break;

                        case "address":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.Address) :
                                query.OrderByDescending(x => x.Address);

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

                var data = await query.Select(x=> new ClinicDto() {
                    Id = x.Id,
                    Logo = (!string.IsNullOrEmpty(x.Logo) ? _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.UserConstants.ImageImagePath] + "/" + x.Logo : _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                    Code = x.Code,
                    Name =   x.Name,
                    Phone = x.Phone,    
                    Email = x.Address,
                    Status = x.Status,
                    Favicon = x.Favicon,
                    PrimaryColor = x.PrimaryColor,
                    SecondaryColor = x.SecondaryColor,
                    Introduction = x.Introduction,
                    Address = x.Address,
                    GoogleScript = x.GoogleScript,
                    FacebookPixel = x.FacebookPixel,
                    FacebookChat = x.FacebookChat,
                    Firebase_apiKey = x.Firebase_apiKey,
                    Firebase_authDomain = x.Firebase_authDomain,
                    Firebase_projectId = x.Firebase_projectId,
                    Firebase_storageBucket = x.Firebase_storageBucket,
                    Firebase_messagingSenderId = x.Firebase_messagingSenderId,
                    Firebase_appId = x.Firebase_appId,
                    Firebase_measurementId = x.Firebase_measurementId,
                    ClinicDomain = x.ClinicDomain,
                    FacebookAppname = x.FacebookAppname,
                    FacebookAppid = x.FacebookAppid,
                    FacebookAppsecret = x.FacebookAppsecret,
                    FacebookLogin = x.FacebookLogin,
                    GoogleLogin = x.GoogleLogin,
                    GoogleAppname = x.GoogleAppname,
                    GoogleApikey = x.GoogleApikey,
                    GoogleClientid = x.GoogleClientid,
                    GoogleClientsecret = x.GoogleClientsecret,
                    StartDate = x.StartDate,
                    ExpirationDate = x.ExpirationDate
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<ClinicDto>()
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
                return  new PagedResult<ClinicDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<ClinicDto>> GetById(ClinicRequest request)
        {
            var clinic = await _context.Clinics.FindAsync(request.Id);
            var clinicDto = _mapper.Map<ClinicDto>(clinic);
            return new ApiSuccessResult<ClinicDto>(clinicDto);
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            try
            {
                await _storageService.SaveFileAsync(file.OpenReadStream(), _configuration[SystemConstants.UserConstants.ImageImagePath] + "/" + fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFileAsync(_configuration[SystemConstants.UserConstants.ImageImagePath] + "/" + fileName);
        }
    }
}
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.ExaminationsResults;
using AutoMapper;
using System.Globalization;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Http;
using SnailApp.Application.Common;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.Catalog.Appointments;

namespace SnailApp.Application.Catalog.ExaminationsResults
{
    public interface IExaminationsResultService
    {
        Task<ApiResult<int>> CreateAsync(ExaminationsResultRequest request);
        Task<ApiResult<int>> UpdateAsync(ExaminationsResultRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<ExaminationsResultDto>> GetById(ExaminationsResultRequest request);
        Task<ApiResult<ExaminationsResultDto>> GetByAppointmentId(ExaminationsResultRequest request);
        Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageExaminationsResulttPagingRequest request);
        Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile);
    }

    public class ExaminationsResultService : IExaminationsResultService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public ExaminationsResultService(ClinicDbContext context,
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

        public async Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile)
        {
            try
            {
                return new ApiSuccessResult<string>(_configuration[SystemConstants.ExaminationConstants.ExaminationImagePath] + "/" + (await this.SaveFile(uploadFile)));
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        public async Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageExaminationsResulttPagingRequest request)
        {
            try
            {
                DateTime fDate, tDate, firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                if (!DateTime.TryParseExact(request.FromDate, "yyyy-MM-dd", null, DateTimeStyles.None, out fDate))
                {
                    fDate = firstDayOfMonth;
                }
                if (!DateTime.TryParseExact(request.ToDate, "yyyy-MM-dd", null, DateTimeStyles.None, out tDate))
                {
                    tDate = firstDayOfMonth.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59);
                }
                Guid doctocIdValue = !string.IsNullOrEmpty(request.DoctorId) ? Guid.Parse(request.DoctorId) : new Guid();

                //1. Select join

                var query = (from a in _context.Appointments
                             join patient in _context.AppUsers on a.PatientId equals patient.Id
                             join doctor in _context.AppUsers on a.DoctorId equals doctor.Id
                             where fDate <= a.Date && a.Date <= tDate
                             && request.ClinicId == a.ClinicId
                             && (request.Status >= 0 ? a.Status == (AppointmentStatus)request.Status : a.Status >= 0)
                                 select new { a, patient, doctor }
                            ).AsNoTracking();

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.a.Name.Contains(request.TextSearch)
                    || (x.patient.FirstName + " " + x.patient.LastName).Contains(request.TextSearch)
                    || (x.doctor.FirstName + " " + x.doctor.LastName).Contains(request.TextSearch)
                    || (x.patient.Code).Contains(request.TextSearch)
                    || (x.patient.Email).Contains(request.TextSearch)
                    || (x.patient.PhoneNumber).Contains(request.TextSearch)
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

                        case "date":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.a.Date) :
                                query.OrderByDescending(x => x.a.Date);

                            break;

                        case "doctorFullName":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.doctor.FirstName + " " + x.doctor.LastName) :
                                query.OrderByDescending(x => x.doctor.FirstName + " " + x.doctor.LastName);

                            break;

                        case "patientFullName":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.patient.FirstName + " " + x.patient.LastName) :
                                query.OrderByDescending(x => x.patient.FirstName + " " + x.patient.LastName);

                            break;

                        case "patientPhone":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.patient.PhoneNumber) :
                                query.OrderByDescending(x => x.patient.PhoneNumber);

                            break;
                        case "patientCode":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.patient.Code) :
                                query.OrderByDescending(x => x.patient.Code);

                            break; 
                        case "patientEmail":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.patient.Email) :
                                query.OrderByDescending(x => x.patient.Email);

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


                var data = await query.Select(x => new AppointmentDto()
                {
                    Id = x.a.Id,
                    DoctorFullName = x.doctor.FirstName + " " + x.doctor.LastName,
                    PatientPhone = x.patient.PhoneNumber,
                    PatientEmail = x.patient.Email,
                    PatientCode = x.patient.Code,
                    PatientDob = x.patient.Dob.HasValue ? x.patient.Dob.Value.ToString("yyyy-MM-dd") : string.Empty,
                    PatientFullName = x.patient.FirstName + " " + x.patient.LastName,
                    Name = x.a.Name,
                    Status = x.a.Status,
                    Date = x.a.Date.ToString("yyyy-MM-dd HH:mm"),
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<AppointmentDto>()
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
                return new PagedResult<AppointmentDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<int>> CreateAsync(ExaminationsResultRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Re_Examination)) request.Re_Examination = null;
                var appointment = _mapper.Map<ExaminationsResult>(request);

                DateTime datetim1, redate;
                if (DateTime.TryParseExact(request.ExaminationDate, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                {
                    appointment.ExaminationDate = datetim1;
                }
                else
                {
                    appointment.ExaminationDate = DateTime.Now;
                }

                if (DateTime.TryParseExact(request.Re_Examination, "yyyy-MM-dd", null, DateTimeStyles.None, out redate))
                {
                    appointment.Re_Examination = redate;
                }
                else
                {
                    appointment.Re_Examination = new Nullable<DateTime>();
                }



                if (request.Examination_File != null)
                {
                    appointment.Examination_File = await this.SaveFile(request.Examination_File);
                }

                appointment.CreatedDate = DateTime.Now;
                appointment.ModifiedDate = DateTime.Now;
                _context.ExaminationsResults.Add(appointment);
                await _context.SaveChangesAsync();

                return new ApiSuccessResult<int>(appointment.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(ExaminationsResultRequest request)
        {
            try
            {
                var check = await _context.ExaminationsResults.Where(x=>x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();

                if (check == null ) throw new EShopException($"Cannot find a appointment with id: {request.Id}");

                if (string.IsNullOrEmpty(request.Re_Examination)) request.Re_Examination = null;
                var appointment = _mapper.Map<ExaminationsResult>(request);

                DateTime datetim1,redate;
                if (DateTime.TryParseExact(request.ExaminationDate, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                {
                    appointment.ExaminationDate = datetim1;
                }
                else
                {
                    appointment.ExaminationDate = DateTime.Now;
                }

                if (DateTime.TryParseExact(request.Re_Examination, "yyyy-MM-dd", null, DateTimeStyles.None, out redate))
                {
                    appointment.Re_Examination = redate;
                }
                else
                {
                    appointment.Re_Examination = new Nullable<DateTime>();
                }

                if (request.Examination_File != null)
                {
                    if (!string.IsNullOrEmpty(appointment.Examination_File))
                    {
                        await DeleteFile(appointment.Examination_File);
                    }

                    appointment.Examination_File = await this.SaveFile(request.Examination_File);
                }
                else
                {
                    appointment.Examination_File = check.Examination_File;
                }

                appointment.ModifiedDate = DateTime.Now;

                _context.ExaminationsResults.Update(appointment);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appointment.Id);

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
                var appointments = await _context.Appointments.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (appointments == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                foreach (var item in appointments)
                {
                    item.Status = AppointmentStatus.Cancel;
                    //if (!string.IsNullOrEmpty(item.Examination_File))
                    //{
                    //    await this.DeleteFile(item.Examination_File);
                    //}
                }

                //_context.ExaminationsResults.RemoveRange(appointments);

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
        public async Task<ApiResult<ExaminationsResultDto>> GetById(ExaminationsResultRequest request)
        {
            var appointment = await (from a in _context.ExaminationsResults
                                     where a.Id == request.Id select new { a  }
                                     ).AsNoTracking().FirstOrDefaultAsync();

            var appointmentDto = _mapper.Map<ExaminationsResultDto>(appointment.a);
            appointmentDto.Examination_File = _configuration[SystemConstants.ExaminationConstants.ExaminationImagePath] + "/" + appointmentDto.Examination_File;
            return new ApiSuccessResult<ExaminationsResultDto>(appointmentDto);
        }
        public async Task<ApiResult<ExaminationsResultDto>> GetByAppointmentId(ExaminationsResultRequest request)
        {
            var appointment = await (from a in _context.ExaminationsResults
                                     where a.AppointmentId == request.AppointmentId
                                     select new { a }
                                     ).AsNoTracking().FirstOrDefaultAsync();
            if(appointment != null && appointment.a != null)
            {
                appointment.a.Examination_File = _configuration[SystemConstants.ExaminationConstants.ExaminationImagePath] + "/" + appointment.a.Examination_File;

                return new ApiSuccessResult<ExaminationsResultDto>(_mapper.Map<ExaminationsResultDto>(appointment.a));

            }
            return new ApiErrorResult<ExaminationsResultDto>() { IsSuccessed = false, Message = "not found", ResultObj = null };
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            try
            {
                await _storageService.SaveFileAsync(file.OpenReadStream(), _configuration[SystemConstants.ExaminationConstants.ExaminationImagePath] + "/" + fileName);
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
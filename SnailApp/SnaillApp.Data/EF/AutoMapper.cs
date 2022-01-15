using SnailApp.Data.Entities;

using AutoMapper;
using SnailApp.ViewModels.System.User_Clinics;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Regions;
using SnailApp.ViewModels.Catalog.ServiceTypes;
using SnailApp.ViewModels.Catalog.Services;
using SnailApp.ViewModels.Catalog.Doctor_Services;
using SnailApp.ViewModels.Catalog.Appointments;
using SnailApp.ViewModels.Catalog.ExaminationsResults;

namespace SnailApp.Data.EF
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
          
            CreateMap<Clinic, ViewModels.Catalog.Clinics.ClinicDto>()
                .ForMember(x => x.StartDate, opt => opt.MapFrom(src => src.StartDate.ToString("yyyy-MM-dd")))
                .ForMember(x => x.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate.ToString("yyyy-MM-dd")))
                .ReverseMap();

            CreateMap<Clinic, ViewModels.Catalog.Clinics.ClinicRequest>()
                .ForMember(x => x.StartDate, opt => opt.MapFrom(src => src.StartDate.ToString("yyyy-MM-dd")))
                .ForMember(x => x.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate.ToString("yyyy-MM-dd")))
                .ReverseMap();

            CreateMap<AppUser_Clinic, User_ClinicDto>().ReverseMap();
            CreateMap<Blood, BaseDto>().ReverseMap();
            CreateMap<Blood, BaseRequest>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<Region, RegionRequest>().ReverseMap();
            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<Service, ServiceRequest>().ReverseMap();
            CreateMap<ServiceType, ServiceTypeDto>().ReverseMap();
            CreateMap<ServiceType, ServiceTypeRequest>().ReverseMap();
            CreateMap<Doctor_Service, Doctor_ServiceRequest>().ReverseMap();
            CreateMap<Doctor_Service, Doctor_ServiceDto>().ReverseMap();

            CreateMap<Appointment, AppointmentDto>()
            .ForMember(x => x.Date, opt => opt.MapFrom(src => src.Date.ToString("yyyy-MM-dd HH:mm")))
            .ReverseMap();

            CreateMap<Appointment, AppointmentRequest>()
                .ForMember(x => x.Date, opt => opt.MapFrom(src => src.Date.ToString("yyyy-MM-dd HH:mm")))
                .ReverseMap();
            CreateMap<Appointment_Service, Appointment_ServiceRequest>()
                .ForMember(x => x.Date, opt => opt.MapFrom(src => src.Date.ToString("yyyy-MM-dd HH:mm")))
                .ReverseMap();

          CreateMap<Appointment_Service, Appointment_ServiceDto>()
          .ForMember(x => x.Date, opt => opt.MapFrom(src => src.Date.ToString("yyyy-MM-dd HH:mm")))
          .ReverseMap();


            CreateMap<AppointmentPayment, AppointmentPaymentRequest>()
              .ForMember(x => x.Date, opt => opt.MapFrom(src => src.Date.ToString("yyyy-MM-dd HH:mm")))
              .ReverseMap();


            CreateMap<AppointmentPayment, AppointmentPaymentDto>()
              .ForMember(x => x.Date, opt => opt.MapFrom(src => src.Date.ToString("yyyy-MM-dd")))
              .ReverseMap();

            CreateMap<ExaminationsResult, ExaminationsResultDto>()
              .ForMember(x => x.ExaminationDate, opt => opt.MapFrom(src => src.ExaminationDate.ToString("yyyy-MM-dd")))
              .ForMember(x => x.Re_Examination, opt => opt.MapFrom(src => src.Re_Examination.HasValue ? src.Re_Examination.Value.ToString("yyyy-MM-dd") : string.Empty))
              .ReverseMap();


            CreateMap<ExaminationsResult, ExaminationsResultRequest>()
              .ForMember(x => x.ExaminationDate, opt => opt.MapFrom(src => src.ExaminationDate.ToString("yyyy-MM-dd")))
              .ForMember(x => x.Re_Examination, opt => opt.MapFrom(src => src.Re_Examination.HasValue ? src.Re_Examination.Value.ToString("yyyy-MM-dd") : string.Empty))
              .ReverseMap();
        }
    }
}

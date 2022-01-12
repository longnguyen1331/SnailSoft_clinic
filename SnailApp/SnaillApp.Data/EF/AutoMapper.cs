using SnailApp.Data.Entities;

using AutoMapper;
using SnailApp.ViewModels.System.User_Clinics;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Regions;
using SnailApp.ViewModels.Catalog.ServiceTypes;
using SnailApp.ViewModels.Catalog.Services;
using SnailApp.ViewModels.Catalog.Doctor_Services;

namespace SnailApp.Data.EF
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
          
            CreateMap<Clinic, ViewModels.Catalog.Clinics.ClinicDto>()
                .ForMember(x => x.StartDate, opt => opt.MapFrom(src => src.StartDate.ToString("dd/MM/yyyy")))
                .ForMember(x => x.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate.ToString("dd/MM/yyyy")))
                .ReverseMap();

            CreateMap<Clinic, ViewModels.Catalog.Clinics.ClinicRequest>()
                .ForMember(x => x.StartDate, opt => opt.MapFrom(src => src.StartDate.ToString("dd/MM/yyyy")))
                .ForMember(x => x.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate.ToString("dd/MM/yyyy")))
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
        }
    }
}

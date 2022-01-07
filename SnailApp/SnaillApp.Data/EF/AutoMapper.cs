using SnailApp.Data.Entities;

using AutoMapper;
using SnailApp.ViewModels.System.User_Clinics;

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

        }
    }
}

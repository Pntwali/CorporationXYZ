using AutoMapper;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Main
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<Notification, NotificationCreateDto>().ReverseMap();
            CreateMap<PricingPlan, PricingPlanDto>().ReverseMap();
            CreateMap<PricingPlanRate, PricingPlanDto>().ReverseMap();
            CreateMap<Quota, QuotaDto>().ReverseMap();
            CreateMap<Notification, SmsNotificationDto>()
            .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message)).ReverseMap();

            CreateMap<Notification, EmailNotificationDto>()
                .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body)).ReverseMap(); 
        }
    }
}

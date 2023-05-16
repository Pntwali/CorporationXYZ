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
        }
    }
}

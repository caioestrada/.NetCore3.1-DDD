using AutoMapper;
using C.Estudo.DDD.Application.ViewModels;
using C.Estudo.DDD.Domain.Entities;

namespace C.Estudo.DDD.Application.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ReturnViewModel, Entity>()
                .ReverseMap();

            CreateMap<UserEntryViewModel, User>()
                .ReverseMap();
            CreateMap<UserReturnViewModel, User>()
                .ReverseMap();
        }
    }
}

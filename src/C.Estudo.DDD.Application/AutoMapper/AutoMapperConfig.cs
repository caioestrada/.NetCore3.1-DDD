using AutoMapper;
using C.Estudo.DDD.Application.ViewModels;
using C.Estudo.DDD.Domain.Entities;

namespace C.Estudo.DDD.Application.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Entity, ViewModel>()
                .ReverseMap();

            CreateMap<UserViewModel, User>()
                .ReverseMap();
        }
    }
}

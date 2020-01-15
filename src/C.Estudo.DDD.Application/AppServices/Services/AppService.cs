using AutoMapper;

namespace C.Estudo.DDD.Application.AppServices.Services
{
    public class AppService
    {
        protected readonly IMapper _mapper;

        public AppService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}

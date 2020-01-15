using AutoMapper;
using C.Estudo.DDD.Application.AppServices.Interfaces;
using C.Estudo.DDD.Application.ViewModels;
using C.Estudo.DDD.Domain.Entities;
using C.Estudo.DDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace C.Estudo.DDD.Application.AppServices.Services
{
    public class UserAppService : AppService, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService, IMapper mapper) : base(mapper)
        {
            _userService = userService;
        }

        public void Delete(UserViewModel user)
        {
            _userService.Delete(_mapper.Map<User>(user));
        }

        public UserViewModel Get(Guid id)
        {
            return _mapper.Map<UserViewModel>(_userService.Get(id));
        }

        public UserViewModel Insert(UserViewModel user)
        {
            var userDomain = _mapper.Map<User>(user);
            var userViewModel = _mapper.Map<UserViewModel>(_userService.Insert(userDomain));
            return userViewModel;
        }

        public IList<UserViewModel> List()
        {
            return _mapper.Map<IList<UserViewModel>>(_userService.List());
        }

        public void Update(UserViewModel user)
        {
            _userService.Update(_mapper.Map<User>(user));
        }
    }
}

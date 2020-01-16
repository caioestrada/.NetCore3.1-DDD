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

        public void Delete(UserEntryViewModel user)
        {
            _userService.Delete(_mapper.Map<User>(user));
        }

        public UserEntryViewModel Get(Guid id)
        {
            return _mapper.Map<UserEntryViewModel>(_userService.Get(id));
        }

        public UserReturnViewModel Insert(UserEntryViewModel userViewModel)
        {
            return _mapper.Map<User, UserReturnViewModel>(_userService.Insert(_mapper.Map<UserEntryViewModel, User>(userViewModel)));
        }

        public IList<UserEntryViewModel> GetAll()
        {
            return _mapper.Map<IList<UserEntryViewModel>>(_userService.List());
        }

        public void Update(UserEntryViewModel user)
        {
            _userService.Update(_mapper.Map<User>(user));
        }
    }
}

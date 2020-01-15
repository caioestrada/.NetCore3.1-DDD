using C.Estudo.DDD.Domain.Entities;
using C.Estudo.DDD.Domain.Interfaces.Repositories;
using C.Estudo.DDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace C.Estudo.DDD.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public User Get(Guid id)
        {
            return _userRepository.Get(id);
        }

        public User Insert(User user)
        {
            if (user.Valid)
                _userRepository.Insert(user);

            return user;
        }

        public IList<User> List()
        {
            return _userRepository.List();
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}

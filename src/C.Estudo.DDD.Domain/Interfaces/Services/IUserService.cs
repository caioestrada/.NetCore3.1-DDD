using C.Estudo.DDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace C.Estudo.DDD.Domain.Interfaces.Services
{
    public interface IUserService
    {
        User Get(Guid id);
        IList<User> List();
        User Insert(User user);
        void Update(User user);
        void Delete(User user);
    }
}

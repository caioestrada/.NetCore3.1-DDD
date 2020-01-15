using C.Estudo.DDD.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace C.Estudo.DDD.Application.AppServices.Interfaces
{
    public interface IUserAppService
    {
        UserViewModel Get(Guid id);
        IList<UserViewModel> List();
        UserViewModel Insert(UserViewModel user);
        void Update(UserViewModel user);
        void Delete(UserViewModel user);
    }
}

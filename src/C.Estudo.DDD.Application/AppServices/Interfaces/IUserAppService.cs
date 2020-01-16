using C.Estudo.DDD.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace C.Estudo.DDD.Application.AppServices.Interfaces
{
    public interface IUserAppService
    {
        UserEntryViewModel Get(Guid id);
        IList<UserEntryViewModel> GetAll();
        UserReturnViewModel Insert(UserEntryViewModel user);
        void Update(UserEntryViewModel user);
        void Delete(UserEntryViewModel user);
    }
}

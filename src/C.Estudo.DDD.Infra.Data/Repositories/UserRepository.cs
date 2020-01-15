using C.Estudo.DDD.Domain.Entities;
using C.Estudo.DDD.Domain.Interfaces.Repositories;
using C.Estudo.DDD.Infra.Data.Context;

namespace C.Estudo.DDD.Infra.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(EstudoContext context) : base(context)
        {
        }
    }
}

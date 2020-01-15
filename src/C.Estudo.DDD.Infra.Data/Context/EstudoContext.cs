using C.Estudo.DDD.Domain.Entities;
using C.Estudo.DDD.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace C.Estudo.DDD.Infra.Data.Context
{
    public partial class EstudoContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public EstudoContext(DbContextOptions<EstudoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterUser();
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using C.Estudo.DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace C.Estudo.DDD.Infra.Data.Mappings
{
    public static class UserMapping
    {
        public static void RegisterUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Ignore(e => e.Notifications);
                entity.Ignore(e => e.Invalid);
                entity.Ignore(e => e.Valid);
            });
        }
    }
}

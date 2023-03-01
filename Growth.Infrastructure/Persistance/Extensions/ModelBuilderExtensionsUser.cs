using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Extensions;

internal static class ModelBuilderExtensionsUser
{
    public static void SeedUser(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "Przemek",
                LastName = "Wróbel"
            },
            new User
            {
                Id = 2,
                FirstName = "Tomek",
                LastName = "Brzoza"
            },
            new User
            {
                Id = 3,
                FirstName = "Rafał",
                LastName = "Wiśniewski"
            });
    }
}

using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Extensions;

internal static class ModelBuilderExtensionsInternetShop
{
    public static void SeedInternetShop(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InternetShop>().HasData(
            new InternetShop
            {
                Id = 1,
                Name = "Clobber",
            },
            new InternetShop
            {
                Id = 2,
                Name = "Asos",
            });
    }
}

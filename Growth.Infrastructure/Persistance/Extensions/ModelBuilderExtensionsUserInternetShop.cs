using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Extensions;

internal static class ModelBuilderExtensionsUserInternetShop
{
    public static void SeedUserInernetShop(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserInternetShop>().HasData(
            new UserInternetShop
            {
                UserId = 1,
                InternetShopId = 1
            },
            new UserInternetShop
            {
                UserId = 2,
                InternetShopId = 1
            },
            new UserInternetShop
            {
                UserId = 2,
                InternetShopId = 2
            },
            new UserInternetShop
            {
                UserId = 3,
                InternetShopId = 1
            },
            new UserInternetShop
            {
                UserId = 3,
                InternetShopId = 2
            });
    }
}

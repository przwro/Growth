using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Extensions;

internal static class ModelBuilderExtensionsCar
{
    public static void SeedCar(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(
            new Car
            {
                Id = 1,
                Model = "Skoda Fabia",
                UserId = 1
            },
            new Car
            {
                Id = 2,
                Model = "Audi A3",
                UserId = 2
            },
            new Car
            {
                Id = 3,
                Model = "Audi A4",
                UserId = 2
            },
            new Car
            {
                Id = 4,
                Model = "Fiat 125p",
                UserId = 3
            },
            new Car
            {
                Id = 5,
                Model = "Fiat 126p",
                UserId = 3
            },
            new Car
            {
                Id = 6,
                Model = "Fiat 500",
                UserId = 3
            });
    }
}

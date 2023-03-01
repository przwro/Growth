using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Extensions;

internal static class ModelBuilderExtensionsAddress
{
    public static void SeedAddress(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>().HasData(
            new Address
            {
                Id = 1,
                Street = "Cisowa 15",
                UserId = 1,
            },
            new Address
            {
                Id = 2,
                Street = "Zielona 12",
                UserId = 2,
            },
            new Address
            {
                Id = 3,
                Street = "Cyprysowa 8",
                UserId = 3,
            });                                                           
    }
}

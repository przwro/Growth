using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Growth.Application.Common.Interfaces;

public interface IApplicationDbContext : IDisposable
{
    DbSet<User> Users { get; set; }
    DbSet<Address> Addresses { get; set; }
    DbSet<Car> Cars { get; set; }
    DbSet<InternetShop> InternetShops { get; set; }
    DbSet<UserInternetShop> UserInternetShop { get; set; }

}

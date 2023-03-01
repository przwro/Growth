using Growth.Application.Common.Interfaces;
using Growth.Domain.Entities;
using Growth.Infrastructure.Persistance.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Growth.Infrastructure.Persistance;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<InternetShop> InternetShops { get; set; }
    public DbSet<UserInternetShop> UserInternetShops { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.SeedUser();
        modelBuilder.SeedAddress();
        modelBuilder.SeedCar();
        modelBuilder.SeedInternetShop();
        modelBuilder.SeedUserInernetShop();

        base.OnModelCreating(modelBuilder);
    }
}
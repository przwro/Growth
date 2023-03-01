using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Configurations;

internal class InternetShopConfiguration : IEntityTypeConfiguration<InternetShop>
{
    public void Configure(EntityTypeBuilder<InternetShop> builder)
    {
        builder.Property(x => x.Name)
            .HasMaxLength(100);
    }
}
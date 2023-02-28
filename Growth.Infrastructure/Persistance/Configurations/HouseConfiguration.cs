using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Configurations;

internal class HouseConfiguration : IEntityTypeConfiguration<House>
{
    public void Configure(EntityTypeBuilder<House> builder)
    {
        builder.Property(x => x.Name)
            .HasMaxLength(100);
    }
}
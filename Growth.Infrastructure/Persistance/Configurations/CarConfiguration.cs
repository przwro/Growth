using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Configurations;

internal class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.Property(x => x.Model)
            .HasMaxLength(100);

        builder.Property(x => x.UserId)
            .IsRequired();
    }
}

using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Growth.Infrastructure.Persistance.Configurations;

internal class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.Property(x => x.Country)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.City)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.Street)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.StreetNumber)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.ZipCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(x => x.UserId)
            .IsRequired();
    }
}

using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Growth.Infrastructure.Persistance.Configurations;

internal class UserInternetShopConfiguration : IEntityTypeConfiguration<UserInternetShop>
{
    public void Configure(EntityTypeBuilder<UserInternetShop> builder)
    {
        builder.HasKey(ui => new { ui.UserId, ui.InternetShopId });
    }
}

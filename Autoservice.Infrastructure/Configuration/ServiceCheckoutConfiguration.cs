using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class ServiceCheckoutConfiguration:IEntityTypeConfiguration<ServiceCheckout>
{
    public void Configure(EntityTypeBuilder<ServiceCheckout> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .HasOne(x => x.Master)
            .WithMany(x => x.ServiceCheckouts)
            .HasForeignKey(x => x.MaserId);
        builder
            .HasOne(x => x.CustomerCar)
            .WithMany(x => x.ServiceCheckouts)
            .HasForeignKey(x => x.CustomerCarId);
        builder
            .HasOne(x => x.ServiceTypeSumm)
            .WithMany(x => x.ServiceCheckout)
            .HasForeignKey(x => x.ServiceTypeSummId);
    }
}
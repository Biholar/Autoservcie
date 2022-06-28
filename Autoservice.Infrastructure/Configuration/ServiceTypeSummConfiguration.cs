using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class ServiceTypeSummConfiguration:IEntityTypeConfiguration<ServiceTypeSumm>
{
    public void Configure(EntityTypeBuilder<ServiceTypeSumm> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .HasOne(x => x.ServiceType)
            .WithMany(x => x.ServiceTypeSumm)
            .HasForeignKey(x => x.ServiceTypeId);
        builder
            .HasOne(x => x.ServiceCheckout)
            .WithMany(x => x.ServiceTypeSumm)
            .HasForeignKey(x=>x.ServiceCheckoutId);
    }
}
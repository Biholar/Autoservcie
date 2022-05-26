using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class ServiceSpareConfiguration:IEntityTypeConfiguration<ServiceSpare>
{
    public void Configure(EntityTypeBuilder<ServiceSpare> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .HasOne(x => x.Spare)
            .WithMany(x => x.SpareParts)
            .HasForeignKey(x => x.SpareId);
        builder
            .HasOne(x => x.ServiceCheckout)
            .WithMany(x => x.ServiceSpares)
            .HasForeignKey(x=>x.ServiceId);

    }

   
}
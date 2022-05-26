using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class ServiceRequestConfiguration:IEntityTypeConfiguration<ServiceRequest>
{
    public void Configure(EntityTypeBuilder<ServiceRequest> builder)
    {
        builder
            .HasKey(x => x.Id);
    }
}
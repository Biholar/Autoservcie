using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class MarkeCarConfiguration
{
    public void Configure(EntityTypeBuilder<MarkeCar> builder)
    {
        builder
            .HasKey(x => x.Id);
    }
}
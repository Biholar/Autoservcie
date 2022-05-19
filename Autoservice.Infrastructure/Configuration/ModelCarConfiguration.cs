using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class ModelCarConfiguration
{
    public void Configure(EntityTypeBuilder<ModelCar> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .HasMany(x=>x.MarkeId)
            .WithOne(x=>x.)
    }
}
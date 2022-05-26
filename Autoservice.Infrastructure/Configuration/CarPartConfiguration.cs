using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class CarPartConfiguration:IEntityTypeConfiguration<CarPart>
{
    public void Configure(EntityTypeBuilder<CarPart> builder)
    {
        builder
            .HasKey(x => x.Id);
        
        builder
            .HasOne(x => x.Car)
            .WithMany(p => p.CarParts)
            .HasForeignKey(x=>x.CarId);
        
        builder
            .HasOne(x => x.Car)
            .WithMany(p => p.CarParts)
            .HasForeignKey(x => x.CarId);

        builder
            .HasOne(x => x.Part)
            .WithMany(x => x.CarParts)
            .HasForeignKey(x=>x.PartId);
    }
}
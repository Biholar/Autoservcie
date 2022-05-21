using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class ModificationCarConfiguration:IEntityTypeConfiguration<ModificationCar>
{
    public void Configure(EntityTypeBuilder<ModificationCar> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .HasOne(x => x.ModelCar)
            .WithMany(x => x.ModificationCars)
            .HasForeignKey(x => x.ModelCarId);

    }
}
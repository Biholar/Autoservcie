using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class ModelCarConfiguration : IEntityTypeConfiguration<ModelCar>

{
    public void Configure(EntityTypeBuilder<ModelCar> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .HasOne(x => x.Marke)
            .WithMany(x => x.ModelCars)
            .HasForeignKey(x => x.MarkeId);

    }
}
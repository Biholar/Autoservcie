using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class CarConfiguration:IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .HasOne(x => x.Modification)
            .WithMany(p=>p.Cars)
            .HasForeignKey(d=>d.ModificationId);
    }
}
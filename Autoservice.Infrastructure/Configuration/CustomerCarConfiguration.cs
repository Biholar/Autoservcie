using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class CustomerCarConfiguration:IEntityTypeConfiguration<CustomerCar>
{
    public void Configure(EntityTypeBuilder<CustomerCar> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .HasOne(x => x.Customer)
            .WithMany(x => x.CustomerCars)
            .HasForeignKey(x => x.CustomerId);
    }
}
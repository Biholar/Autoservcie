using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoservice.Infrastructure.Data;

public class AutoserviceDbContext:DbContext
{
    public AutoserviceDbContext(DbContextOptions<AutoserviceDbContext>options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Car> Cars{ get; set; }
    public DbSet<CarPart> CarParts{ get; set; }
    public DbSet<Customer> Customers{ get; set; }
    public DbSet<CustomerCar>CustomerCars { get; set; }
    public DbSet<MarkeCar>MarkeCars { get; set; }
    public DbSet<Master>Masters { get; set; }
    public DbSet<ModelCar>ModelCars { get; set; }
    public DbSet<ModificationCar>ModificationCars { get; set; }
    public DbSet<ServiceCheckout>ServiceCheckouts { get; set; }
    public DbSet<ServiceSpare>ServiceSpares { get; set; }
    public DbSet<ServiceType> ServiceTypes{ get; set; }
    public DbSet<SparePart>SpareParts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
        modelBuilder.ApplyConfiguration(new );
    }
}
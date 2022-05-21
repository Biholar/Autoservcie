using Autoservice.Infrastructure.Configuration;
using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoservice.Infrastructure.Data;

public class AutoserviceDbContext:DbContext
{
    public AutoserviceDbContext(DbContextOptions<AutoserviceDbContext>options) : base(options)
    {
    }

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
    public DbSet<ServiceTypeSumm> ServiceTypeSummsypes{ get; set; }
    public DbSet<SparePart>SpareParts { get; set; }
    public DbSet<ServiceRequest>ServiceRequests { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustomerCarConfiguration());
        modelBuilder.ApplyConfiguration(new CarPartConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new MarkeCarConfiguration());
        modelBuilder.ApplyConfiguration(new MasterConfiguration());
        modelBuilder.ApplyConfiguration(new ModelCarConfiguration());
        modelBuilder.ApplyConfiguration(new ModificationCarConfiguration());
        modelBuilder.ApplyConfiguration(new ServiceCheckoutConfiguration());
        modelBuilder.ApplyConfiguration(new ServiceRequestConfiguration());
        modelBuilder.ApplyConfiguration(new ServiceSpareConfiguration());
        modelBuilder.ApplyConfiguration(new ServiceTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ServiceTypeSummConfiguration());
        modelBuilder.ApplyConfiguration(new SparePartConfiguration());
    }
}
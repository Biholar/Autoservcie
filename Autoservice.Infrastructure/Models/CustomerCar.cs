namespace Autoservice.Infrastructure.Models;

public class CustomerCar
{
    public int Id { get; set; }
    public string VinCode { get; set; }
    public int CarId { get; set; }
    public int CustomerId { get; set; }
    
    
    public ModificationCar Car { get; set; }
    public Customer Customer { get; set; }
}
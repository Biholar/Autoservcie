namespace Autoservice.Infrastructure.Models;

public class ServiceCheckout
{
    public int Id { get; set; }
    public int CustomerCarId { get; set; }
    public int ServiceTypeId { get; set; }
    public int TotalPrice { get; set; }
    public string ProblemDesc { get; set; }
    public int MaserId { get; set; }

    public Customer Customer { get; set; }
    public ServiceType Service { get; set; }
    public Master Master { get; set; }
    
}
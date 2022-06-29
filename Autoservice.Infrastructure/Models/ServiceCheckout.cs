namespace Autoservice.Infrastructure.Models;

public class ServiceCheckout
{
    public int Id { get; set; }
    public int CustomerCarId { get; set; }
    public int TotalPrice { get; set; }
    public string ProblemDesc { get; set; }
    public int? MaserId { get; set; }
    public DateTime RequestTime { get; set; }
    public int ServiceStatus { get; set; }

    public List<ServiceSpare> ServiceSpares { get; set; }
    public Customer Customer { get; set; }
    public CustomerCar CustomerCar { get; set; }
    public List<ServiceTypeSumm> ServiceTypeSumm { get; set; }
    public Master Master { get; set; }
    
}
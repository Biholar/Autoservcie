namespace Autoservice.Infrastructure.Models;

public class ServiceTypeSumm
{
    public int Id { get; set; }
    public int ServiceTypeId { get; set; }

    public List<ServiceCheckout> ServiceCheckout { get; set; }
    public ServiceType ServiceType { get; set; }
}
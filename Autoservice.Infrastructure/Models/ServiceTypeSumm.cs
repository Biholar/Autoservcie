namespace Autoservice.Infrastructure.Models;

public class ServiceTypeSumm
{
    public int Id { get; set; }
    public int? ServiceTypeId { get; set; }
    public int?  ServiceCheckoutId { get; set; }

    public ServiceCheckout? ServiceCheckout { get; set; }
    public ServiceType? ServiceType { get; set; }
}
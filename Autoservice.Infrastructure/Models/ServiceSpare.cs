using System.Security.AccessControl;

namespace Autoservice.Infrastructure.Models;

public class ServiceSpare
{
    public int Id { get; set; }
    public int SpareId { get; set; }
    public int ServiceId { get; set; }
    public int Quantity { get; set; }

    public SparePart Spare { get; set; }
    public ServiceCheckout Service { get; set; }
}
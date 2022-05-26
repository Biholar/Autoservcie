namespace Autoservice.Infrastructure.Models;

public class ServiceType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

    public List<ServiceTypeSumm> ServiceTypeSumm { get; set; }
}
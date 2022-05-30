using System.Security.AccessControl;

namespace Autoservice.Infrastructure.Models;

public class Master
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Box { get; set; }
    public List<ServiceCheckout> ServiceCheckouts { get; set; }
}
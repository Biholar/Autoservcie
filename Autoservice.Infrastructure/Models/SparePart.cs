using System.Security.AccessControl;

namespace Autoservice.Infrastructure.Models;

public class SparePart
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int IncomePrice { get; set; }
    public int Price { get; set; }
    public List<CarPart> CarParts { get; set; }
}
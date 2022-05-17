using System.Data.Common;

namespace Autoservice.Infrastructure.Models;

public class Car
{
    public int Id { get; set; }
    public int ModificationId { get; set; }
    
    public List<CarPart> CarParts { get; set; }
    public ModificationCar Modification { get; set; }
}
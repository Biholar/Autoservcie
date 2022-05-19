namespace Autoservice.Infrastructure.Models;

public class CarPart
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int PartId { get; set; }

    public ModificationCar Car { get; set; }
    public SparePart Part { get; set; }
}
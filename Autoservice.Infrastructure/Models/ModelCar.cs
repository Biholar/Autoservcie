namespace Autoservice.Infrastructure.Models;

public class ModelCar
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ManufactureYear { get; set; }
    public int MarkeId { get; set; }
    
    public MarkeCar Marke { get; set; }
}
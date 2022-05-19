namespace Autoservice.Infrastructure.Models;

public class MarkeCar
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<ModelCar> ModelCars { get; set; }
}
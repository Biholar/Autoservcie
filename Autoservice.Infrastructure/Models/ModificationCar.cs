namespace Autoservice.Infrastructure.Models;

public class ModificationCar
{
    public int Id { get; set; }
    public int HP { get; set; }
    public string EngineType { get; set; }
    public int ModelCarId { get; set; }
    
    public ModelCar ModelCar { get; set; }
    public List<Car> Cars { get; set; }
}
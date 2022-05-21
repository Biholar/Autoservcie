namespace Autoservice.Infrastructure.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string PhoneNum { get; set; }
    public string Gender { get; set; }

    public List<CustomerCar> CustomerCars { get; set; }
}
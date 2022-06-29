using AutoMapper;
using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class CustomerCarsDto:IMap<Customer>
{
    public string Customer { get; set; }
    public int CustomerId { get; set; }
    public int CarId { get; set; }
    public List<MyClass> Cars { get; set; }


    public void Mapping(Profile profile)
    {
        profile.CreateMap<Customer, CustomerCarsDto>()
            .ForMember(d => d.Customer, m =>
                m.MapFrom(s => $"{s.FirstName} {s.SecondName}"))
            .ForMember(d => d.Cars, m =>
                m.MapFrom(s => s.CustomerCars.Select(x => new MyClass()
                    {
                        carName = $"{x.Car.ModelCar.Marke.Name} {x.Car.ModelCar.Name}",
                        CarId = x.CarId
                    }
                    )))
            .ForMember(d=>d.CustomerId, m=>m.MapFrom(s=>s.Id));
    }
}
public class MyClass
{
    public string carName { get; set; }
    public int CarId { get; set; }
}


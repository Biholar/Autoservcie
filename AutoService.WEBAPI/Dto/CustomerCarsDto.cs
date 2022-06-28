using AutoMapper;
using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class CustomerCarsDto:IMap<Customer>
{
    public string Customer { get; set; }
    public int CustomerId { get; set; }
    public List<string> Cars { get; set; }
    
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Customer, CustomerCarsDto>()
            .ForMember(d => d.Customer, m =>
                m.MapFrom(s => $"{s.FirstName} {s.SecondName}"))
            .ForMember(d => d.Cars, m =>
                m.MapFrom(s => s.CustomerCars.Select(x => $"{x.Car.ModelCar.Marke.Name} {x.Car.ModelCar.Name}")))
            .ForMember(d=>d.CustomerId, m=>m.MapFrom(s=>s.Id));
    }
}


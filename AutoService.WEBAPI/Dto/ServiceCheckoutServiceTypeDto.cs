using AutoMapper;
using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ServiceCheckoutServiceTypeDto:IMap<ServiceCheckout>
{
    public int Id { get; set; }
    public int ServiceCheckoutId { get; set; }
    public int ServiceStatus { get; set; }
    public string Customer { get; set; }
    public string MarkeModel { get; set; }
    public string Master { get; set; }
    public int Box { get; set; }
    public string ServiceType { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<ServiceTypeSumm, ServiceCheckoutServiceTypeDto>()
            .ForMember(d => d.Customer, m =>
                m.MapFrom(s =>
                    $"{s.ServiceCheckout.CustomerCar.Customer.FirstName} {s.ServiceCheckout.CustomerCar.Customer.SecondName}"))
            .ForMember(d => d.Master, m =>
                m.MapFrom(s =>
                    s.ServiceCheckout.Master.Name))
            .ForMember(d => d.Box, m =>
                m.MapFrom(s =>
                    s.ServiceCheckout.Master.Box))
            .ForMember(d => d.MarkeModel, m =>
                m.MapFrom(s =>
                    $"{s.ServiceCheckout.CustomerCar.Car.ModelCar.Name} {s.ServiceCheckout.CustomerCar.Car.ModelCar.Marke.Name}"))
            .ForMember(d => d.ServiceStatus, m =>
                m.MapFrom(s =>
                    s.ServiceCheckout.ServiceStatus))
            .ForMember(d => d.ServiceType, m =>
                m.MapFrom(s =>
                    s.ServiceType.Name));
            
    } 
}
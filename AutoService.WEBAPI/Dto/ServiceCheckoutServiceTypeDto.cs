using AutoMapper;
using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ServiceCheckoutServiceTypeDto:IMap<ServiceCheckout>
{
    public int Id { get; set; }
    public int ServiceCheckoutId { get; set; }
    public int ServiceStatus { get; set; }
    public int CarId { get; set; }
    public string Customer { get; set; }
    public string MarkeModel { get; set; }
    public string Master { get; set; }
    public int Box { get; set; }
    public string ServiceType { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<ServiceCheckout, ServiceCheckoutServiceTypeDto>()
            .ForMember(d => d.Customer, m =>
                m.MapFrom(s =>
                    $"{s.CustomerCar.Customer.FirstName} {s.CustomerCar.Customer.SecondName}"))
            .ForMember(d => d.Master, m =>
                m.MapFrom(s =>
                    s.Master.Name))
            .ForMember(d => d.Box, m =>
                m.MapFrom(s =>
                    s.Master.Box))
            .ForMember(d=>d.CarId,m=>
                m.MapFrom(s=>s.CustomerCarId))
            .ForMember(d => d.MarkeModel, m =>
                m.MapFrom(s =>
                    $"{s.CustomerCar.Car.ModelCar.Marke.Name} {s.CustomerCar.Car.ModelCar.Name}"))
            .ForMember(d => d.ServiceStatus, m =>
                m.MapFrom(s =>
                    s.ServiceStatus))
            .ForMember(d => d.ServiceType, m =>
                m.MapFrom(s =>
                    s.ServiceTypeSumm.FirstOrDefault().ServiceType.Name));
            
    } 
}
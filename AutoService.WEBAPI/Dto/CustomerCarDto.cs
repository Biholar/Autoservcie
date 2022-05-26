using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class CustomerCarDto:IMap<CustomerCar>
{
    public int Id { get; set; }
    public string VinCode { get; set; }
    public int CarId { get; set; }
    public int CustomerId { get; set; }
}
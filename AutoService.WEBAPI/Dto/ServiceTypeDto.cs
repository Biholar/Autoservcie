using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ServiceTypeDto:IMap<ServiceType>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}
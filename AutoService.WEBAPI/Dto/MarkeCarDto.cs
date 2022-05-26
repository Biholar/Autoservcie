using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class MarkeCarDto:IMap<MarkeCar>
{
    public int Id { get; set; }
    public string Name { get; set; }
}
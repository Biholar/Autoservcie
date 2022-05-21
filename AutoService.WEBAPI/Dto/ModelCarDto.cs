using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ModelCarDto:IMap<ModelCar>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ManufactureYear { get; set; }
    public int MarkeId { get; set; }

}
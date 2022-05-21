using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ModificationCarDto:IMap<ModificationCar>
{
    public int Id { get; set; }
    public int HP { get; set; }
    public string EngineType { get; set; }
    public int ModelCarId { get; set; }
}
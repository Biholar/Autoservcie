using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class CarPartDto:IMap<CarPart>
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int PartId { get; set; }
}
using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ServiceSpareDto:IMap<ServiceSpare>
{
    public int Id { get; set; }
    public int SpareId { get; set; }
    public int ServiceId { get; set; }
    public int Quantity { get; set; }

}
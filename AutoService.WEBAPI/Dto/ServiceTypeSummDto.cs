using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ServiceTypeSummDto:IMap<ServiceTypeSumm>
{
    public int Id { get; set; }
    public int ServiceTypeId { get; set; }
    public int  ServiceCheckoutId { get; set; }
}
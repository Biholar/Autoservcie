using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Controllers;

public class ServiceUpdateRequestDto:IMap<ServiceRequest>
{
    public int id { get; set; }
    public int Statement { get; set; }
}
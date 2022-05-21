using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ServiceCheckoutDto:IMap<ServiceCheckout>
{
    public int Id { get; set; }
    public int CustomerCarId { get; set; }
    public int ServiceTypeSummId { get; set; }
    public int TotalPrice { get; set; }
    public string ProblemDesc { get; set; }
    public int MaserId { get; set; }
    public DateTime RequestTime { get; set; }
    public int ServiceStatus { get; set; }
}
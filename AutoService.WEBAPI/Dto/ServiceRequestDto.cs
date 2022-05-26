using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class ServiceRequestDto:IMap<ServiceRequest>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string PhoneNum { get; set; }
    public string Email { get; set; }
    public string ProblemDesc { get; set; }
    public int Statement { get; set; }
}
using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class MasterDto:IMap<Master>
{
    public int Id { get; set; }
    public string Name { get; set; }
}
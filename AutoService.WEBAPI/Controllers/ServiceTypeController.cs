using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceTypeController:ControllerBase
{
    private readonly IServiceTypeService _service;
    private readonly IMapper _mapper;
    public ServiceTypeController(IServiceTypeService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(ServiceTypeDto serviceTypeDto)
    {
        var serviceType = _mapper.Map<ServiceType>(serviceTypeDto);
        await _service.CreateAsync(serviceType);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res = await _service.GetAsync();
        var serviceType = _mapper.Map<List<ServiceTypeDto>>(res);
        return Ok(serviceType);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var serviceType = _mapper.Map<ServiceTypeDto>(res);
        return Ok(serviceType);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ServiceTypeDto serviceTypeDto)
    {
        var serviceType = _mapper.Map<ServiceType>(serviceTypeDto);
        await _service.UpdateAsync(serviceType);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}
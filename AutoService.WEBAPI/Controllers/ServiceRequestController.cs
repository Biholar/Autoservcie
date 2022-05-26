using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServiceRequestController:ControllerBase
{
    private readonly IServiceRequestService _service;
    private readonly IMapper _mapper;

    public ServiceRequestController(IServiceRequestService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    [HttpPost]
    public async Task<IActionResult> Create(ServiceRequestDto serviceRequestDto)
    {
        var serviceRequest = _mapper.Map<ServiceRequest>(serviceRequestDto);
        await _service.CreateAsync(serviceRequest);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res =await _service.GetAsync();
        var serviceRequest = _mapper.Map<List<ServiceRequestDto>>(res);
        return Ok(serviceRequest);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var serviceRequest = _mapper.Map<ServiceRequestDto>(res);
        return Ok(serviceRequest);
    }
    
    [HttpGet("requestState/{id}")]
    public async Task<IActionResult> GetByState(int id)
    {
        var res = await _service.GetByStateAsync(id);
        var serviceRequest = _mapper.Map<List<ServiceRequestDto>>(res);
        return Ok(serviceRequest);
    } 
    
    [HttpGet("requestName/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var res = await _service.GetByNameAsync(name);
        var serviceRequest = _mapper.Map<List<ServiceRequestDto>>(res);
        return Ok(serviceRequest);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ServiceRequestDto serviceRequestDto)
    {
        var serviceRequest = _mapper.Map<ServiceRequest>(serviceRequestDto);
        await _service.UpdateAsync(serviceRequest);
        return Ok();
    }
    
    [HttpPut("state-update")]
    public async Task<IActionResult> UpdateState(ServiceUpdateRequestDto serviceRequestDto)
    {
        var serviceRequest = _mapper.Map<ServiceRequest>(serviceRequestDto);
        await _service.UpdateStateAsync(serviceRequest);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}
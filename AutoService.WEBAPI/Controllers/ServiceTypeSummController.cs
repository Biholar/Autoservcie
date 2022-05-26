using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceTypeSummController:ControllerBase
{
    private readonly IServiceTypeSummService _service;
    private readonly IMapper _mapper;

    public ServiceTypeSummController(IServiceTypeSummService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(ServiceTypeSummDto serviceTypeSummDto)
    {
        var serviceTypeSumm = _mapper.Map<ServiceTypeSumm>(serviceTypeSummDto);
        await _service.CreateAsync(serviceTypeSumm);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res = await _service.GetAsync();
        var serviceTypeSumm = _mapper.Map<List<ServiceTypeSummDto>>(res);
        return Ok(serviceTypeSumm);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var serviceTypeSumm = _mapper.Map<ServiceTypeSummDto>(res);
        return Ok(serviceTypeSumm);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ServiceTypeSummDto serviceTypeSummDto)
    {
        var serviceTypeSumm = _mapper.Map<ServiceTypeSumm>(serviceTypeSummDto);
        await _service.UpdateAsync(serviceTypeSumm);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }

}
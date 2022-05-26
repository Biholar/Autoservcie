using AutoMapper;
using AutoService.Core.Interfaces;
using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceSpareController:ControllerBase
{
    private readonly IServiceSpareService _service;
    private readonly IMapper _mapper;

    public ServiceSpareController(IServiceSpareService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    [HttpPost]
    public async Task<IActionResult> Create(ServiceSpareDto serviceSpareDto)
    {
        var serviceSpare = _mapper.Map<ServiceSpare>(serviceSpareDto);
        await _service.CreateAsync(serviceSpare);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res = await _service.GetAsync();
        var serviceSpare = _mapper.Map<List<ServiceSpareDto>>(res);
        return Ok(serviceSpare);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var serviceSpare = _mapper.Map<ServiceSpareDto>(res);
        return Ok(serviceSpare);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ServiceSpareDto serviceSpareDto)
    {
        var serviceSpare = _mapper.Map<ServiceSpare>(serviceSpareDto);
        await _service.UpdateAsync(serviceSpare);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}
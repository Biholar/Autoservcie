using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SparePartController:ControllerBase
{
    private readonly ISparePartService _service;
    private readonly IMapper _mapper;

    public SparePartController(ISparePartService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(SparePartDto sparePartDto)
    {
        var sparePart  = _mapper.Map<SparePart>(sparePartDto);
        await _service.CreateAsync(sparePart);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res = await _service.GetAsync();
        var sparePart = _mapper.Map<List<SparePartDto>>(res);
        return Ok(sparePart);
    }

    [HttpGet("spare/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var res = await _service.GetByNameAsync(name);
        var serviceRequest = _mapper.Map<List<SparePartDto>>(res);
        return Ok(serviceRequest);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var sparePart = _mapper.Map<SparePartDto>(res);
        return Ok(sparePart);
    }

    [HttpPut]
    public async Task<IActionResult> Update(SparePartDto sparePartDto)
    {
        var res = _mapper.Map<SparePart>(sparePartDto);
        await _service.UpdateAsync(res);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}
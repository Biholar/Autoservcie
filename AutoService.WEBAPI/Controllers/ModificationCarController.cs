using AutoMapper;
using AutoService.Core.Interfaces;
using AutoService.Core.Services;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModificationCarController: ControllerBase
{
    private readonly IModificationCarService _service;
    private readonly IMapper _mapper;
    
    public ModificationCarController(IModificationCarService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(ModificationCarDto modificationCarDto)
    {
        var modificationCar = _mapper.Map<ModificationCar>(modificationCarDto);
        await _service.CreateAsync(modificationCar);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res =await _service.GetAsync();
        var modificationCar = _mapper.Map<List<ModificationCarDto>>(res);
        return Ok(modificationCar);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var modificationCar = _mapper.Map<ModificationCarDto>(res);
        return Ok(modificationCar);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ModificationCarDto modificationCarDto)
    {
        var modificationCar = _mapper.Map<ModificationCar>(modificationCarDto);
        await _service.UpdateAsync(modificationCar);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
    
}
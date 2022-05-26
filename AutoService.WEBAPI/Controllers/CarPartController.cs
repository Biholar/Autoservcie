using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarPartController:ControllerBase
{
    private readonly ICarPartService _service;
    private readonly IMapper _mapper;

    public CarPartController(ICarPartService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CarPartDto carPartDto)
    {
        var carPart = _mapper.Map<CarPart>(carPartDto);
        await _service.CreateAsync(carPart);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res = await _service.GetAsync();
        var carPart = _mapper.Map<List<CarPartDto>>(res);
        return Ok(carPart);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var carPart = _mapper.Map<CarPartDto>(res);
        return Ok(carPart);
    }

    [HttpPut]
    public async Task<IActionResult> Update(CarPartDto carPartDto)
    {
        var carPart = _mapper.Map<CarPart>(carPartDto);
        await _service.UpdateAsync(carPart);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}
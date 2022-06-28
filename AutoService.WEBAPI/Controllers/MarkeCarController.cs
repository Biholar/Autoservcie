using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MarkeCarController:ControllerBase
{
    private readonly IMarkeCarService _service;
    private readonly IMapper _mapper;
    public MarkeCarController(IMarkeCarService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(MarkeCarDto markeCarDto)
    {
        var markeCar = _mapper.Map<MarkeCar>(markeCarDto);
        await _service.CreateAsync(markeCar);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res =await _service.GetAsync();
        var markeCar = _mapper.Map<List<MarkeCarDto>>(res);
        return Ok(markeCar);
    }

    [HttpGet("marke/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var res = await _service.GetByNameAsync(name);
        var markeCar = _mapper.Map<List<MarkeCarDto>>(res);
        return Ok(markeCar);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var markeCar = _mapper.Map<MarkeCarDto>(res);
        return Ok(markeCar);
    }

    [HttpGet("modelbymarke/{id}")]
    public async Task<IActionResult> GetCarModelByMarkeId(int id)
    {
        var res = await _service.GetCarByIdIncludeModelModification(id);
        var markeCar = _mapper.Map<MarkeCar>(res);
        return Ok(markeCar);
    }

    [HttpPut]
    public async Task<IActionResult> Update(MarkeCarDto markeCarDto)
    {
        var markeCar = _mapper.Map<MarkeCar>(markeCarDto);
        await _service.UpdateAsync(markeCar);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}
using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelCarController: ControllerBase
{
    private readonly IModelCarService _service;
    private readonly IMapper _mapper;

    public ModelCarController(IModelCarService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    [HttpPost]
    public async Task<IActionResult> Create(ModelCarDto modelCarDto)
    {
        var modelCar = _mapper.Map<ModelCar>(modelCarDto);
        await _service.CreateAsync(modelCar);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res =await _service.GetAsync();
        var modelCar = _mapper.Map<List<ModelCarDto>>(res);
        return Ok(modelCar);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var modelCar = _mapper.Map<ModelCarDto>(res);
        return Ok(modelCar);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ModelCarDto modelCarDto)
    {
        var modelCar = _mapper.Map<ModelCar>(modelCarDto);
        await _service.UpdateAsync(modelCar);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}
using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MasterController:ControllerBase
{
    private readonly IMasterService _service;
    private readonly IMapper _mapper;
    public MasterController(IMasterService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(MasterDto masterDto)
    {
        var master = _mapper.Map<Master>(masterDto);
        await _service.CreateAsync(master);
        return Ok();
    }

    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res = await _service.GetAsync();
        var master = _mapper.Map<List<MasterDto>>(res);
        return Ok(master);
    }

    [HttpGet("name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var res = await _service.GetByNameAsync(name);
        var master = _mapper.Map<List<MasterDto>>(res);
        return Ok(master);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var master = _mapper.Map<MasterDto>(res);
        return Ok(master);
    }

    [HttpPut]
    public async Task<IActionResult> Update(MasterDto masterDto)
    {
        var master = _mapper.Map<Master>(masterDto);
        await _service.UpdateAsync(master);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
    
}
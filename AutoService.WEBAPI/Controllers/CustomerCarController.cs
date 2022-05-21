using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerCarController:ControllerBase
{
    private readonly ICustomerCarService _service;
    private readonly IMapper _mapper;
    
    public CustomerCarController(ICustomerCarService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    [HttpPost]
    public async Task<IActionResult> Create(CustomerCar customerCarDto)
    {
        var res = _mapper.Map<CustomerCar>(customerCarDto);
        await _service.CreateAsync(res);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res =await _service.GetAsync();
        var customers = _mapper.Map<List<CustomerCar>>(res);
        return Ok(customers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var customer = _mapper.Map<CustomerCar>(res);
        return Ok(customer);
    }

    [HttpPut]
    public async Task<IActionResult> Update(CustomerCar customerCarDto)
    {
        var res = _mapper.Map<CustomerCar>(customerCarDto);
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
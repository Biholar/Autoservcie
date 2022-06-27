using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController :ControllerBase
{
    private readonly ICustomerService _service;
    private readonly IMapper _mapper;

    public CustomerController(ICustomerService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CustomerDto customerDto)
    {
        var customer = _mapper.Map<Customer>(customerDto);
        await _service.CreateAsync(customer);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res =await _service.GetAsync();
        var customers = _mapper.Map<List<CustomerDto>>(res);
        return Ok(customers);
    }
    
 [HttpGet("customer-cars/")]
    public async Task<IActionResult> GetCustomerCars()
    {
        var res =await _service.GetCustomerCars();
        var customers = _mapper.Map<List<CustomerCarsDto>>(res);
        return Ok(customers);
    }

    [HttpGet("name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var res = await _service.GetByNameAsync(name);
        var serviceRequest = _mapper.Map<List<CustomerDto>>(res);
        return Ok(serviceRequest);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var customer = _mapper.Map<CustomerDto>(res);
        return Ok(customer);
    }

    [HttpPut]
    public async Task<IActionResult> Update(CustomerDto customerDto)
    {
        var customer = _mapper.Map<Customer>(customerDto);
        await _service.UpdateAsync(customer);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}

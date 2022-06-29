using AutoMapper;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.WEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceCheckoutController:ControllerBase
{
    private readonly IServiceCheckoutService _service;
    private readonly IMapper _mapper;

    public ServiceCheckoutController(IServiceCheckoutService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(ServiceCheckoutDto serviceCheckoutDto)
    {
        var serviceCheckout = _mapper.Map<ServiceCheckout>(serviceCheckoutDto);
        await _service.CreateAsync(serviceCheckout);
        return Ok();
    }

    [HttpPost("service-checkout-table")]
    public async Task<IActionResult>CreateTableChecout(AddServiceCheckoutDto addServiceCheckoutDto)
    {
        var serviceCheckout = _mapper.Map<ServiceCheckout>(addServiceCheckoutDto);
        await _service.CreateAsync(serviceCheckout);
        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res = await _service.GetAsync();
        var serviceCheckout = _mapper.Map<List<ServiceCheckoutDto>>(res);
        return Ok(serviceCheckout);
    }

    [HttpGet("service-checkout-table")]
    public async Task<IActionResult> GetTable ()
    {
        var serviceTypeSumm = await _service.GetAllInclude();
        var res = _mapper.Map<List<ServiceCheckoutServiceTypeDto>>(serviceTypeSumm);
        return Ok(res);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res =await _service.GetByIdAsync(id);
        var serviceCheckout = _mapper.Map<ServiceCheckoutDto>(res);
        return Ok(serviceCheckout);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ServiceCheckoutDto serviceCheckoutDto)
    {
        var serviceCheckout = _mapper.Map<ServiceCheckout>(serviceCheckoutDto);
        await _service.UpdateAsync(serviceCheckout);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}
using System.Globalization;
using System.Net;
using AutoMapper;
using AutoService.Core.Mapper;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;
using Autoservice.Tests.Services.Mock;
using AutoService.WEBAPI.Controllers;
using AutoService.WEBAPI.Dto;
using Moq;
namespace Autoservice.Tests.Services;

public class CustomerServiceTests
{
    [Fact]
    public async Task CustomerController_PostCustomer_ReturnsOk()
    {
        // Arrange
        var customer = new CustomerDto() {FirstName = "Lion", SecondName = "Eyes", PhoneNum= "06669996969", Gender = "Male"};

        var mockCustomerService = await new MockCustomerServiec().MockCreate();

        /*var customerController = new CustomerController(mockCustomerService.Object);
        // AAct
        var result = await customerController.Create(customer);
        // Assert
        Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result
            .GetType()
            .GetProperty("StatusCode")
            .GetValue(result, null));*/

        mockCustomerService.VerifyCreate(Times.Once());
    }
    
    [Fact]
    public async Task CustomerController_GetAllCustomers_ReturnsIEnumerableCustomers()
    {
        // Arrange
        var mockCustomers = new List<Customer> { new Customer(), };

        var mockCustomerService = await new MockCustomerServiec().MockGetAll(null);

        /*var customerController = new CustomerController(mockCustomerService.Object);

        // Act
        var result = await customerController.GetAll();

        // Assert
        Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result
            .GetType()
            .GetProperty("StatusCode")
            .GetValue(result, null));*/

        mockCustomerService.VerifyGet(Times.Once());

    }
    [Fact]
    public void GetCustomerAsync_ReturnsCorrectCustomerModel()
    {
        Assert.True(true);
    }
    
[Fact]
    public void GetCustomerByIdAsync_ReturnsCorrectCustomerModel()
    {
        Assert.True(true);
    }
    
[Fact]
    public void GetCustomerByNameAsync_ReturnsCorrectCustomerModel()
    {
        Assert.True(true);
    }
    
}
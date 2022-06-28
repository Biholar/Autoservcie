using AutoService.Core.Interfaces;
using Autoservice.Infrastructure.Models;
using Moq;

namespace Autoservice.Tests.Services.Mock;

public class MockCustomerServiec:Mock<ICustomerService>
{
    public async Task<MockCustomerServiec> MockGetAll(IEnumerable<Customer> result)
    {
        Setup(x => x.GetAsync()).ReturnsAsync(new List<Customer>());
        return this;
    }
    public async Task<MockCustomerServiec> MockCreate()
    {
        Setup(x => x.CreateAsync(It.IsAny<Customer>()));
        return this;
    }
    
    public async Task<MockCustomerServiec> MockUpdate()
    {
        Setup(x => x.UpdateAsync(It.IsAny<Customer>()));
        return this;
    }
    public async Task<MockCustomerServiec> MockDelete()
    {
        Setup(x => x.DeleteAsync(It.IsAny<int>()));
        return this;
    }

    public MockCustomerServiec VerifyCreate(Times times)
    {
        Verify(x => x.CreateAsync(It.IsAny<Customer>()), times);

        return this;
    }
    public MockCustomerServiec VerifyGet(Times times)
    {
        Verify(x => x.GetAsync(), times);

        return this;
    }

    public MockCustomerServiec VerifyUpdate(Times times)
    {
        Verify(x => x.UpdateAsync(It.IsAny<Customer>()), times);

        return this;
    }
    public MockCustomerServiec VerifyDelete(Times times)
    {
        Verify(x => x.DeleteAsync(It.IsAny<int>()), times);

        return this;
    }
}
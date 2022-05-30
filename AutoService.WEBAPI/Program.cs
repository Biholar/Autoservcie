using AutoService.Core;
using AutoService.Core.Interfaces;
using AutoService.Core.Services;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Data;
using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var configuration = builder.Configuration;
builder.Services.AddControllers()
    .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCore();
builder.Services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddTransient<ICustomerService, CustomerService>();
builder.Services.AddTransient<IMarkeCarService, MarkeCarService>();
builder.Services.AddTransient<IModelCarService, ModelCarService>();
builder.Services.AddTransient<IServiceRequestService, ServiceRequestService>();
builder.Services.AddTransient<IModificationCarService, ModificationCarService>();
builder.Services.AddTransient<ICustomerCarService, CustomerCarService>();
builder.Services.AddTransient<ICarPartService, CarPartService>();
builder.Services.AddTransient<ISparePartService, SparePartService>();
builder.Services.AddTransient<IServiceSpareService, ServiceSpareService>();
builder.Services.AddTransient<IMasterService, MasterService>();
builder.Services.AddTransient<IServiceTypeService, ServiceTypeService>();
builder.Services.AddTransient<IServiceTypeSummService, ServiceTypeSummService>();
builder.Services.AddTransient<IServiceCheckoutService, ServiceCheckoutService>();


builder.Services.AddDbContext<AutoserviceDbContext>(options => options.UseSqlServer(
    configuration.GetConnectionString("EFConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
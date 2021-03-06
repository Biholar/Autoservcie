
using AutoService.Client.ViewModels;
using Blazored.Modal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ServiceRequestViewModel>();
builder.Services.AddTransient<MarkeCarViewModel>();
builder.Services.AddTransient<MasterViewModel>();
builder.Services.AddTransient<ServiceTypeViewModel>();
builder.Services.AddTransient<SparePartViewModel>();
builder.Services.AddTransient<CustomerViewModel>();
builder.Services.AddTransient<ModelModCarViewModel>();
builder.Services.AddTransient<OrderViewModel>();
builder.Services.AddTransient<ServiceCheckoutServiceTypeServiceSummServiceViewModel>();
builder.Services.AddHttpClient();
builder.Services.AddBlazoredModal(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

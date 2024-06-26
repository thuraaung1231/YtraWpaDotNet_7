using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using YTRAWPADotNet7.Data;
using MudBlazor.Services;
using YTRAWPADotNet7.Interface;
using Refit;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();


builder.Services.AddRefitClient<IAPIRoutes>().ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7019/WebAPI"));

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

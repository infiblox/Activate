using AirlinesData.Interfaces;
using AirlinesData.Repositories; // Ensure the namespace for IAirIndiaRepo is included
using AirlinesService.BuisnessLogicServices; // Ensure the namespace for AirIndiaBuisnessServices is included
using AirlinesService.Helpers;
using AirlinesService.Interfaces; // Ensure the namespace for IAirIndiaBuisnessServices is included
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080); // Listen on port 8080 on all network interfaces
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();

// Fix for CS7036: Register the required dependency for AirIndiaBuisnessServices
builder.Services.AddScoped<IAirIndiaRepo, AirIndiaRepo>();
builder.Services.AddScoped<IAirIndiaBuisnessServices, AirIndiaBuisnessServices>();

builder.Services.AddScoped<IEmiratesRepo, EmiratesRepo>();
builder.Services.AddScoped<IEmiratesBuisnessServices, EmiratesBuisnessServices>();

builder.Services.AddScoped<IBritishAirlinesRepo, BritishAirlinesRepo>();
builder.Services.AddScoped<IBritishAirlinesBuisnessServices, BritishAirlinesBuisnessServices>();

builder.Services.AddScoped<IAmericanAirlinesRepo, AmericanAirlinesRepo>();
builder.Services.AddScoped<IAmericanAirlinesBuisnessServices, AmericanAirlinesBuisnessServices>();
ConfigurationManager configuration = builder.Configuration;
ConfigurationHelper.Initialize(configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;

    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();


using Microsoft.EntityFrameworkCore;
using MockApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<MockContext>(options =>
    options.UseInMemoryDatabase("MockList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwaggerUi(options =>
    {
        options.DocumentPath = "/openapi/v1.json"; 
    });   
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

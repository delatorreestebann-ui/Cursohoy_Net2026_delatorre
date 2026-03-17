using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Libreria.API.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddDbContext<LibreriaAPIContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("LibreriaAPIContext") ?? throw new InvalidOperationException("Connection string 'LibreriaAPIContext' not found.")));

// Add services to the container.



builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

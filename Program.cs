using SkiAPI.Repositories;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen(); // Add this above the line below.

// Add DbContext - Will require an import for UseSqlServer: using Microsoft.EntityFrameworkCore;
builder.Services.AddDbContext<SkiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger(); // Enables middleware to generate the Swagger JSON document
    app.UseSwaggerUI(); // Enables the Swagger UI to visualize and interact with the API
}

app.UseAuthorization();

app.MapControllers();

app.Run();

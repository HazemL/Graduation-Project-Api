using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddScoped<ICraftsmanProfileService, CraftsmanProfileService>();

// Swagger (.NET 9 built-in)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CS"),
        sql => sql.MigrationsAssembly("Sanay3yMasr"))
);

var app = builder.Build();

// Pipeline
if (app.Environment.IsDevelopment())
{
    app.MapSwagger();
    //app.MapSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

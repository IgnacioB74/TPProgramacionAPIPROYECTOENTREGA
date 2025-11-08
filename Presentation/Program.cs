using Application.Interfaces;
using Application.Services;
using AuthApi.Data;
using Domain.Interfaces;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// --- REGISTRO DE SERVICIOS ---
builder.Services.AddScoped<IUserService, Application.Services.UserService>();
builder.Services.AddScoped<IEventService, Application.Services.EventService>();
builder.Services.AddScoped<IProductService, Application.Services.ProductService>();

// --- Otros servicios ---
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

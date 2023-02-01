using APIkarate.IServices;
using APIkarate.Services;
using APIService.IServices;
using APIService.Services;
using Data;
using Logic.ILogic;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<KarateProductsIServices, KarateProductsServices>();
//builder.Services.AddScoped<OrdersIServices, OrdersServices>();
//builder.Services.AddScoped<UsersIServices, UsersServices>();
//builder.Services.AddScoped<BrandsIServices, BrandsServices>();

builder.Services.AddScoped<KarateProductsILogic, KarateProductsLogic>();
//builder.Services.AddScoped<OrdersILogic, OrdersLogic>();
//builder.Services.AddScoped<UsersILogic, UsersLogic>();
//builder.Services.AddScoped<BrandsILogic, BrandsLogic>();

builder.Services.AddDbContext<ServiceContext>(
        options => options.UseSqlServer("name=ConnectionStrings:ServiceContext"));

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
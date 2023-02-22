using Common.Data;
using Common.Data.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Concrete;
using Services.Extensions;
using System.Reflection;
using WebApi_Demo.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDependencies();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DbNortwind")));
builder.Services.AddAutoMapper(typeof(MapProfile));

//builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
//builder.Services.AddHttpClient();
//builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

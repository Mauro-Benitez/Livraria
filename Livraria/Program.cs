using Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




//db
var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

//Read
var stringConection = configuration.GetValue<string>("ConnectionStringsDbRead");
builder.Services.AddDbContext<DbReadContext>(options => options.UseSqlServer(stringConection));


//Edit
var stringConectionEdit = configuration.GetValue<string>("ConnectionStringsDbEdit");
builder.Services.AddDbContext<DbReadContext>(options => options.UseSqlServer(stringConection));





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

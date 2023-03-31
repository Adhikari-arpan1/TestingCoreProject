using EBantan.BAL;
using EBantan.BAL.Interface;
using EBantan.DAL;
using EBantan.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);



//Database Connection
builder.Services.AddDbContext<EBantanDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("EBantanDBConnection"),
    //options => options.CommandTimeout(999)                   
    options => options.EnableRetryOnFailure(10, TimeSpan.FromSeconds(5), null)
), ServiceLifetime.Transient);

//Automapper
builder.Services.AddAutoMapper(typeof(Program));

//Repositories
builder.Services.AddTransient<ITestRepo, TestRepo>();

//Services
builder.Services.AddTransient<ITestServices, TestService>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

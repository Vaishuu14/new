using AutoMapper;
using LibraryManagmentSystem.Application.Handlers.QueryHandler;
using LibraryManagmentSystem.Application.Mappers;
using LibraryManagmentSystem.Application.Services;
using LibraryManagmentSystem.Domain.Interfaces;
using LibraryManagmentSystem.Infrastructure.Data;
using LibraryManagmentSystem.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext with SQL Server
builder.Services.AddDbContext<LibraryDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb")));


builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    // Register additional assemblies if needed
    cfg.RegisterServicesFromAssembly(typeof(GetBooksQueryHandler).Assembly);
});

// Register AutoMapper manually
builder.Services.AddSingleton(provider =>
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile<MappingProfile>();
    });
    return config.CreateMapper();
});

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddScoped<ILoanRepository, LoanRepository>();
builder.Services.AddScoped<IFineRepository, FineRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IFineCalculationService, FineCalculationService>();
builder.Services.AddScoped<IUserService, UserService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyHeader()
.AllowAnyMethod()
.WithOrigins("https://localhost:7273"));

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using TicketSystem.DAL.Data.Context;
using TicketSystem.DAL.Repos.Departments;
using TicketSystem.DAL.Repos.Tickets;
using TicketSystem.Dto.Managers.Departments;
using TicketSystem.Dto.Managers.Tickets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//connection string
var connectionString = builder.Configuration.GetConnectionString("tickets_ConString");
builder.Services.AddDbContext<TicketContext>(options =>
    options.UseSqlServer(connectionString));




builder.Services.AddScoped<ITicketsRepo, TicketsRepo>();
builder.Services.AddScoped<IDepartmentsRepo, DepartmentsRepo>();

builder.Services.AddScoped<ITicketsManager, TicketsManager>();
builder.Services.AddScoped<IDepartmentsManager, DepartmentsManager>();
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

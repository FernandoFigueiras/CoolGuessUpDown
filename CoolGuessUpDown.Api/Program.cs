using CoolGuessUpDown.Api.Extensions;
using CoolGuessUpDown.Infrastructure.Dal.Postgres;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration["PostgreSql:ConnectionString"];
var dbPassword = builder.Configuration["PostgreSql:DbPassword"];
var postGresBuilder = new NpgsqlConnectionStringBuilder(connectionString)
{
    Password = dbPassword
};
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(postGresBuilder.ConnectionString));
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

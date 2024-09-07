using Data.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar Base de datos

string con = "Data Source=DESKTOP-M04GFAI\\sqlexpress;Initial Catalog=Innova;Integrated Security=True;TrustServerCertificate=True";
builder.Services.AddDbContext<MiDbContext>(
    conf => conf.UseSqlServer(
        con, 
        b => b.MigrationsAssembly("Data"))
    ) ;


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
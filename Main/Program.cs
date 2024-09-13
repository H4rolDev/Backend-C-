using Data.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Permitiendo a Angular hacer peticiones
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddControllers();

builder.Services.AddMvc();

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });

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
    app.UseDeveloperExceptionPage();
}
// registrar las excepciones
app.Use(async (context, next) =>
{
    try
    {
        await next.Invoke();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        throw;
    }
});

// app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin"); // angular

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
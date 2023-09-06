using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess;
using TechOil.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//GENERA MIGRACION
builder.Services.AddDbContext<TechOilDbContext>(options =>
{
    options.UseSqlServer("name=DefaultConnection");
});

//GENERA INYECCION DE REPOSITORIO (UNIT OF WORK)
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkService>();

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
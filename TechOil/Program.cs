using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using TechOil.DataAccess;
using TechOil.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    /* Documentacion de swagger:
          c.SwaggerDoc("v1", new OpenApiInfo { Title ="Umsa Softtek", Version = "v1" });
           
           var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
           var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
           c.IncludeXmlComments(xmlPath);
    */
    
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Autorizacion JWT",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference()
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "bearer"
                }
            },
            new string[] { }
        }
    });

});

//GENERA MIGRACION
builder.Services.AddDbContext<TechOilDbContext>(options =>
{
    options.UseSqlServer("name=DefaultConnection");
});

//GENERA INYECCION DE REPOSITORIO (UNIT OF WORK)
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkService>();

//GENERA AUTENTICACION DE TOKEN
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => options.TokenValidationParameters =
        new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])
            ),
        ValidateIssuer = false,
        ValidateAudience = false
    }

);

//Genera autorizacion para funcionalidades especificas para admin
builder.Services.AddAuthorization(option =>
{
    option.AddPolicy("Administrador", policy => policy.RequireClaim(ClaimTypes.Role, "1"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//autenticacion antes de autorizacion
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
using Microsoft.EntityFrameworkCore;
using DiligenciaProveedores.Persistence.Contexts;
using DiligenciaProveedores.Persistence.Repositories;
using DiligenciaProveedores.Domain.Interfaces;
using DiligenciaProveedores.Presentation.Extensions;
using DiligenciaProveedores.Presentation.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// 1. Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Repositories
builder.Services.AddScoped<IProviderRepository, ProviderRepository>();

// 3. Application layer (mediatR, automapper, etc.)
builder.Services.AddApplicationServices(builder.Configuration);

// 4. Authentication
builder.Services.AddJwtAuthentication(builder.Configuration);

// 5. Swagger
builder.Services.AddSwaggerWithJwt();

// 6. Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Middleware global para manejo de errores
app.UseMiddleware<ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Auth
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
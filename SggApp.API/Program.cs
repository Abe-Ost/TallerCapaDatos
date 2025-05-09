using Microsoft.EntityFrameworkCore;
using SggApp.DAL.Repositorios;
using SggApp.BLL.Interfaces;
using SggApp.BLL.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Agregar DbContext con la cadena de conexión desde appsettings.json
builder.Services.AddDbContext<SggAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar los servicios
builder.Services.AddScoped<UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddScoped<CategoriaRepository>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

builder.Services.AddScoped<MonedaRepository>();
builder.Services.AddScoped<IMonedaService, MonedaService>();

builder.Services.AddScoped<PresupuestoRepository>();
builder.Services.AddScoped<IPresupuestoService, PresupuestoService>();

builder.Services.AddScoped<GastoRepository>();

var app = builder.Build();

app.MapControllers();
app.Run();
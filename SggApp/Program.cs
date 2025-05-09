using Microsoft.EntityFrameworkCore;
using SggApp.DAL.Repositorios;
using SggApp.BLL.Interfaces;
using SggApp.BLL.Servicios;


var builder = WebApplication.CreateBuilder(args);

// Agregar DbContext con la cadena de conexión desde appsettings.json
builder.Services.AddDbContext<SggAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Registrar los servicios y repositorios
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

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
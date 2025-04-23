using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Agregar DbContext con la cadena de conexión desde appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source=ABEPC\\SQLEXPRESS;Initial Catalog=DBSistemaGestionGastos;Integrated Security=true;Encrypt=True;TrustServerCertificate=true;")));

var app = builder.Build();

app.MapControllers();
app.Run();
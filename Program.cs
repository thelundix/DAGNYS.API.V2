using dagnys.api.Converters;
using dagnys.api.Data;
using dagnys.api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Knyta samman applikation med vår databas...
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DevConnection"));
});

builder.Services.AddControllers();

builder
    .Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonDateConverter());
    });

builder.Services.AddScoped<IOrderService, OrderService>();

var app = builder.Build();

using var scope = app.Services.CreateScope();

var services = scope.ServiceProvider;
try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
    await Seed.LoadSuppliers(context);
    await Seed.LoadRawMaterials(context);
    await Seed.LoadSupplierRawMaterials(context);

    await Seed.LoadCustomers(context);
    await Seed.LoadProducts(context);
    await Seed.LoadOrders(context);
}
catch (Exception ex)
{
    Console.WriteLine("{0}", ex.Message);
    throw;
}
app.MapControllers();

app.Run();

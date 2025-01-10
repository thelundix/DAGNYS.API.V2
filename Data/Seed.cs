using System.Text.Json;
using dagnys.api.Entities;

namespace dagnys.api.Data;

public static class Seed
{
    public static async Task LoadSuppliers(DataContext context)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        if (context.Suppliers.Any())
            return;

        var json = File.ReadAllText("Data/json/suppliers.json");
        var suppliers = JsonSerializer.Deserialize<List<Supplier>>(json, options);

        if (suppliers is not null && suppliers.Count > 0)
        {
            await context.Suppliers.AddRangeAsync(suppliers);
            await context.SaveChangesAsync();
        }
    }

    public static async Task LoadRawMaterials(DataContext context)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        if (context.RawMaterials.Any())
            return;

        var json = File.ReadAllText("Data/json/rawmaterials.json");
        var rawmaterials = JsonSerializer.Deserialize<List<RawMaterial>>(json, options);

        if (rawmaterials is not null && rawmaterials.Count > 0)
        {
            await context.RawMaterials.AddRangeAsync(rawmaterials);
            await context.SaveChangesAsync();
        }
    }

    public static async Task LoadSupplierRawMaterials(DataContext context)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        if (context.SupplierRawMaterials.Any())
            return;

        var json = File.ReadAllText("Data/json/supplierrawmaterials.json");
        var supplierrawmaterials = JsonSerializer.Deserialize<List<SupplierRawMaterial>>(
            json,
            options
        );

        if (supplierrawmaterials is not null && supplierrawmaterials.Count > 0)
        {
            await context.SupplierRawMaterials.AddRangeAsync(supplierrawmaterials);
            await context.SaveChangesAsync();
        }
    }
}

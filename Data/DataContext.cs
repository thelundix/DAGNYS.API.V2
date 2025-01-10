using dagnys.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace dagnys.api.Data;

public class DataContext : DbContext
{
    public DbSet<Supplier> Suppliers { get; set; }

    public DbSet<RawMaterial> RawMaterials { get; set; }

    public DbSet<SupplierRawMaterial> SupplierRawMaterials { get; set; }

    public DataContext(DbContextOptions options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<SupplierRawMaterial>()
            .HasKey(o => new { o.RawMaterialId, o.SupplierId });
    }
}

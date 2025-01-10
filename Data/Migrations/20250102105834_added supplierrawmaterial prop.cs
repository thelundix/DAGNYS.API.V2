using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dagnys.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedsupplierrawmaterialprop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierRawMaterial",
                columns: table => new
                {
                    SupplierRawMaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false),
                    RawMaterialId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierRawMaterial", x => x.SupplierRawMaterialId);
                    table.ForeignKey(
                        name: "FK_SupplierRawMaterial_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierRawMaterial_SupplierId",
                table: "SupplierRawMaterial",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierRawMaterial");
        }
    }
}

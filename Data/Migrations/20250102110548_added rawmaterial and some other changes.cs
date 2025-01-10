using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dagnys.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedrawmaterialandsomeotherchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierRawMaterialId1",
                table: "SupplierRawMaterials",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    RawMaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerKg = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.RawMaterialId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierRawMaterials_SupplierRawMaterialId1",
                table: "SupplierRawMaterials",
                column: "SupplierRawMaterialId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierRawMaterials_SupplierRawMaterials_SupplierRawMaterialId1",
                table: "SupplierRawMaterials",
                column: "SupplierRawMaterialId1",
                principalTable: "SupplierRawMaterials",
                principalColumn: "SupplierRawMaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierRawMaterials_SupplierRawMaterials_SupplierRawMaterialId1",
                table: "SupplierRawMaterials");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropIndex(
                name: "IX_SupplierRawMaterials_SupplierRawMaterialId1",
                table: "SupplierRawMaterials");

            migrationBuilder.DropColumn(
                name: "SupplierRawMaterialId1",
                table: "SupplierRawMaterials");
        }
    }
}

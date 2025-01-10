using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dagnys.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class supplierrawprop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierRawMaterial_Suppliers_SupplierId",
                table: "SupplierRawMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierRawMaterial",
                table: "SupplierRawMaterial");

            migrationBuilder.RenameTable(
                name: "SupplierRawMaterial",
                newName: "SupplierRawMaterials");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierRawMaterial_SupplierId",
                table: "SupplierRawMaterials",
                newName: "IX_SupplierRawMaterials_SupplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierRawMaterials",
                table: "SupplierRawMaterials",
                column: "SupplierRawMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierRawMaterials_Suppliers_SupplierId",
                table: "SupplierRawMaterials",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierRawMaterials_Suppliers_SupplierId",
                table: "SupplierRawMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierRawMaterials",
                table: "SupplierRawMaterials");

            migrationBuilder.RenameTable(
                name: "SupplierRawMaterials",
                newName: "SupplierRawMaterial");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierRawMaterials_SupplierId",
                table: "SupplierRawMaterial",
                newName: "IX_SupplierRawMaterial_SupplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierRawMaterial",
                table: "SupplierRawMaterial",
                column: "SupplierRawMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierRawMaterial_Suppliers_SupplierId",
                table: "SupplierRawMaterial",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

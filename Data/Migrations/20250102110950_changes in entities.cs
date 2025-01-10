using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dagnys.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class changesinentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierRawMaterials_SupplierRawMaterials_SupplierRawMaterialId1",
                table: "SupplierRawMaterials");

            migrationBuilder.DropIndex(
                name: "IX_SupplierRawMaterials_SupplierRawMaterialId1",
                table: "SupplierRawMaterials");

            migrationBuilder.DropColumn(
                name: "SupplierRawMaterialId1",
                table: "SupplierRawMaterials");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierRawMaterials_RawMaterialId",
                table: "SupplierRawMaterials",
                column: "RawMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierRawMaterials_RawMaterials_RawMaterialId",
                table: "SupplierRawMaterials",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "RawMaterialId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierRawMaterials_RawMaterials_RawMaterialId",
                table: "SupplierRawMaterials");

            migrationBuilder.DropIndex(
                name: "IX_SupplierRawMaterials_RawMaterialId",
                table: "SupplierRawMaterials");

            migrationBuilder.AddColumn<int>(
                name: "SupplierRawMaterialId1",
                table: "SupplierRawMaterials",
                type: "INTEGER",
                nullable: true);

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
    }
}

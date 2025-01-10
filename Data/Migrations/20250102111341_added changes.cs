using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dagnys.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierRawMaterials",
                table: "SupplierRawMaterials"
            );

            migrationBuilder.DropIndex(
                name: "IX_SupplierRawMaterials_RawMaterialId",
                table: "SupplierRawMaterials"
            );

            migrationBuilder
                .AlterColumn<int>(
                    name: "SupplierRawMaterialId",
                    table: "SupplierRawMaterials",
                    type: "INTEGER",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "INTEGER"
                )
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierRawMaterials",
                table: "SupplierRawMaterials",
                columns: new[] { "RawMaterialId", "SupplierId" }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierRawMaterials",
                table: "SupplierRawMaterials"
            );

            migrationBuilder
                .AlterColumn<int>(
                    name: "SupplierRawMaterialId",
                    table: "SupplierRawMaterials",
                    type: "INTEGER",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "INTEGER"
                )
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierRawMaterials",
                table: "SupplierRawMaterials",
                column: "SupplierRawMaterialId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SupplierRawMaterials_RawMaterialId",
                table: "SupplierRawMaterials",
                column: "RawMaterialId"
            );
        }
    }
}

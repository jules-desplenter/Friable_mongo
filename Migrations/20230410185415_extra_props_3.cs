using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class extra_props_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InvetoryNumber",
                table: "Identifications",
                newName: "InventoryNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InventoryNumber",
                table: "Identifications",
                newName: "InvetoryNumber");
        }
    }
}

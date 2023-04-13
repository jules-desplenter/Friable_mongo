using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class materials_fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TechniquesSerialized",
                table: "Identifications",
                newName: "Techniques");

            migrationBuilder.RenameColumn(
                name: "MaterialsSerialized",
                table: "Identifications",
                newName: "Materials");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Techniques",
                table: "Identifications",
                newName: "TechniquesSerialized");

            migrationBuilder.RenameColumn(
                name: "Materials",
                table: "Identifications",
                newName: "MaterialsSerialized");
        }
    }
}

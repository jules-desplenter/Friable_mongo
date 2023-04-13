using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class extra_props : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Identifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shape",
                table: "Identifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Identifications",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Identifications");

            migrationBuilder.DropColumn(
                name: "Shape",
                table: "Identifications");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Identifications");
        }
    }
}

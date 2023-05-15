using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class extraprops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SupportAccessible",
                table: "Supports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupportAccessible",
                table: "SecondarySupport",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictorialAccessible",
                table: "SecondaryPictorial",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictorialAccessible",
                table: "Pictorials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollectionMarkAccessible",
                table: "Identifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Identifications",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupportAccessible",
                table: "Supports");

            migrationBuilder.DropColumn(
                name: "SupportAccessible",
                table: "SecondarySupport");

            migrationBuilder.DropColumn(
                name: "PictorialAccessible",
                table: "SecondaryPictorial");

            migrationBuilder.DropColumn(
                name: "PictorialAccessible",
                table: "Pictorials");

            migrationBuilder.DropColumn(
                name: "CollectionMarkAccessible",
                table: "Identifications");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Identifications");
        }
    }
}

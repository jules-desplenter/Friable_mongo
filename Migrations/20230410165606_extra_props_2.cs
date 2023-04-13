using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class extra_props_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PinholesDescription",
                table: "Supports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PinholesLocation",
                table: "Supports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PinholesDescription",
                table: "SecondarySupport",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PinholesLocation",
                table: "SecondarySupport",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PinholesDescription",
                table: "Supports");

            migrationBuilder.DropColumn(
                name: "PinholesLocation",
                table: "Supports");

            migrationBuilder.DropColumn(
                name: "PinholesDescription",
                table: "SecondarySupport");

            migrationBuilder.DropColumn(
                name: "PinholesLocation",
                table: "SecondarySupport");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class extra_remarks_mounting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Mountings");

            migrationBuilder.AddColumn<string>(
                name: "ConditionRemarks",
                table: "Mountings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionRemarks",
                table: "Mountings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConditionRemarks",
                table: "Mountings");

            migrationBuilder.DropColumn(
                name: "DescriptionRemarks",
                table: "Mountings");

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Mountings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

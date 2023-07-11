using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class papertype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaperType3",
                table: "Supports",
                newName: "PaperType3Serialized");

            migrationBuilder.RenameColumn(
                name: "PaperType3",
                table: "SecondarySupport",
                newName: "PaperType3Serialized");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaperType3Serialized",
                table: "Supports",
                newName: "PaperType3");

            migrationBuilder.RenameColumn(
                name: "PaperType3Serialized",
                table: "SecondarySupport",
                newName: "PaperType3");
        }
    }
}

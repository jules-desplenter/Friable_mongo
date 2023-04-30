using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class newprops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surface",
                table: "Supports",
                newName: "SurfaceSerialized");

            migrationBuilder.RenameColumn(
                name: "Surface",
                table: "SecondarySupport",
                newName: "SurfaceSerialized");

            migrationBuilder.RenameColumn(
                name: "Surface",
                table: "SecondaryPictorial",
                newName: "SurfaceSerialized");

            migrationBuilder.RenameColumn(
                name: "Surface",
                table: "Mountings",
                newName: "SurfaceSerialized");

            migrationBuilder.RenameColumn(
                name: "Nature",
                table: "Mountings",
                newName: "NatureSerialized");

            migrationBuilder.RenameColumn(
                name: "Assemblage",
                table: "Mountings",
                newName: "AssemblageSerialized");

            migrationBuilder.RenameColumn(
                name: "Surface",
                table: "Framing",
                newName: "SurfaceSerialized");

            migrationBuilder.RenameColumn(
                name: "Sealing",
                table: "Framing",
                newName: "SealingSerialized");

            migrationBuilder.RenameColumn(
                name: "InnerSpacers2",
                table: "Framing",
                newName: "InnerSpacers2Serialized");

            migrationBuilder.RenameColumn(
                name: "InnerSpacers1",
                table: "Framing",
                newName: "InnerSpacers1Serialized");

            migrationBuilder.RenameColumn(
                name: "BackingBoard2",
                table: "Framing",
                newName: "DamageRelevant");

            migrationBuilder.RenameColumn(
                name: "BackingBoard1",
                table: "Framing",
                newName: "BackingBoard2Serialized");

            migrationBuilder.AddColumn<string>(
                name: "Attachment",
                table: "Supports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attachment",
                table: "SecondarySupport",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BackingBoard1Serialized",
                table: "Framing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupposedDate",
                table: "Dates",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "Supports");

            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "SecondarySupport");

            migrationBuilder.DropColumn(
                name: "BackingBoard1Serialized",
                table: "Framing");

            migrationBuilder.DropColumn(
                name: "SupposedDate",
                table: "Dates");

            migrationBuilder.RenameColumn(
                name: "SurfaceSerialized",
                table: "Supports",
                newName: "Surface");

            migrationBuilder.RenameColumn(
                name: "SurfaceSerialized",
                table: "SecondarySupport",
                newName: "Surface");

            migrationBuilder.RenameColumn(
                name: "SurfaceSerialized",
                table: "SecondaryPictorial",
                newName: "Surface");

            migrationBuilder.RenameColumn(
                name: "SurfaceSerialized",
                table: "Mountings",
                newName: "Surface");

            migrationBuilder.RenameColumn(
                name: "NatureSerialized",
                table: "Mountings",
                newName: "Nature");

            migrationBuilder.RenameColumn(
                name: "AssemblageSerialized",
                table: "Mountings",
                newName: "Assemblage");

            migrationBuilder.RenameColumn(
                name: "SurfaceSerialized",
                table: "Framing",
                newName: "Surface");

            migrationBuilder.RenameColumn(
                name: "SealingSerialized",
                table: "Framing",
                newName: "Sealing");

            migrationBuilder.RenameColumn(
                name: "InnerSpacers2Serialized",
                table: "Framing",
                newName: "InnerSpacers2");

            migrationBuilder.RenameColumn(
                name: "InnerSpacers1Serialized",
                table: "Framing",
                newName: "InnerSpacers1");

            migrationBuilder.RenameColumn(
                name: "DamageRelevant",
                table: "Framing",
                newName: "BackingBoard2");

            migrationBuilder.RenameColumn(
                name: "BackingBoard2Serialized",
                table: "Framing",
                newName: "BackingBoard1");
        }
    }
}

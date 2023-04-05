using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class all_connections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identifications_Artists_ArtistId",
                table: "Identifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Mountings_MountingId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Storages_StorageId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Supports_PrimarySupportId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Supports_SecondarySupportId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Supports_Pictorials_PictorialId",
                table: "Supports");

            migrationBuilder.DropIndex(
                name: "IX_Supports_PictorialId",
                table: "Supports");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_MountingId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_PrimarySupportId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_SecondarySupportId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_StorageId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Identifications_ArtistId",
                table: "Identifications");

            migrationBuilder.DropColumn(
                name: "PictorialId",
                table: "Supports");

            migrationBuilder.DropColumn(
                name: "MountingId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "PrimarySupportId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "SecondarySupportId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Identifications");

            migrationBuilder.AddColumn<Guid>(
                name: "RegistrationID",
                table: "Supports",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegistrationID",
                table: "Storages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SupportId",
                table: "Pictorials",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegistrationID",
                table: "Mountings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdentificationId",
                table: "Artists",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "SecondarySupport",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaperType1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaperType2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaperType3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assemblage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RectoVerso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Watermark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WatermarkDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WatermarkLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pinholed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarksDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarksCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondarySupport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondarySupport_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryPictorial",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriableMediaSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fixative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherMediaSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechniquesSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarksDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarksCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryPictorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondaryPictorial_SecondarySupport_SupportId",
                        column: x => x.SupportId,
                        principalTable: "SecondarySupport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Supports_RegistrationID",
                table: "Supports",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Storages_RegistrationID",
                table: "Storages",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictorials_SupportId",
                table: "Pictorials",
                column: "SupportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mountings_RegistrationID",
                table: "Mountings",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artists_IdentificationId",
                table: "Artists",
                column: "IdentificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryPictorial_SupportId",
                table: "SecondaryPictorial",
                column: "SupportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SecondarySupport_RegistrationID",
                table: "SecondarySupport",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Identifications_IdentificationId",
                table: "Artists",
                column: "IdentificationId",
                principalTable: "Identifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mountings_Registrations_RegistrationID",
                table: "Mountings",
                column: "RegistrationID",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictorials_Supports_SupportId",
                table: "Pictorials",
                column: "SupportId",
                principalTable: "Supports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Registrations_RegistrationID",
                table: "Storages",
                column: "RegistrationID",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supports_Registrations_RegistrationID",
                table: "Supports",
                column: "RegistrationID",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Identifications_IdentificationId",
                table: "Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_Mountings_Registrations_RegistrationID",
                table: "Mountings");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictorials_Supports_SupportId",
                table: "Pictorials");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Registrations_RegistrationID",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_Supports_Registrations_RegistrationID",
                table: "Supports");

            migrationBuilder.DropTable(
                name: "SecondaryPictorial");

            migrationBuilder.DropTable(
                name: "SecondarySupport");

            migrationBuilder.DropIndex(
                name: "IX_Supports_RegistrationID",
                table: "Supports");

            migrationBuilder.DropIndex(
                name: "IX_Storages_RegistrationID",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Pictorials_SupportId",
                table: "Pictorials");

            migrationBuilder.DropIndex(
                name: "IX_Mountings_RegistrationID",
                table: "Mountings");

            migrationBuilder.DropIndex(
                name: "IX_Artists_IdentificationId",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "RegistrationID",
                table: "Supports");

            migrationBuilder.DropColumn(
                name: "RegistrationID",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "SupportId",
                table: "Pictorials");

            migrationBuilder.DropColumn(
                name: "RegistrationID",
                table: "Mountings");

            migrationBuilder.DropColumn(
                name: "IdentificationId",
                table: "Artists");

            migrationBuilder.AddColumn<Guid>(
                name: "PictorialId",
                table: "Supports",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MountingId",
                table: "Registrations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PrimarySupportId",
                table: "Registrations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SecondarySupportId",
                table: "Registrations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StorageId",
                table: "Registrations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ArtistId",
                table: "Identifications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supports_PictorialId",
                table: "Supports",
                column: "PictorialId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_MountingId",
                table: "Registrations",
                column: "MountingId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_PrimarySupportId",
                table: "Registrations",
                column: "PrimarySupportId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_SecondarySupportId",
                table: "Registrations",
                column: "SecondarySupportId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_StorageId",
                table: "Registrations",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_ArtistId",
                table: "Identifications",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Identifications_Artists_ArtistId",
                table: "Identifications",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Mountings_MountingId",
                table: "Registrations",
                column: "MountingId",
                principalTable: "Mountings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Storages_StorageId",
                table: "Registrations",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Supports_PrimarySupportId",
                table: "Registrations",
                column: "PrimarySupportId",
                principalTable: "Supports",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Supports_SecondarySupportId",
                table: "Registrations",
                column: "SecondarySupportId",
                principalTable: "Supports",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Supports_Pictorials_PictorialId",
                table: "Supports",
                column: "PictorialId",
                principalTable: "Pictorials",
                principalColumn: "Id");
        }
    }
}

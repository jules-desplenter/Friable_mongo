using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mountings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assemblage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mountings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictorials",
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
                    RemarksCondition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictorials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Signatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationNumber = table.Column<int>(type: "int", nullable: true),
                    StorageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supports",
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
                    PictorialId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supports_Pictorials_PictorialId",
                        column: x => x.PictorialId,
                        principalTable: "Pictorials",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Identifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvetoryNumber = table.Column<int>(type: "int", nullable: true),
                    ArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TitleDutch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleFrench = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SignatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaterialsSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechniquesSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Support = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Framed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Top = table.Column<int>(type: "int", nullable: true),
                    Right = table.Column<int>(type: "int", nullable: true),
                    Bottom = table.Column<int>(type: "int", nullable: true),
                    Left = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identifications_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Identifications_Dates_DateId",
                        column: x => x.DateId,
                        principalTable: "Dates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Identifications_Signatures_SignatureId",
                        column: x => x.SignatureId,
                        principalTable: "Signatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CollectionMarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollectionMarks_Identifications_IdentificationId",
                        column: x => x.IdentificationId,
                        principalTable: "Identifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscriptions_Identifications_IdentificationId",
                        column: x => x.IdentificationId,
                        principalTable: "Identifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrimarySupportId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SecondarySupportId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MountingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Identifications_IdentificationId",
                        column: x => x.IdentificationId,
                        principalTable: "Identifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registrations_Mountings_MountingId",
                        column: x => x.MountingId,
                        principalTable: "Mountings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registrations_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registrations_Supports_PrimarySupportId",
                        column: x => x.PrimarySupportId,
                        principalTable: "Supports",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registrations_Supports_SecondarySupportId",
                        column: x => x.SecondarySupportId,
                        principalTable: "Supports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollectionMarks_IdentificationId",
                table: "CollectionMarks",
                column: "IdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_ArtistId",
                table: "Identifications",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_DateId",
                table: "Identifications",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_SignatureId",
                table: "Identifications",
                column: "SignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscriptions_IdentificationId",
                table: "Inscriptions",
                column: "IdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_IdentificationId",
                table: "Registrations",
                column: "IdentificationId");

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
                name: "IX_Supports_PictorialId",
                table: "Supports",
                column: "PictorialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectionMarks");

            migrationBuilder.DropTable(
                name: "Inscriptions");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Identifications");

            migrationBuilder.DropTable(
                name: "Mountings");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Supports");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Dates");

            migrationBuilder.DropTable(
                name: "Signatures");

            migrationBuilder.DropTable(
                name: "Pictorials");
        }
    }
}

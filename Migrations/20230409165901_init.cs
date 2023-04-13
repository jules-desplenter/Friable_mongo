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
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Identifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvetoryNumber = table.Column<int>(type: "int", nullable: true),
                    TitleDutch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleFrench = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialsSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechniquesSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Support = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Framed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Top = table.Column<int>(type: "int", nullable: true),
                    Right = table.Column<int>(type: "int", nullable: true),
                    Bottom = table.Column<int>(type: "int", nullable: true),
                    Left = table.Column<int>(type: "int", nullable: true),
                    RegistrationID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identifications_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    DescriptionRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConditionRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mountings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mountings_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    RegistrationID = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationNumber = table.Column<int>(type: "int", nullable: true),
                    StorageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storages_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    RegistrationID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supports_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Identifications_IdentificationId",
                        column: x => x.IdentificationId,
                        principalTable: "Identifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    IdentificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollectionMarks_Identifications_IdentificationId",
                        column: x => x.IdentificationId,
                        principalTable: "Identifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dates_Identifications_IdentificationId",
                        column: x => x.IdentificationId,
                        principalTable: "Identifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    IdentificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscriptions_Identifications_IdentificationId",
                        column: x => x.IdentificationId,
                        principalTable: "Identifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Signatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signatures_Identifications_IdentificationId",
                        column: x => x.IdentificationId,
                        principalTable: "Identifications",
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
                    RemarksCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictorials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pictorials_Supports_SupportId",
                        column: x => x.SupportId,
                        principalTable: "Supports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_IdentificationId",
                table: "Artists",
                column: "IdentificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CollectionMarks_IdentificationId",
                table: "CollectionMarks",
                column: "IdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_IdentificationId",
                table: "Dates",
                column: "IdentificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_RegistrationID",
                table: "Identifications",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inscriptions_IdentificationId",
                table: "Inscriptions",
                column: "IdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Mountings_RegistrationID",
                table: "Mountings",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictorials_SupportId",
                table: "Pictorials",
                column: "SupportId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_IdentificationId",
                table: "Signatures",
                column: "IdentificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Storages_RegistrationID",
                table: "Storages",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supports_RegistrationID",
                table: "Supports",
                column: "RegistrationID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "CollectionMarks");

            migrationBuilder.DropTable(
                name: "Dates");

            migrationBuilder.DropTable(
                name: "Inscriptions");

            migrationBuilder.DropTable(
                name: "Mountings");

            migrationBuilder.DropTable(
                name: "Pictorials");

            migrationBuilder.DropTable(
                name: "SecondaryPictorial");

            migrationBuilder.DropTable(
                name: "Signatures");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Supports");

            migrationBuilder.DropTable(
                name: "SecondarySupport");

            migrationBuilder.DropTable(
                name: "Identifications");

            migrationBuilder.DropTable(
                name: "Registrations");
        }
    }
}

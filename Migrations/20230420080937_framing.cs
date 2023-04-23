using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class framing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Framing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true),
                    Depth = table.Column<int>(type: "int", nullable: true),
                    Shape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppertureFrameHeight = table.Column<int>(type: "int", nullable: true),
                    ApertureFrameWidth = table.Column<int>(type: "int", nullable: true),
                    ApretureMountHeight = table.Column<int>(type: "int", nullable: true),
                    ApertureMountWidth = table.Column<int>(type: "int", nullable: true),
                    MaxPaintingDimensionsHeight = table.Column<int>(type: "int", nullable: true),
                    MaxPaintingDimensionsWidth = table.Column<int>(type: "int", nullable: true),
                    RabbetAccessible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RabbetHeight = table.Column<int>(type: "int", nullable: true),
                    RabbetWidth = table.Column<int>(type: "int", nullable: true),
                    RabbetDepth = table.Column<int>(type: "int", nullable: true),
                    InnerSpacersHeight = table.Column<int>(type: "int", nullable: true),
                    InnerSpacersWidth = table.Column<int>(type: "int", nullable: true),
                    InnerSpacersDepth = table.Column<int>(type: "int", nullable: true),
                    ExternalRisingSticksHeight = table.Column<int>(type: "int", nullable: true),
                    ExternalRisingSticksWidth = table.Column<int>(type: "int", nullable: true),
                    ExternalRisingSticksDepth = table.Column<int>(type: "int", nullable: true),
                    DimensionRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MouldingMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MouldingAssemblage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaisingSticksMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaisingSticksAssemblage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InnerSpacers1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InnerSpacers2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackingBoard1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackingBoard2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sealing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HangingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Indicators = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assemblage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlazingHeight = table.Column<int>(type: "int", nullable: true),
                    GlazingWidth = table.Column<int>(type: "int", nullable: true),
                    GlazingEstimation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlazingRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalFraming = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoryIndicators = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelsAmount = table.Column<int>(type: "int", nullable: true),
                    HistoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MechanicalProblemsSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChemicalProblemsSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiologicalProblemsSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AestheticProblemsSerialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Framing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Framing_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Framing_RegistrationID",
                table: "Framing",
                column: "RegistrationID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Framing");
        }
    }
}

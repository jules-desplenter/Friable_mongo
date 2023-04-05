using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class more_relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionMarks_Identifications_IdentificationId",
                table: "CollectionMarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Identifications_Dates_DateId",
                table: "Identifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Identifications_Signatures_SignatureId",
                table: "Identifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Identifications_IdentificationId",
                table: "Inscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Identifications_DateId",
                table: "Identifications");

            migrationBuilder.DropIndex(
                name: "IX_Identifications_SignatureId",
                table: "Identifications");

            migrationBuilder.DropColumn(
                name: "DateId",
                table: "Identifications");

            migrationBuilder.DropColumn(
                name: "SignatureId",
                table: "Identifications");

            migrationBuilder.AddColumn<Guid>(
                name: "IdentificationId",
                table: "Signatures",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "IdentificationId",
                table: "Inscriptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdentificationId",
                table: "Dates",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "IdentificationId",
                table: "CollectionMarks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_IdentificationId",
                table: "Signatures",
                column: "IdentificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dates_IdentificationId",
                table: "Dates",
                column: "IdentificationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionMarks_Identifications_IdentificationId",
                table: "CollectionMarks",
                column: "IdentificationId",
                principalTable: "Identifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Identifications_IdentificationId",
                table: "Dates",
                column: "IdentificationId",
                principalTable: "Identifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Identifications_IdentificationId",
                table: "Inscriptions",
                column: "IdentificationId",
                principalTable: "Identifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Signatures_Identifications_IdentificationId",
                table: "Signatures",
                column: "IdentificationId",
                principalTable: "Identifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionMarks_Identifications_IdentificationId",
                table: "CollectionMarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Identifications_IdentificationId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Identifications_IdentificationId",
                table: "Inscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Signatures_Identifications_IdentificationId",
                table: "Signatures");

            migrationBuilder.DropIndex(
                name: "IX_Signatures_IdentificationId",
                table: "Signatures");

            migrationBuilder.DropIndex(
                name: "IX_Dates_IdentificationId",
                table: "Dates");

            migrationBuilder.DropColumn(
                name: "IdentificationId",
                table: "Signatures");

            migrationBuilder.DropColumn(
                name: "IdentificationId",
                table: "Dates");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdentificationId",
                table: "Inscriptions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "DateId",
                table: "Identifications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SignatureId",
                table: "Identifications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdentificationId",
                table: "CollectionMarks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_DateId",
                table: "Identifications",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_SignatureId",
                table: "Identifications",
                column: "SignatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionMarks_Identifications_IdentificationId",
                table: "CollectionMarks",
                column: "IdentificationId",
                principalTable: "Identifications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identifications_Dates_DateId",
                table: "Identifications",
                column: "DateId",
                principalTable: "Dates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identifications_Signatures_SignatureId",
                table: "Identifications",
                column: "SignatureId",
                principalTable: "Signatures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Identifications_IdentificationId",
                table: "Inscriptions",
                column: "IdentificationId",
                principalTable: "Identifications",
                principalColumn: "Id");
        }
    }
}

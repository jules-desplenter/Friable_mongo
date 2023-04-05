using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friable_mongo.Migrations
{
    /// <inheritdoc />
    public partial class cascade_link_identification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Identifications_IdentificationId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_IdentificationId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "IdentificationId",
                table: "Registrations");

            migrationBuilder.AddColumn<Guid>(
                name: "RegistrationID",
                table: "Identifications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_RegistrationID",
                table: "Identifications",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Identifications_Registrations_RegistrationID",
                table: "Identifications",
                column: "RegistrationID",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identifications_Registrations_RegistrationID",
                table: "Identifications");

            migrationBuilder.DropIndex(
                name: "IX_Identifications_RegistrationID",
                table: "Identifications");

            migrationBuilder.DropColumn(
                name: "RegistrationID",
                table: "Identifications");

            migrationBuilder.AddColumn<Guid>(
                name: "IdentificationId",
                table: "Registrations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_IdentificationId",
                table: "Registrations",
                column: "IdentificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Identifications_IdentificationId",
                table: "Registrations",
                column: "IdentificationId",
                principalTable: "Identifications",
                principalColumn: "Id");
        }
    }
}

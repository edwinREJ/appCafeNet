using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appCaféNet.Migrations
{
    /// <inheritdoc />
    public partial class InitProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Profiles",
                newName: "NumeroCelular");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Profiles",
                newName: "Contrasena");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Profiles",
                newName: "NombreCompleto");

            migrationBuilder.RenameColumn(
                name: "DocumentType",
                table: "Profiles",
                newName: "TipoDocumento");

            migrationBuilder.RenameColumn(
                name: "DocumentNumber",
                table: "Profiles",
                newName: "NumeroDocumento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoDocumento",
                table: "Profiles",
                newName: "DocumentType");

            migrationBuilder.RenameColumn(
                name: "NumeroDocumento",
                table: "Profiles",
                newName: "DocumentNumber");

            migrationBuilder.RenameColumn(
                name: "NumeroCelular",
                table: "Profiles",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Profiles",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Contrasena",
                table: "Profiles",
                newName: "Password");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Profiles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

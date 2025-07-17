using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seguroquesi.Migrations
{
    /// <inheritdoc />
    public partial class AddCamposCotizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NumeroDocumento",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Prima",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "NumeroDocumento",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "Prima",
                table: "Cotizaciones");
        }
    }
}

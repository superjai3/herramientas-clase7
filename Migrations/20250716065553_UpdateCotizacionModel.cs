using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seguroquesi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCotizacionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_ProductosSeguros_ProductoSeguroId",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Tomadores_TomadorId",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "FechaUltimoPago",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "FechaVencimiento",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "MontoEstimado",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "MontoPagado",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "MontoPendiente",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "MontoRestante",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "MontoTotal",
                table: "Polizas");

            migrationBuilder.RenameColumn(
                name: "FechaSolicitud",
                table: "Cotizaciones",
                newName: "NumeroCotizacion");

            migrationBuilder.AlterColumn<Guid>(
                name: "TomadorId",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductoSeguroId",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<decimal>(
                name: "MontoEstimado",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Estado",
                table: "Cotizaciones",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoTomador",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NombreTomador",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoDocumentoPersona",
                table: "Cotizaciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_ProductosSeguros_ProductoSeguroId",
                table: "Cotizaciones",
                column: "ProductoSeguroId",
                principalTable: "ProductosSeguros",
                principalColumn: "ProductoSeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Tomadores_TomadorId",
                table: "Cotizaciones",
                column: "TomadorId",
                principalTable: "Tomadores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_ProductosSeguros_ProductoSeguroId",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Tomadores_TomadorId",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "ApellidoTomador",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "NombreTomador",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "TipoDocumentoPersona",
                table: "Cotizaciones");

            migrationBuilder.RenameColumn(
                name: "NumeroCotizacion",
                table: "Cotizaciones",
                newName: "FechaSolicitud");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimoPago",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimiento",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "MontoEstimado",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoPagado",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoPendiente",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoRestante",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoTotal",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<Guid>(
                name: "TomadorId",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductoSeguroId",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MontoEstimado",
                table: "Cotizaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Estado",
                table: "Cotizaciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_ProductosSeguros_ProductoSeguroId",
                table: "Cotizaciones",
                column: "ProductoSeguroId",
                principalTable: "ProductosSeguros",
                principalColumn: "ProductoSeguroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Tomadores_TomadorId",
                table: "Cotizaciones",
                column: "TomadorId",
                principalTable: "Tomadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

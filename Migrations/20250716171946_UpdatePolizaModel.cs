using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seguroquesi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePolizaModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_ProductosSeguros_ProductoSeguroId",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Tomadores_TomadorId",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_ProductoSeguroId",
                table: "Polizas");

            migrationBuilder.RenameColumn(
                name: "ProductoSeguroId",
                table: "Polizas",
                newName: "NumeroDocumento");

            migrationBuilder.RenameColumn(
                name: "Observaciones",
                table: "Polizas",
                newName: "NombreTomador");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Polizas",
                newName: "TipoDocumentoPersona");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Polizas",
                newName: "FechaNacimiento");

            migrationBuilder.AlterColumn<Guid>(
                name: "TomadorId",
                table: "Polizas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoTomador",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Polizas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Tomadores_TomadorId",
                table: "Polizas",
                column: "TomadorId",
                principalTable: "Tomadores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Tomadores_TomadorId",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "ApellidoTomador",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Polizas");

            migrationBuilder.RenameColumn(
                name: "TipoDocumentoPersona",
                table: "Polizas",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "NumeroDocumento",
                table: "Polizas",
                newName: "ProductoSeguroId");

            migrationBuilder.RenameColumn(
                name: "NombreTomador",
                table: "Polizas",
                newName: "Observaciones");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "Polizas",
                newName: "Descripcion");

            migrationBuilder.AlterColumn<Guid>(
                name: "TomadorId",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_ProductoSeguroId",
                table: "Polizas",
                column: "ProductoSeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_ProductosSeguros_ProductoSeguroId",
                table: "Polizas",
                column: "ProductoSeguroId",
                principalTable: "ProductosSeguros",
                principalColumn: "ProductoSeguroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Tomadores_TomadorId",
                table: "Polizas",
                column: "TomadorId",
                principalTable: "Tomadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seguroquesi.Migrations
{
    /// <inheritdoc />
    public partial class AgregaCiudadProvinciaArgentinaEnPoliza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Ciudad",
                table: "Polizas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "EstadoPoliza",
                table: "Polizas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Provincia",
                table: "Polizas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoPoliza",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "Polizas");

            migrationBuilder.AlterColumn<string>(
                name: "Ciudad",
                table: "Polizas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}

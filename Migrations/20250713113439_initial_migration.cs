using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seguroquesi.Migrations
{
    /// <inheritdoc />
    public partial class initial_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aseguradoras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Documento = table.Column<int>(type: "INTEGER", nullable: false),
                    Contacto = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pais = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aseguradoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tomadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrimerNombre = table.Column<string>(type: "TEXT", nullable: false),
                    SegundoNombre = table.Column<string>(type: "TEXT", nullable: false),
                    PrimerApellido = table.Column<string>(type: "TEXT", nullable: false),
                    SegundoApellido = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ciudad = table.Column<int>(type: "INTEGER", nullable: true),
                    CiudadEspana = table.Column<int>(type: "INTEGER", nullable: true),
                    Provincia = table.Column<int>(type: "INTEGER", nullable: true),
                    ProvinciaEspana = table.Column<int>(type: "INTEGER", nullable: true),
                    Pais = table.Column<int>(type: "INTEGER", nullable: false),
                    CodigoPostal = table.Column<int>(type: "INTEGER", nullable: false),
                    Documento = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "TEXT", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Genero = table.Column<int>(type: "INTEGER", nullable: false),
                    Nacionalidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Rol = table.Column<int>(type: "INTEGER", nullable: false),
                    EsEmpresa = table.Column<bool>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    NumeroIdentificacion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tomadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductosSeguros",
                columns: table => new
                {
                    ProductoSeguroId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    PrimaBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RamoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CoberturaCoche = table.Column<string>(type: "TEXT", nullable: false),
                    AseguradoraId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosSeguros", x => x.ProductoSeguroId);
                    table.ForeignKey(
                        name: "FK_ProductosSeguros_Aseguradoras_AseguradoraId",
                        column: x => x.AseguradoraId,
                        principalTable: "Aseguradoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoberturasAdicionales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    CostoAdicional = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductoSeguroId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoberturasAdicionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoberturasAdicionales_ProductosSeguros_ProductoSeguroId",
                        column: x => x.ProductoSeguroId,
                        principalTable: "ProductosSeguros",
                        principalColumn: "ProductoSeguroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoberturasAdicionalesCoche",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TipoCobertura = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoSeguroId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoberturasAdicionalesCoche", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoberturasAdicionalesCoche_ProductosSeguros_ProductoSeguroId",
                        column: x => x.ProductoSeguroId,
                        principalTable: "ProductosSeguros",
                        principalColumn: "ProductoSeguroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TomadorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductoSeguroId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MontoEstimado = table.Column<decimal>(type: "TEXT", nullable: false),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_ProductosSeguros_ProductoSeguroId",
                        column: x => x.ProductoSeguroId,
                        principalTable: "ProductosSeguros",
                        principalColumn: "ProductoSeguroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Tomadores_TomadorId",
                        column: x => x.TomadorId,
                        principalTable: "Tomadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Polizas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    NumeroPoliza = table.Column<string>(type: "TEXT", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TomadorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CotizacionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductoSeguroId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    Moneda = table.Column<int>(type: "INTEGER", nullable: false),
                    Pais = table.Column<int>(type: "INTEGER", nullable: false),
                    MontoTotal = table.Column<decimal>(type: "TEXT", nullable: false),
                    Prima = table.Column<decimal>(type: "TEXT", nullable: false),
                    MontoEstimado = table.Column<decimal>(type: "TEXT", nullable: false),
                    MontoPagado = table.Column<decimal>(type: "TEXT", nullable: false),
                    MontoPendiente = table.Column<decimal>(type: "TEXT", nullable: false),
                    MontoRestante = table.Column<decimal>(type: "TEXT", nullable: false),
                    Cobertura = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaUltimoPago = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polizas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Polizas_Cotizaciones_CotizacionId",
                        column: x => x.CotizacionId,
                        principalTable: "Cotizaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Polizas_ProductosSeguros_ProductoSeguroId",
                        column: x => x.ProductoSeguroId,
                        principalTable: "ProductosSeguros",
                        principalColumn: "ProductoSeguroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Polizas_Tomadores_TomadorId",
                        column: x => x.TomadorId,
                        principalTable: "Tomadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CondicionesPolizas",
                columns: table => new
                {
                    PolizaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Generales = table.Column<string>(type: "TEXT", nullable: false),
                    Particulares = table.Column<string>(type: "TEXT", nullable: false),
                    Especiales = table.Column<string>(type: "TEXT", nullable: false),
                    Exclusiones = table.Column<string>(type: "TEXT", nullable: false),
                    Obligaciones = table.Column<string>(type: "TEXT", nullable: false),
                    Derechos = table.Column<string>(type: "TEXT", nullable: false),
                    Reclamaciones = table.Column<string>(type: "TEXT", nullable: false),
                    Cancelacion = table.Column<string>(type: "TEXT", nullable: false),
                    Renovacion = table.Column<string>(type: "TEXT", nullable: false),
                    Modificacion = table.Column<string>(type: "TEXT", nullable: false),
                    Suspensiones = table.Column<string>(type: "TEXT", nullable: false),
                    Indemnizacion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionesPolizas", x => x.PolizaId);
                    table.ForeignKey(
                        name: "FK_CondicionesPolizas_Polizas_PolizaId",
                        column: x => x.PolizaId,
                        principalTable: "Polizas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siniestros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PolizaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FechaSiniestro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: false),
                    TomadorId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniestros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siniestros_Polizas_PolizaId",
                        column: x => x.PolizaId,
                        principalTable: "Polizas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siniestros_Tomadores_TomadorId",
                        column: x => x.TomadorId,
                        principalTable: "Tomadores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DocumentosAdjuntos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    NombreArchivo = table.Column<string>(type: "TEXT", nullable: false),
                    Contenido = table.Column<byte[]>(type: "BLOB", nullable: false),
                    TipoContenido = table.Column<string>(type: "TEXT", nullable: false),
                    FechaSubida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PolizaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SiniestroId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TomadorId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosAdjuntos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentosAdjuntos_Polizas_PolizaId",
                        column: x => x.PolizaId,
                        principalTable: "Polizas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentosAdjuntos_Siniestros_SiniestroId",
                        column: x => x.SiniestroId,
                        principalTable: "Siniestros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DocumentosAdjuntos_Tomadores_TomadorId",
                        column: x => x.TomadorId,
                        principalTable: "Tomadores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoberturasAdicionales_ProductoSeguroId",
                table: "CoberturasAdicionales",
                column: "ProductoSeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_CoberturasAdicionalesCoche_ProductoSeguroId",
                table: "CoberturasAdicionalesCoche",
                column: "ProductoSeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_ProductoSeguroId",
                table: "Cotizaciones",
                column: "ProductoSeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_TomadorId",
                table: "Cotizaciones",
                column: "TomadorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosAdjuntos_PolizaId",
                table: "DocumentosAdjuntos",
                column: "PolizaId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosAdjuntos_SiniestroId",
                table: "DocumentosAdjuntos",
                column: "SiniestroId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosAdjuntos_TomadorId",
                table: "DocumentosAdjuntos",
                column: "TomadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_CotizacionId",
                table: "Polizas",
                column: "CotizacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_ProductoSeguroId",
                table: "Polizas",
                column: "ProductoSeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_TomadorId",
                table: "Polizas",
                column: "TomadorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosSeguros_AseguradoraId",
                table: "ProductosSeguros",
                column: "AseguradoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Siniestros_PolizaId",
                table: "Siniestros",
                column: "PolizaId");

            migrationBuilder.CreateIndex(
                name: "IX_Siniestros_TomadorId",
                table: "Siniestros",
                column: "TomadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoberturasAdicionales");

            migrationBuilder.DropTable(
                name: "CoberturasAdicionalesCoche");

            migrationBuilder.DropTable(
                name: "CondicionesPolizas");

            migrationBuilder.DropTable(
                name: "DocumentosAdjuntos");

            migrationBuilder.DropTable(
                name: "Nacionalidades");

            migrationBuilder.DropTable(
                name: "Siniestros");

            migrationBuilder.DropTable(
                name: "Polizas");

            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "ProductosSeguros");

            migrationBuilder.DropTable(
                name: "Tomadores");

            migrationBuilder.DropTable(
                name: "Aseguradoras");
        }
    }
}

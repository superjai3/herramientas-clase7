using Microsoft.EntityFrameworkCore;
using Seguroquesi.Models;

namespace Seguroquesi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Tomador> Tomadores { get; set; }
        public DbSet<Aseguradora> Aseguradoras { get; set; }
        public DbSet<ProductoSeguro> ProductosSeguros { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Poliza> Polizas { get; set; }
        public DbSet<Siniestro> Siniestros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DocumentoAdjunto> DocumentosAdjuntos { get; set; }
        public DbSet<CoberturaAdicional> CoberturasAdicionales { get; set; }
        public DbSet<CondicionesPoliza> CondicionesPolizas { get; set; }
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
        public DbSet<CoberturaAdicionalCoche> CoberturasAdicionalesCoche { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relaciones uno a uno => Póliza - CondicionesPoliza
            modelBuilder.Entity<Poliza>()
                .HasOne(p => p.CondicionesPoliza)
                .WithOne(c => c.Poliza)
                .HasForeignKey<CondicionesPoliza>(c => c.PolizaId);

            // Relaciones uno a uno => Póliza - Cotización
            modelBuilder.Entity<Poliza>()
                .HasOne(p => p.Cotizacion)
                .WithOne(c => c.Poliza)
                .HasForeignKey<Poliza>(p => p.CotizacionId);

            // Relaciones uno a muchos => ProductoSeguro - CoberturaAdicionalCoche
            modelBuilder.Entity<ProductoSeguro>()
                .HasMany(p => p.CoberturasAdicionalesCoche)
                .WithOne(c => c.ProductoSeguro)
                .HasForeignKey(c => c.ProductoSeguroId);

            // Relaciones uno a muchos => DocumentoAdjunto - Poliza
            modelBuilder.Entity<DocumentoAdjunto>()
                .HasOne(d => d.Poliza)
                .WithMany(p => p.DocumentosAdjuntos)
                .HasForeignKey(d => d.PolizaId);

            // Relaciones uno a muchos => Siniestro - Poliza
            modelBuilder.Entity<Siniestro>()
                .HasOne(s => s.Poliza)
                .WithMany(p => p.Siniestros)
                .HasForeignKey(s => s.PolizaId);
        }

    }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seguroquesi.Data;
using Seguroquesi.Models;
using Seguroquesi.ViewModels;
using Seguroquesi.Enums;

namespace Seguroquesi.Controllers
{
    public class PolizaController : Controller
    {
        private readonly AppDbContext _context;

        public PolizaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Poliza
        public async Task<IActionResult> Index()
        {
            var polizas = await _context.Polizas.ToListAsync();
            return View(polizas);
        }

        // GET: Poliza/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
                return NotFound();

            var poliza = await _context.Polizas.FindAsync(id);
            if (poliza == null)
                return NotFound();

            return View(poliza);
        }

        // GET: Poliza/Create
        public IActionResult Create()
        {
            var vm = new PolizaViewModel
            {
                NumeroCotizacion = GenerarNumeroCotizacion(),
            };
            return View(vm);
        }

        // POST: Poliza/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PolizaViewModel vm)
        {
            if (ModelState.IsValid)
            {
                // Calcular la prima antes de guardar
                vm.Prima = CalcularPrima(vm.Tipo, vm.Cobertura);

                // Guardar el histórico de cotizaciones
                var cotizacion = new Cotizacion
                {
                    Id = Guid.NewGuid(),
                    NumeroCotizacion = vm.NumeroCotizacion,
                    FechaCreacion = DateTime.Now,
                    NombreTomador = vm.NombreTomador,
                    ApellidoTomador = vm.ApellidoTomador,
                    TipoDocumentoPersona = vm.TipoDocumentoPersona
                };
                _context.Cotizaciones.Add(cotizacion);

                var poliza = new Poliza
                {
                    Id = Guid.NewGuid(),
                    NumeroPoliza = vm.NumeroCotizacion,
                    FechaInicio = vm.FechaInicio,
                    FechaFin = vm.FechaFin,
                    Tipo = vm.Tipo,
                    Moneda = vm.Moneda,
                    Pais = vm.Pais,
                    Prima = vm.Prima,
                    Cobertura = vm.Cobertura,
                    CotizacionId = cotizacion.Id,
                    NumeroDocumento = vm.NumeroDocumento,
                    NombreTomador = vm.NombreTomador,
                    ApellidoTomador = vm.ApellidoTomador,
                    Ciudad = vm.Ciudad,
                    CodigoPostal = vm.CodigoPostal,
                    FechaNacimiento = vm.FechaNacimiento,
                    Genero = vm.Genero
                };

                _context.Polizas.Add(poliza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            vm.NumeroCotizacion = GenerarNumeroCotizacion();
            return View(vm);
        }

        // Método para generar el número de cotización correlativo
        private string GenerarNumeroCotizacion()
        {
            var ultimo = _context.Cotizaciones
                .OrderByDescending(c => c.NumeroCotizacion)
                .Select(c => c.NumeroCotizacion)
                .FirstOrDefault();

            int correlativo = 1;
            if (!string.IsNullOrEmpty(ultimo) && ultimo.StartsWith("COT-"))
            {
                if (int.TryParse(ultimo.Substring(4), out int num))
                    correlativo = num + 1;
            }
            return $"COT-{correlativo:D5}";
        }

        // Método para calcular la prima según ramo y cobertura
        private decimal CalcularPrima(RamoId ramo, CoberturaCoche cobertura)
        {
            // Ejemplo simple, ajusta los valores según tu lógica de negocio
            return (ramo, cobertura) switch
            {
                (RamoId.Auto, CoberturaCoche.TodoRiesgo) => 300m,
                (RamoId.Auto, CoberturaCoche.TercerosCompleto) => 200m,
                (RamoId.Auto, CoberturaCoche.TercerosBasico) => 100m,
                (RamoId.Auto, CoberturaCoche.ResponsabilidadCivil) => 80m,
                (RamoId.Auto, CoberturaCoche.RoboIncendio) => 150m,
                // Puedes agregar más combinaciones para otros ramos y coberturas
                _ => 120m
            };
        }

        // GET: Poliza/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var poliza = await _context.Polizas.FindAsync(id);
            if (poliza == null)
                return NotFound();

            return View(poliza);
        }

        // POST: Poliza/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Poliza poliza)
        {
            if (id != poliza.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poliza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolizaExists(poliza.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(poliza);
        }

        // GET: Poliza/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
                return NotFound();

            var poliza = await _context.Polizas.FindAsync(id);
            if (poliza == null)
                return NotFound();

            return View(poliza);
        }

        // POST: Poliza/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var poliza = await _context.Polizas.FindAsync(id);
            if (poliza != null)
                _context.Polizas.Remove(poliza);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolizaExists(Guid id)
        {
            return _context.Polizas.Any(e => e.Id == id);
        }
    }
}
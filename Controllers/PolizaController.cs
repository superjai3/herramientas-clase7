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
            var polizas = await _context.Polizas.Include(p => p.Cotizacion).ToListAsync();
            return View(polizas);
        }

        // GET: Poliza/Create
        public IActionResult Create()
        {
            var vm = new PolizaViewModel
            {
                NumeroCotizacion = GenerarNumeroCotizacion(),
                FechaInicio = DateTime.Today,
                FechaFin = DateTime.Today.AddYears(1)
            };
            return View(vm);
        }

        // POST: Poliza/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PolizaViewModel vm, string action)
        {
            // Validación de fechas
            if (vm.FechaFin <= vm.FechaInicio)
                ModelState.AddModelError("FechaFin", "La fecha de fin debe ser mayor que la fecha de inicio.");

            // Validación de número de póliza único
            if (_context.Polizas.Any(p => p.NumeroPoliza == vm.NumeroCotizacion))
                ModelState.AddModelError("NumeroPoliza", "Ya existe una póliza con ese número.");

            // Validación de datos del tomador
            if (string.IsNullOrWhiteSpace(vm.NombreTomador) ||
                string.IsNullOrWhiteSpace(vm.ApellidoTomador) ||
                string.IsNullOrWhiteSpace(vm.NumeroDocumento))
            {
                ModelState.AddModelError("", "Todos los datos del tomador son obligatorios.");
            }

            if (!ModelState.IsValid)
            {
                vm.NumeroCotizacion = GenerarNumeroCotizacion();
                return View(vm);
            }

            // Calcular la prima antes de guardar
            vm.Prima = CalcularPrima(vm.Tipo, vm.Cobertura);

            // Guardar cotización o emitir póliza según la acción
            if (action == "Guardar")
            {
                // Guardar como cotización (no se emite póliza)
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
                await _context.SaveChangesAsync();
                TempData["Mensaje"] = "Cotización guardada correctamente.";
                return RedirectToAction(nameof(Index));
            }
            else if (action == "Emitir")
            {
                // Guardar cliente si no existe
                var cliente = await _context.Clientes.FirstOrDefaultAsync(c =>
                    c.NumeroIdentificacion == vm.NumeroDocumento);
                if (cliente == null)
                {
                    cliente = new Cliente
                    {
                        NumeroIdentificacion = vm.NumeroDocumento,
                        PrimerNombre = vm.NombreTomador,
                        SegundoNombre = "",
                        PrimerApellido = vm.ApellidoTomador,
                        SegundoApellido = "",
                        FechaNacimiento = vm.FechaNacimiento,
                        Genero = vm.Genero,
                        Ciudad = vm.Ciudad,
                        Provincia = vm.Provincia,
                        Pais = vm.Pais,
                        Email = "",
                        Telefono = "",
                        Direccion = "",
                        CodigoPostal = int.TryParse(vm.CodigoPostal, out var cp) ? cp : 0,
                        Documento = vm.TipoDocumentoPersona,
                        NumeroDocumento = vm.NumeroDocumento,
                    }; _context.Clientes.Add(cliente);
                    await _context.SaveChangesAsync();
                }

                // Guardar cotización
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
                await _context.SaveChangesAsync();

                // Emitir póliza
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
                    Provincia = vm.Provincia,
                    CodigoPostal = vm.CodigoPostal,
                    FechaNacimiento = vm.FechaNacimiento,
                    Genero = vm.Genero,
                    EstadoPoliza = EstadoPoliza.Emitida
                };
                _context.Polizas.Add(poliza);
                await _context.SaveChangesAsync();
                TempData["Mensaje"] = "Póliza emitida correctamente.";
                return RedirectToAction(nameof(Index));
            }

            // Si no se seleccionó acción válida
            ModelState.AddModelError("", "Acción no válida.");
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
            // Aquí puedes implementar lógica avanzada según el ramo
            return (ramo, cobertura) switch
            {
                (RamoId.Auto, CoberturaCoche.TodoRiesgo) => 300m,
                (RamoId.Auto, CoberturaCoche.TercerosCompleto) => 200m,
                (RamoId.Auto, CoberturaCoche.TercerosBasico) => 100m,
                (RamoId.Auto, CoberturaCoche.ResponsabilidadCivil) => 80m,
                (RamoId.Auto, CoberturaCoche.RoboIncendio) => 150m,
                // Otros ramos y coberturas...
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
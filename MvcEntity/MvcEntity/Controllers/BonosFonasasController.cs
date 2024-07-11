using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcEntity.Models;

namespace MvcEntity.Controllers
{
    public class BonosFonasasController : Controller
    {
        private readonly Context _context;

        public BonosFonasasController(Context context)
        {
            _context = context;
        }

        // GET: BonosFonasas
        public async Task<IActionResult> Index()
        {
            return View(await _context.BonosFonasas.ToListAsync());
        }

        // GET: BonosFonasas/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bonosFonasa = await _context.BonosFonasas
                .FirstOrDefaultAsync(m => m.IdBonoFonasa == id);
            if (bonosFonasa == null)
            {
                return NotFound();
            }

            return View(bonosFonasa);
        }

        // GET: BonosFonasas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BonosFonasas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBonoFonasa,RutBeneficiario,NombreBeneficiario,RutTitular,NombreTitular,RutPrestador,NombrePrestador,PrestacionMedica,ValorTotal,Nivel,Folio,FechaHoraIngreso,PagaVisita")] BonosFonasa bonosFonasa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bonosFonasa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bonosFonasa);
        }

        // GET: BonosFonasas/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bonosFonasa = await _context.BonosFonasas.FindAsync(id);
            if (bonosFonasa == null)
            {
                return NotFound();
            }
            return View(bonosFonasa);
        }

        // POST: BonosFonasas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("IdBonoFonasa,RutBeneficiario,NombreBeneficiario,RutTitular,NombreTitular,RutPrestador,NombrePrestador,PrestacionMedica,ValorTotal,Nivel,Folio,FechaHoraIngreso,PagaVisita")] BonosFonasa bonosFonasa)
        {
            if (id != bonosFonasa.IdBonoFonasa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bonosFonasa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BonosFonasaExists(bonosFonasa.IdBonoFonasa))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bonosFonasa);
        }

        // GET: BonosFonasas/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bonosFonasa = await _context.BonosFonasas
                .FirstOrDefaultAsync(m => m.IdBonoFonasa == id);
            if (bonosFonasa == null)
            {
                return NotFound();
            }

            return View(bonosFonasa);
        }

        // POST: BonosFonasas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var bonosFonasa = await _context.BonosFonasas.FindAsync(id);
            if (bonosFonasa != null)
            {
                _context.BonosFonasas.Remove(bonosFonasa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BonosFonasaExists(decimal id)
        {
            return _context.BonosFonasas.Any(e => e.IdBonoFonasa == id);
        }
    }
}

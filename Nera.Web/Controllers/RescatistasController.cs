using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nera.Web.Data;
using Nera.Web.Data.Entities;

namespace Nera.Web.Controllers
{
    public class RescatistasController : Controller
    {
        private readonly DataContext _context;

        public RescatistasController(DataContext context)
        {
            _context = context;
        }

        // GET: Rescatistas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rescatistas.ToListAsync());
        }

        // GET: Rescatistas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rescatista = await _context.Rescatistas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rescatista == null)
            {
                return NotFound();
            }

            return View(rescatista);
        }

        // GET: Rescatistas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rescatistas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Rut,Nombres,ApellidoPaterno,ApellidoMaterno,Telefono,Celular,Direccion")] Rescatista rescatista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rescatista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rescatista);
        }

        // GET: Rescatistas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rescatista = await _context.Rescatistas.FindAsync(id);
            if (rescatista == null)
            {
                return NotFound();
            }
            return View(rescatista);
        }

        // POST: Rescatistas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Rut,Nombres,ApellidoPaterno,ApellidoMaterno,Telefono,Celular,Direccion")] Rescatista rescatista)
        {
            if (id != rescatista.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rescatista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RescatistaExists(rescatista.ID))
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
            return View(rescatista);
        }

        // GET: Rescatistas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rescatista = await _context.Rescatistas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rescatista == null)
            {
                return NotFound();
            }

            return View(rescatista);
        }

        // POST: Rescatistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rescatista = await _context.Rescatistas.FindAsync(id);
            _context.Rescatistas.Remove(rescatista);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RescatistaExists(int id)
        {
            return _context.Rescatistas.Any(e => e.ID == id);
        }
    }
}

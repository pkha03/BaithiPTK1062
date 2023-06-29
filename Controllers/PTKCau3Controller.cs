using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaithiPTK1062.Models;
using MvcMovie.Data;

namespace BaithiPTK1062.Controllers
{
    public class PTKCau3Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public PTKCau3Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: PTKCau3
        public async Task<IActionResult> Index()
        {
              return _context.PTKCau3 != null ? 
                          View(await _context.PTKCau3.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.PTKCau3'  is null.");
        }

        // GET: PTKCau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.PTKCau3 == null)
            {
                return NotFound();
            }

            var pTKCau3 = await _context.PTKCau3
                .FirstOrDefaultAsync(m => m.hovaten == id);
            if (pTKCau3 == null)
            {
                return NotFound();
            }

            return View(pTKCau3);
        }

        // GET: PTKCau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PTKCau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("hovaten,diachi,sodienthoai")] PTKCau3 pTKCau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pTKCau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pTKCau3);
        }

        // GET: PTKCau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.PTKCau3 == null)
            {
                return NotFound();
            }

            var pTKCau3 = await _context.PTKCau3.FindAsync(id);
            if (pTKCau3 == null)
            {
                return NotFound();
            }
            return View(pTKCau3);
        }

        // POST: PTKCau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("hovaten,diachi,sodienthoai")] PTKCau3 pTKCau3)
        {
            if (id != pTKCau3.hovaten)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pTKCau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PTKCau3Exists(pTKCau3.hovaten))
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
            return View(pTKCau3);
        }

        // GET: PTKCau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.PTKCau3 == null)
            {
                return NotFound();
            }

            var pTKCau3 = await _context.PTKCau3
                .FirstOrDefaultAsync(m => m.hovaten == id);
            if (pTKCau3 == null)
            {
                return NotFound();
            }

            return View(pTKCau3);
        }

        // POST: PTKCau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.PTKCau3 == null)
            {
                return Problem("Entity set 'MvcMovieContext.PTKCau3'  is null.");
            }
            var pTKCau3 = await _context.PTKCau3.FindAsync(id);
            if (pTKCau3 != null)
            {
                _context.PTKCau3.Remove(pTKCau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PTKCau3Exists(string id)
        {
          return (_context.PTKCau3?.Any(e => e.hovaten == id)).GetValueOrDefault();
        }
    }
}

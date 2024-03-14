using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyTrungTamLapTrinh.Data;
using QuanLyTrungTamLapTrinh.Models;

namespace QuanLyTrungTamLapTrinh.Controllers
{
    public class ThietBiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThietBiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ThietBi
        public async Task<IActionResult> Index()
        {
            return View(await _context.ThietBi.ToListAsync());
        }

        // GET: ThietBi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thietBi = await _context.ThietBi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thietBi == null)
            {
                return NotFound();
            }

            return View(thietBi);
        }

        // GET: ThietBi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ThietBi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenTB,MoTa,GhiChu")] ThietBi thietBi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thietBi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thietBi);
        }

        // GET: ThietBi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thietBi = await _context.ThietBi.FindAsync(id);
            if (thietBi == null)
            {
                return NotFound();
            }
            return View(thietBi);
        }

        // POST: ThietBi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenTB,MoTa,GhiChu")] ThietBi thietBi)
        {
            if (id != thietBi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thietBi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThietBiExists(thietBi.Id))
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
            return View(thietBi);
        }

        // GET: ThietBi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thietBi = await _context.ThietBi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thietBi == null)
            {
                return NotFound();
            }

            return View(thietBi);
        }

        // POST: ThietBi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thietBi = await _context.ThietBi.FindAsync(id);
            if (thietBi != null)
            {
                _context.ThietBi.Remove(thietBi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThietBiExists(int id)
        {
            return _context.ThietBi.Any(e => e.Id == id);
        }
    }
}

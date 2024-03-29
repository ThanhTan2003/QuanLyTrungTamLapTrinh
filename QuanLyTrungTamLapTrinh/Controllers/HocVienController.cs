﻿using System;
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
    public class HocVienController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HocVienController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HocVien
        public async Task<IActionResult> Index()
        {
            return View(await _context.HocVien.ToListAsync());
        }

        // GET: HocVien/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocVien = await _context.HocVien
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hocVien == null)
            {
                return NotFound();
            }

            return View(hocVien);
        }

        // GET: HocVien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HocVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HoTen,NgaySinh,SoDT,SoCCCD,GioiTinh,Email,DiaChi,GhiChu,TinhTrang,HinhAnh")] HocVien hocVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hocVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hocVien);
        }

        // GET: HocVien/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocVien = await _context.HocVien.FindAsync(id);
            if (hocVien == null)
            {
                return NotFound();
            }
            return View(hocVien);
        }

        // POST: HocVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HoTen,NgaySinh,SoDT,SoCCCD,GioiTinh,Email,DiaChi,GhiChu,TinhTrang,HinhAnh")] HocVien hocVien)
        {
            if (id != hocVien.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hocVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HocVienExists(hocVien.Id))
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
            return View(hocVien);
        }

        // GET: HocVien/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocVien = await _context.HocVien
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hocVien == null)
            {
                return NotFound();
            }

            return View(hocVien);
        }

        // POST: HocVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hocVien = await _context.HocVien.FindAsync(id);
            if (hocVien != null)
            {
                _context.HocVien.Remove(hocVien);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HocVienExists(int id)
        {
            return _context.HocVien.Any(e => e.Id == id);
        }
    }
}

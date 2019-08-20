﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OtoSpaMVC.Data;
using OtoSpaMVC.Models;

namespace OtoSpaMVC.Controllers
{
    public class GoogleMapsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GoogleMapsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GoogleMaps
        public async Task<IActionResult> Index()
        {
            return View(await _context.GoogleMap.ToListAsync());
        }

        // GET: GoogleMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var googleMap = await _context.GoogleMap
                .FirstOrDefaultAsync(m => m.ID == id);
            if (googleMap == null)
            {
                return NotFound();
            }

            return View(googleMap);
        }

        // GET: GoogleMaps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GoogleMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,langi,longi")] GoogleMap googleMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(googleMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(googleMap);
        }

        // GET: GoogleMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var googleMap = await _context.GoogleMap.FindAsync(id);
            if (googleMap == null)
            {
                return NotFound();
            }
            return View(googleMap);
        }

        // POST: GoogleMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,langi,longi")] GoogleMap googleMap)
        {
            if (id != googleMap.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(googleMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoogleMapExists(googleMap.ID))
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
            return View(googleMap);
        }

        // GET: GoogleMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var googleMap = await _context.GoogleMap
                .FirstOrDefaultAsync(m => m.ID == id);
            if (googleMap == null)
            {
                return NotFound();
            }

            return View(googleMap);
        }

        // POST: GoogleMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var googleMap = await _context.GoogleMap.FindAsync(id);
            _context.GoogleMap.Remove(googleMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoogleMapExists(int id)
        {
            return _context.GoogleMap.Any(e => e.ID == id);
        }
    }
}

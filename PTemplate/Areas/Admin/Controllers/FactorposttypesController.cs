using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FactorposttypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FactorposttypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Factorposttypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Factorposttypes.ToListAsync());
        }

        // GET: Admin/Factorposttypes/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factorposttype = await _context.Factorposttypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factorposttype == null)
            {
                return NotFound();
            }

            return View(factorposttype);
        }

        // GET: Admin/Factorposttypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Factorposttypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Factorposttype factorposttype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factorposttype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(factorposttype);
        }

        // GET: Admin/Factorposttypes/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factorposttype = await _context.Factorposttypes.FindAsync(id);
            if (factorposttype == null)
            {
                return NotFound();
            }
            return View(factorposttype);
        }

        // POST: Admin/Factorposttypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Id,Name,Description")] Factorposttype factorposttype)
        {
            if (id != factorposttype.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factorposttype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactorposttypeExists(factorposttype.Id))
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
            return View(factorposttype);
        }

        // GET: Admin/Factorposttypes/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factorposttype = await _context.Factorposttypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factorposttype == null)
            {
                return NotFound();
            }

            return View(factorposttype);
        }

        // POST: Admin/Factorposttypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var factorposttype = await _context.Factorposttypes.FindAsync(id);
            _context.Factorposttypes.Remove(factorposttype);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FactorposttypeExists(byte id)
        {
            return _context.Factorposttypes.Any(e => e.Id == id);
        }
    }
}

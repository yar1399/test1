using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "Manager,Admin")]
    [Area("Admin")]
    public class Color1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Color1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Color1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Colors1.ToListAsync());
        }

        // GET: Admin/Color1/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color1 = await _context.Colors1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (color1 == null)
            {
                return NotFound();
            }

            return View(color1);
        }

        // GET: Admin/Color1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Color1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Descrition")] Color1 color1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(color1);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Color1/Index");
            }
            return View(color1);
        }

        // GET: Admin/Color1/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color1 = await _context.Colors1.FindAsync(id);
            if (color1 == null)
            {
                return NotFound();
            }
            return View(color1);
        }



        // POST: Admin/Color1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Id,Name,Descrition")] Color1 color1)
        {
            if (id != color1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(color1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Color1Exists(color1.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Color1/Index");
            }
            return View(color1);
        }

        // GET: Admin/Color1/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color1 = await _context.Colors1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (color1 == null)
            {
                return NotFound();
            }

            return View(color1);
        }

        // POST: Admin/Color1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var color1 = await _context.Colors1.FindAsync(id);
            _context.Colors1.Remove(color1);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Color1/Index");
        }

        private bool Color1Exists(byte id)
        {
            return _context.Colors1.Any(e => e.Id == id);
        }
    }
}

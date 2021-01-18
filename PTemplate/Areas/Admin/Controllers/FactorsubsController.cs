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
    public class FactorsubsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FactorsubsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Factorsubs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Factorsubs.Include(f => f.IdfactorNavigation).Include(f => f.IdproductNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Factorsubs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factorsub = await _context.Factorsubs
              
                .Include(f => f.IdfactorNavigation)
                .Include(f => f.IdproductNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factorsub == null)
            {
                return NotFound();
            }

            return View(factorsub);
        }

        // GET: Admin/Factorsubs/Create
        public IActionResult Create()
        {
            ViewData["Idcolor"] = new SelectList(_context.Colors1, "Id", "Name");
            ViewData["Idfactor"] = new SelectList(_context.Factors1, "Id", "Id");
            ViewData["Idproduct"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        // POST: Admin/Factorsubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idproduct,Idfactor,Idcolor,Count,Money,Offpercent,Datecreate")] Factorsub factorsub)
        {
            if (ModelState.IsValid)
            {
                factorsub.Id = Guid.NewGuid();
                _context.Add(factorsub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idcolor"] = new SelectList(_context.Colors1, "Id", "Name", factorsub.Idproductcolor);
            ViewData["Idfactor"] = new SelectList(_context.Factors1, "Id", "Id", factorsub.Idfactor);
            ViewData["Idproduct"] = new SelectList(_context.Products, "Id", "Id", factorsub.Idproduct);
            return View(factorsub);
        }

        // GET: Admin/Factorsubs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factorsub = await _context.Factorsubs.FindAsync(id);
            if (factorsub == null)
            {
                return NotFound();
            }
            //ViewData["Idcolor"] = new SelectList(_context.Color1, "Id", "Name", factorsub.Idcolor);
            ViewData["Idfactor"] = new SelectList(_context.Factors1, "Id", "Id", factorsub.Idfactor);
            ViewData["Idproduct"] = new SelectList(_context.Products, "Id", "Id", factorsub.Idproduct);
            return View(factorsub);
        }

        // POST: Admin/Factorsubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Idproduct,Idfactor,Idcolor,Count,Money,Offpercent,Datecreate")] Factorsub factorsub)
        {
            if (id != factorsub.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factorsub);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactorsubExists(factorsub.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Products/Index");
            }
            //ViewData["Idcolor"] = new SelectList(_context.Color1, "Id", "Name", factorsub.Idcolor);
            ViewData["Idfactor"] = new SelectList(_context.Factors1, "Id", "Id", factorsub.Idfactor);
            ViewData["Idproduct"] = new SelectList(_context.Products, "Id", "Id", factorsub.Idproduct);
            return View(factorsub);
        }

        // GET: Admin/Factorsubs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factorsub = await _context.Factorsubs
               
                .Include(f => f.IdfactorNavigation)
                .Include(f => f.IdproductNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factorsub == null)
            {
                return NotFound();
            }

            return View(factorsub);
        }

        // POST: Admin/Factorsubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var factorsub = await _context.Factorsubs.FindAsync(id);
            _context.Factorsubs.Remove(factorsub);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Products/Index");
        }

        private bool FactorsubExists(Guid id)
        {
            return _context.Factorsubs.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Controllers
{
    public class FactorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FactorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Factors
        public async Task<IActionResult> Index()
        {
            var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(await _context
                .Factors1
                .Where(a=>a.Iduser==iduser)
                .OrderByDescending(a=>a.Datecreate)
                .ToListAsync());
        }

        // GET: Factors/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor = await _context
                .Factors1
                .Include(a=>a.IdfactorstateNavigation)
                .Include(a=>a.IdproductpaytypeNavigation)
                .Include(a=>a.IdproductaddressNavigation)
                .Include(a=>a.Factorsubs)
               

                .FirstOrDefaultAsync(m => m.Id == id);
            if (factor == null)
            {
                return NotFound();
            }

            return View(factor);
        }

        // GET: Factors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Factors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Iduser,Idfactorrequest,Idnetwork,Datecreate")] Factor factor)
        {
            if (ModelState.IsValid)
            {
                factor.Id = Guid.NewGuid();
                _context.Add(factor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(factor);
        }

        // GET: Factors/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor = await _context.Factors1.FindAsync(id);
            if (factor == null)
            {
                return NotFound();
            }
            return View(factor);
        }

        // POST: Factors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Iduser,Idfactorrequest,Idnetwork,Datecreate")] Factor factor)
        {
            if (id != factor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactorExists(factor.Id))
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
            return View(factor);
        }

        // GET: Factors/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor = await _context.Factors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factor == null)
            {
                return NotFound();
            }

            return View(factor);
        }

        // POST: Factors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var factor = await _context.Factors.FindAsync(id);
            _context.Factors.Remove(factor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FactorExists(Guid id)
        {
            return _context.Factors.Any(e => e.Id == id);
        }
    }
}

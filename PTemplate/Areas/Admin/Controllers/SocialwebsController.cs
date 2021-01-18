using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "System,Admin")]
    [Area("Admin")]
    public class SocialwebsController : Controller
    {
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public SocialwebsController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/Socialwebs
        public async Task<IActionResult> Index()
        {
            var _1868_yarbaseContext = _context.Socialwebs.Include(s => s.IdsocialNavigation);
            return View(await _1868_yarbaseContext.ToListAsync());
        }

        // GET: Admin/Socialwebs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialweb = await _context.Socialwebs
                .Include(s => s.IdsocialNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialweb == null)
            {
                return NotFound();
            }

            return View(socialweb);
        }

        // GET: Admin/Socialwebs/Create
        public IActionResult Create()
        {
            ViewData["Idsocial"] = new SelectList(_context.Socials, "Id", "Name");
            return View();
        }

        // POST: Admin/Socialwebs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idsocial,Link,Isactive,Description")] Socialweb socialweb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socialweb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idsocial"] = new SelectList(_context.Socials, "Id", "Name", socialweb.Idsocial);
            return View(socialweb);
        }

        // GET: Admin/Socialwebs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialweb = await _context.Socialwebs.FindAsync(id);
            if (socialweb == null)
            {
                return NotFound();
            }
            ViewData["Idsocial"] = new SelectList(_context.Socials, "Id", "Name", socialweb.Idsocial);
            return View(socialweb);
        }

        // POST: Admin/Socialwebs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Idsocial,Link,Isactive,Description")] Socialweb socialweb)
        {
            if (id != socialweb.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socialweb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialwebExists(socialweb.Id))
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
            ViewData["Idsocial"] = new SelectList(_context.Socials, "Id", "Name", socialweb.Idsocial);
            return View(socialweb);
        }

        // GET: Admin/Socialwebs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialweb = await _context.Socialwebs
                .Include(s => s.IdsocialNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialweb == null)
            {
                return NotFound();
            }

            return View(socialweb);
        }

        // POST: Admin/Socialwebs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socialweb = await _context.Socialwebs.FindAsync(id);
            _context.Socialwebs.Remove(socialweb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocialwebExists(int id)
        {
            return _context.Socialwebs.Any(e => e.Id == id);
        }
    }
}

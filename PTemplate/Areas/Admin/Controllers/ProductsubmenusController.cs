using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Data.DB;
using PTemplate.Models;
using PTemplate.Models.DataViewModel;
using PTemplate.Models.Enum;

namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "Manager,Admin")]
    [Area("Admin")]
    public class ProductsubmenusController : Controller
    {

        private readonly ApplicationDbContext _context;

        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public ProductsubmenusController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }



        // GET: Admin/Productsubmenus
        public async Task<IActionResult> Index(int Idmenu = 0,int paging=1)
        {

            IQueryable<Productsubmenu> _1868_yarbaseContext;
            if (Idmenu != 0)
            {
                _1868_yarbaseContext = _context.Productsubmenus.Include(p => p.IdmenuNavigation).AsQueryable().Where(A=>A.Id== Idmenu).OrderBy(o => o.Id); 
            }
            else
                _1868_yarbaseContext =  _context.Productsubmenus.Include(p => p.IdmenuNavigation).AsQueryable().OrderBy(o => o.Id);


            if (paging == null)
                paging = 1;

            var b = _1868_yarbaseContext.GetPaged<Productsubmenu>((int)paging, 20);

            ViewData["PageSize"] = b.PageSize;
            ViewData["PageCount"] = b.PageCount;
            ViewData["CurrentPage"] = b.CurrentPage;
            ViewData["FirstRowOnPage"] = b.FirstRowOnPage;
          
            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "Name");
            return View(await _1868_yarbaseContext.ToListAsync());
        }

        // GET: Admin/Productsubmenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsubmenu = await _context.Productsubmenus
                .Include(p => p.IdmenuNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productsubmenu == null)
            {
                return NotFound();
            }

            return View(productsubmenu);
        }

        // GET: Admin/Productsubmenus/Create
        public IActionResult Create()
        {
            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "Name");
            return View();
        }

        // POST: Admin/Productsubmenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Idmenu")] Productsubmenu productsubmenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productsubmenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "Name", productsubmenu.Idmenu);
            return View(productsubmenu);
        }

        // GET: Admin/Productsubmenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsubmenu = await _context.Productsubmenus.FindAsync(id);
            if (productsubmenu == null)
            {
                return NotFound();
            }
            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "Name", productsubmenu.Idmenu);
            return View(productsubmenu);
        }

        // POST: Admin/Productsubmenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Idmenu")] Productsubmenu productsubmenu)
        {
            if (id != productsubmenu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productsubmenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsubmenuExists(productsubmenu.Id))
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
            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "Name", productsubmenu.Idmenu);
            return View(productsubmenu);
        }

        // GET: Admin/Productsubmenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsubmenu = await _context.Productsubmenus
                .Include(p => p.IdmenuNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productsubmenu == null)
            {
                return NotFound();
            }

            return View(productsubmenu);
        }

        // POST: Admin/Productsubmenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productsubmenu = await _context.Productsubmenus.FindAsync(id);
            _context.Productsubmenus.Remove(productsubmenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsubmenuExists(int id)
        {
            return _context.Productsubmenus.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Areas.Admin.Data;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Models;

namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,MenuGroup")]
    [Area("Admin")]
    public class MenugroupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenugroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Menugroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.Menugroups.ToListAsync());
        }

        // GET: Menugroups/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menugroup = await _context.Menugroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menugroup == null)
            {
                return NotFound();
            }

            return View(menugroup);
        }

        // GET: Menugroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Menugroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Istype,Isactive")] Menugroup menugroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menugroup);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Menugroups/Index");
            }
            return View(menugroup);
        }

        // GET: Menugroups/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menugroup = await _context.Menugroups.FindAsync(id);
            if (menugroup == null)
            {
                return NotFound();
            }
            return View(menugroup);
        }

        // POST: Menugroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Id,Name,Description,Istype,Isactive")] Menugroup menugroup)
        {
            if (id != menugroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menugroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenugroupExists(menugroup.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Menugroups/Index");
            }
            return View(menugroup);
        }

        // GET: Menugroups/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menugroup = await _context.Menugroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menugroup == null)
            {
                return NotFound();
            }

            return View(menugroup);
        }

        // POST: Menugroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {

            var menugroup = await _context.Menugroups.FindAsync(id);
            _context.Menugroups.Remove(menugroup);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Menugroups/Index");
 
        }

        private bool MenugroupExists(byte id)
        {
            return _context.Menugroups.Any(e => e.Id == id);
        }
    }
}

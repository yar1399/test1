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

namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "Manager,Admin")]
    [Area("Admin")]
    public class PosttypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PosttypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Posttypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Posttypes.ToListAsync());
        }

        // GET: Admin/Posttypes/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posttype = await _context.Posttypes.FirstOrDefaultAsync(m => m.Id == id);
            if (posttype == null)
            {
                return NotFound();
            }

            return View(posttype);
        }

        // GET: Admin/Posttypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Posttypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Posttype posttype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(posttype);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Posttypes/Index");
            }
            return View(posttype);
        }

        // GET: Admin/Posttypes/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posttype = await _context.Posttypes.FindAsync(id);
            if (posttype == null)
            {
                return NotFound();
            }
            return View(posttype);
        }

        // POST: Admin/Posttypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Id,Name,Description")] Posttype posttype)
        {
            if (id != posttype.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(posttype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PosttypeExists(posttype.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Posttypes/Index");
            }
            return View(posttype);
        }

        // GET: Admin/Posttypes/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posttype = await _context.Posttypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posttype == null)
            {
                return NotFound();
            }

            return View(posttype);
        }

        // POST: Admin/Posttypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var posttype = await _context.Posttypes.FindAsync(id);
            _context.Posttypes.Remove(posttype);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Posttypes/Index");
        }

        private bool PosttypeExists(byte id)
        {
            return _context.Posttypes.Any(e => e.Id == id);
        }
    }
}

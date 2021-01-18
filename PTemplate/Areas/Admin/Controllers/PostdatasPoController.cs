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
    [Authorize(Roles = "Manager,Admin,Oprator")]
    [Area("Admin")]
    public class PostdatasPoController : Controller
    {
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public PostdatasPoController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }


        // GET: Admin/PostdatasPo
        public async Task<IActionResult> Index(long? id = 0)
        {
     
            if(id==0)
            {
                return Redirect("/Admin/Posts/Index");

            }

         var po=   ViewData["post"] = await _context.Posts.Include(p => p.IdmenuNavigation).Include(p => p.IdposttoptypeNavigation).Include(p => p.IdposttypeNavigation)
              .Where(p => p.Id == id).FirstOrDefaultAsync();

            if (po == null)
            {
                return Redirect("/Admin/Posts/Index");

            }


            ViewData["post"]= po;

            List<Postdatum> applicationDbContext;
            if (id == 0)
                applicationDbContext = await _context.Postdata.Include(p => p.IddatatypeNavigation).Include(p => p.IdpostNavigation).ToListAsync();
            else
                applicationDbContext = await _context.Postdata.Include(p => p.IddatatypeNavigation).Include(p => p.IdpostNavigation).Where(p => p.Idpost == id).ToListAsync();

            ViewData["Idpost"] = id;
          

            return View(applicationDbContext);
        }

        // GET: Admin/PostdatasPo/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postdata = await _context.Postdata
                .Include(p => p.IddatatypeNavigation)
                .Include(p => p.IdpostNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postdata == null)
            {
                return NotFound();
            }

            return View(postdata);
        }

        // GET: Admin/PostdatasPo/Create
        public IActionResult Create()
        {
            ViewData["Iddatatype"] = new SelectList(_context.Datatypes, "Id", "Id");
            ViewData["Idpost"] = new SelectList(_context.Posts, "Id", "Id");
            return View();
        }

        // POST: Admin/PostdatasPo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idpost,Iddatatype,Pathdata,Isactive,Description")] Postdata postdata)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postdata);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Iddatatype"] = new SelectList(_context.Datatypes, "Id", "Id", postdata.Iddatatype);
            ViewData["Idpost"] = new SelectList(_context.Posts, "Id", "Id", postdata.Idpost);
            return View(postdata);
        }

        // GET: Admin/PostdatasPo/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postdata = await _context.Postdata.FindAsync(id);
            if (postdata == null)
            {
                return NotFound();
            }
            ViewData["Iddatatype"] = new SelectList(_context.Datatypes, "Id", "Id", postdata.Iddatatype);
            ViewData["Idpost"] = new SelectList(_context.Posts, "Id", "Id", postdata.Idpost);
            return View(postdata);
        }

        // POST: Admin/PostdatasPo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Idpost,Iddatatype,Pathdata,Isactive,Description")] Postdata postdata)
        {
            if (id != postdata.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postdata);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostdataExists(postdata.Id))
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
            ViewData["Iddatatype"] = new SelectList(_context.Datatypes, "Id", "Id", postdata.Iddatatype);
            ViewData["Idpost"] = new SelectList(_context.Posts, "Id", "Id", postdata.Idpost);
            return View(postdata);
        }

        // GET: Admin/PostdatasPo/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postdata = await _context.Postdata
                .Include(p => p.IddatatypeNavigation)
                .Include(p => p.IdpostNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postdata == null)
            {
                return NotFound();
            }

            return View(postdata);
        }

        // POST: Admin/PostdatasPo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var postdata = await _context.Postdata.FindAsync(id);
            _context.Postdata.Remove(postdata);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostdataExists(long id)
        {
            return _context.Postdata.Any(e => e.Id == id);
        }
    }
}

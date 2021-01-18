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

namespace PTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FactorpostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FactorpostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Factorposts
        public async Task<IActionResult> Index(Guid? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var applicationDbContext = _context.Factorposts.Include(f => f.IdfactorNavigation)
                .Include(f => f.IdfactorposttypeNavigation).Where(a=>a.Idfactor==(Guid)id);
            ViewData["id"] = id.ToString();
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Factorposts/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factorpost = await _context.Factorposts
                .Include(f => f.IdfactorNavigation)
                .Include(f => f.IdfactorposttypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factorpost == null)
            {
                return NotFound();
            }

            return View(factorpost);
        }

        // GET: Admin/Factorposts/Create
        public IActionResult Create(Guid? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var applicationDbContext = _context.Factors1.Where(a => a.Id == (Guid)id).ToList();

            ViewData["Idfactor"] = new SelectList(applicationDbContext, "Id", "Id");
            ViewData["Idfactorposttype"] = new SelectList(_context.Factorposttypes, "Id", "Name");
            return View();
        }

        // POST: Admin/Factorposts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codefollowup,Money,IduserCreator,Iduserpost,Datecreate,Datepost,Idfactor,Idfactorposttype,Isbus,Isfinesh")] Factorpost factorpost)
        {
            if (ModelState.IsValid)
            {
                 var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);// User.Identity.Name;
                factorpost.Iduserpost = userId;
                factorpost.IduserCreator = userId;
                factorpost.Datecreate = DateTime.Now;
               _context.Add(factorpost);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Factorposts/Index/"+ factorpost.Idfactor);
            }
            ViewData["Idfactor"] = new SelectList(_context.Factors1.Where(a=>a.Id== factorpost.Idfactor), "Id", "Id", factorpost.Idfactor);
            ViewData["Idfactorposttype"] = new SelectList(_context.Factorposttypes, "Id", "Name", factorpost.Idfactorposttype);
            return View(factorpost);
        }

        // GET: Admin/Factorposts/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {

                return NotFound();

            }

            var factorpost = await _context.Factorposts.FindAsync(id);

            if (factorpost == null)
            {

                return NotFound();

            }

            ViewData["Idfactor"] = new SelectList(_context.Factors1.Where(a=>a.Id== factorpost.Idfactor), "Id", "Id", factorpost.Idfactor);

            ViewData["Idfactorposttype"] = new SelectList(_context.Factorposttypes, "Id", "Name", factorpost.Idfactorposttype);

            return View(factorpost);
        }

        // POST: Admin/Factorposts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Codefollowup,Money,IduserCreator,Iduserpost,Datecreate,Datepost,Idfactor,Idfactorposttype,Isbus,Isfinesh")] Factorpost factorpost)
        {
            if (id != factorpost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    var fapo =await _context.Factorposts.AsNoTracking().Where(a=>a.Id== id).FirstOrDefaultAsync();

                    if (fapo==null)
                    {
                        return NotFound();
                    }
                    factorpost.Iduserpost = fapo.Iduserpost;
                    factorpost.IduserCreator = fapo.IduserCreator;
                    _context.Factorposts.Update(factorpost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactorpostExists(factorpost.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Factorposts/Index/" + factorpost.Idfactor);
               
            }
            ViewData["Idfactor"] = new SelectList(_context.Factors1.Where(a=>a.Id== factorpost.Idfactor), "Id", "Id", factorpost.Idfactor);
            ViewData["Idfactorposttype"] = new SelectList(_context.Factorposttypes, "Id", "Name", factorpost.Idfactorposttype);
            return View(factorpost);
        }

        // GET: Admin/Factorposts/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factorpost = await _context.Factorposts
                .Include(f => f.IdfactorNavigation)
                .Include(f => f.IdfactorposttypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factorpost == null)
            {
                return NotFound();
            }

            return View(factorpost);
        }

        // POST: Admin/Factorposts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var factorpost = await _context.Factorposts.FindAsync(id);
            _context.Factorposts.Remove(factorpost);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Factorposts/Index/" + factorpost.Idfactor);
        }

        private bool FactorpostExists(long id)
        {
            return _context.Factorposts.Any(e => e.Id == id);
        }
    }
}

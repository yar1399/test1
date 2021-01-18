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
    public class Factor1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Factor1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Factor1
        public async Task<IActionResult> Index()
        {

            var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);
           
            var _1868_yarbaseContext = _context.Factors1.Include(f => f.IdbankstateNavigation)
                .Include(f => f.IdfactorstateNavigation)
                .Include(f => f.IdproductaddressNavigation)
                .Include(f => f.IdproductpaytypeNavigation)
                //.Include(f => f.IduserNavigation)
                .Where(a=>a.Iduser==iduser).OrderByDescending(a=>a.Datecreate);
            return View(await _1868_yarbaseContext.ToListAsync());

        }

        // GET: Factor1/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor1 = await _context.Factors1
                .Include(f => f.IdbankstateNavigation)
                .Include(f => f.IdfactorstateNavigation)
                .Include(f => f.IdproductaddressNavigation)
                .Include(f => f.IdproductpaytypeNavigation)
                //.Include(f => f.IduserNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factor1 == null)
            {
                return NotFound();
            }

            return View(factor1);
        }

        // GET: Factor1/Create
        public IActionResult Create()
        {
            ViewData["Idbankstate"] = new SelectList(_context.Bankstates, "Id", "Id");
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Id");
            ViewData["Idproductaddress"] = new SelectList(_context.Productaddresses, "Id", "Id");
            ViewData["Idproductpaytype"] = new SelectList(_context.Productpaytypes, "Id", "Id");
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id");
            return View();
        }

        // POST: Factor1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Iduser,Idfactorstate,Idbankstate,Isactive,Datecreate,Datechangestate,Idproductaddress,Authority,Idproductpaytype")] Factor1 factor1)
        {
            if (ModelState.IsValid)
            {
                factor1.Id = Guid.NewGuid();
                _context.Add(factor1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idbankstate"] = new SelectList(_context.Bankstates, "Id", "Id", factor1.Idbankstate);
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Id", factor1.Idfactorstate);
            ViewData["Idproductaddress"] = new SelectList(_context.Productaddresses, "Id", "Id", factor1.Idproductaddress);
            ViewData["Idproductpaytype"] = new SelectList(_context.Productpaytypes, "Id", "Id", factor1.Idproductpaytype);
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", factor1.Iduser);
            return View(factor1);
        }

        // GET: Factor1/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor1 = await _context.Factors1.FindAsync(id);
            if (factor1 == null)
            {
                return NotFound();
            }
            ViewData["Idbankstate"] = new SelectList(_context.Bankstates, "Id", "Id", factor1.Idbankstate);
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Id", factor1.Idfactorstate);
            ViewData["Idproductaddress"] = new SelectList(_context.Productaddresses, "Id", "Id", factor1.Idproductaddress);
            ViewData["Idproductpaytype"] = new SelectList(_context.Productpaytypes, "Id", "Id", factor1.Idproductpaytype);
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", factor1.Iduser);
            return View(factor1);
        }

        // POST: Factor1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Iduser,Idfactorstate,Idbankstate,Isactive,Datecreate,Datechangestate,Idproductaddress,Authority,Idproductpaytype")] Factor1 factor1)
        {
            if (id != factor1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factor1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Factor1Exists(factor1.Id))
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
            ViewData["Idbankstate"] = new SelectList(_context.Bankstates, "Id", "Id", factor1.Idbankstate);
            ViewData["Idfactorstate"] = new SelectList(_context.Factorstates, "Id", "Id", factor1.Idfactorstate);
            ViewData["Idproductaddress"] = new SelectList(_context.Productaddresses, "Id", "Id", factor1.Idproductaddress);
            ViewData["Idproductpaytype"] = new SelectList(_context.Productpaytypes, "Id", "Id", factor1.Idproductpaytype);
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", factor1.Iduser);
            return View(factor1);
        }

        // GET: Factor1/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factor1 = await _context.Factors1
                .Include(f => f.IdbankstateNavigation)
                .Include(f => f.IdfactorstateNavigation)
                .Include(f => f.IdproductaddressNavigation)
                .Include(f => f.IdproductpaytypeNavigation)
               //.Include(f => f.IduserNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factor1 == null)
            {
                return NotFound();
            }

            return View(factor1);
        }

        // POST: Factor1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var factor1 = await _context.Factors1.FindAsync(id);
            _context.Factors1.Remove(factor1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Factor1Exists(Guid id)
        {
            return _context.Factors1.Any(e => e.Id == id);
        }
    }
}

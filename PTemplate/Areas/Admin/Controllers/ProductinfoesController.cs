using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductinfoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductinfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Productinfoes
        public async Task<IActionResult> Index(long? id=0)
        {

            if ( id == null || id == 0 )
            {
                return Redirect("~/Admin/Product/Index");
            }

            var applicationDbContext = _context.Productinfos
                .Include(p => p.IdproductNavigation)
                .Include(p => p.IdproductmenuinfoNavigation)
                .Where(a=>a.Idproduct==id);
            ViewData["idproduct"] = id;



            ViewData["Product"] = await _context.Products.
                Include(p => p.IdmenuNavigation)
               .Where(p => p.Id == id).FirstOrDefaultAsync();
            return View(await applicationDbContext.ToListAsync());
        }



        // GET: Admin/Productinfoes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return Redirect("~/Admin/Productinfoes/Index");
            }

            var productinfo = await _context.Productinfos
                .Include(p => p.IdproductNavigation)
                .Include(p => p.IdproductmenuinfoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productinfo == null)
            {
                return Redirect("~/Admin/Productinfoes/Index");
            }

            var pto = _context.Products.
               Include(p => p.IdmenuNavigation)
              .Where(p => p.Id == productinfo.Idproduct).FirstOrDefault();
            ViewData["Product"] = pto;

            if (pto == null)
            {
                return Redirect("~/Admin/Productinfoes/Index");
            }


            //ViewData["idproduct"] = new SelectList(_context.Product.Where(a => a.Id == id), "Id", "Title");
            //var bb = new SelectList(_context.Productmenuinfo.Where(a => a.Idsubmenu == pto.Idmenu), "Id", "Title");
            //ViewData["idproductmenuinfo"] = bb;

            return View(productinfo);
        }

        // GET: Admin/Productinfoes/Create
        public IActionResult Create(long? id)
        {
            
            if(id==null || id==0)
            {
                return Redirect("~/Admin/Productinfoes/Index");
            }
            var pto = _context.Products.
                Include(p => p.IdmenuNavigation)
               .Where(p => p.Id == id).FirstOrDefault();
            ViewData["Product"] = pto;

            ViewData["idproduct"] = new SelectList(_context.Products.Where(a=>a.Id==id), "Id", "Title");
            var bb = new SelectList(_context.Productmenuinfos.Where(a=>a.Idsubmenu==pto.Idmenu), "Id", "Title");
            ViewData["idproductmenuinfo"] = bb;
            return View();
        }

        // POST: Admin/Productinfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idproductmenuinfo,Idproduct,Description,Datecreate")] Productinfo productinfo)
        {
            if (ModelState.IsValid)
            {
                productinfo.Datecreate = DateTime.Now;
                _context.Add(productinfo);
                await _context.SaveChangesAsync();
                return Redirect("~/Admin/Productinfoes/Index/"+ productinfo.Idproduct);
                
            }
            ViewData["idproduct"] = new SelectList(_context.Products, "Id", "Title", productinfo.Idproduct);
            ViewData["idproductmenuinfo"] = new SelectList(_context.Productmenuinfos.Where(a=>a.Idsubmenu== productinfo.Idproductmenuinfo), "Id", "Title", productinfo.Idproductmenuinfo);
            return View(productinfo);
        }

        // GET: Admin/Productinfoes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productinfo = await _context.Productinfos.FindAsync(id);
            if (productinfo == null)
            {
                return NotFound();
            }
            var pto = _context.Products.
                Include(p => p.IdmenuNavigation)
               .Where(p => p.Id == id).FirstOrDefault();
            ViewData["Product"] = pto;

            ViewData["idproduct"] = new SelectList(_context.Products.Where(a => a.Id == id), "Id", "Title");
            var bb = new SelectList(_context.Productmenuinfos.Where(a => a.Idsubmenu == pto.Idmenu), "Id", "Title");
            ViewData["idproductmenuinfo"] = bb;
            return View(productinfo);
        }

        // POST: Admin/Productinfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long Id, [Bind("Id,Idproductmenuinfo,Idproduct,Description,Datecreate")] Productinfo productinfo)
        {
            if (Id != productinfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    productinfo.Datecreate = DateTime.Now;
                    _context.Update(productinfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductinfoExists(productinfo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("~/Admin/Productinfoes/Index/" + productinfo.Idproduct);
            }
            var pto = _context.Products.
               Include(p => p.IdmenuNavigation)
              .Where(p => p.Id == Id).FirstOrDefault();
            ViewData["Product"] = pto;

            ViewData["idproduct"] = new SelectList(_context.Products.Where(a => a.Id == Id), "Id", "Title");
            var bb = new SelectList(_context.Productmenuinfos.Where(a => a.Idsubmenu == pto.Idmenu), "Id", "Title");
            ViewData["idproductmenuinfo"] = bb;
            return View(productinfo);
        }

        // GET: Admin/Productinfoes/Delete/5
        public async Task<IActionResult> Delete(long? Id)
        {
            if (Id == null)
            {
                return Redirect("~/Admin/Productinfoes/Index");
            }

            var productinfo = await _context.Productinfos
                .Include(p => p.IdproductNavigation)
                .Include(p => p.IdproductmenuinfoNavigation)
                .FirstOrDefaultAsync(m => m.Id == Id);
            var pto = _context.Products.
              Include(p => p.IdmenuNavigation)
             .Where(p => p.Id == Id).FirstOrDefault();
            ViewData["Product"] = pto;

            if (productinfo == null)
            {
                return Redirect("~/Admin/Productinfoes/Index");
            }

            return View(productinfo);
        }

        // POST: Admin/Productinfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var productinfo = await _context.Productinfos.FindAsync(id);
            _context.Productinfos.Remove(productinfo);
            await _context.SaveChangesAsync();
            return Redirect("~/Admin/Productinfoes/Index/" + productinfo.Idproduct);
        }

        private bool ProductinfoExists(long id)
        {
            return _context.Productinfos.Any(e => e.Id == id);
        }
    }
}

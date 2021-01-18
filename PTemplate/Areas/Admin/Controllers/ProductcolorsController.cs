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
    public class ProductcolorsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductcolorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Productcolors
        public async Task<IActionResult> Index(long? id)
        {
            if(id==null)
            {
                return Redirect("/Admin/Products/Index");
              
            }

            var applicationDbContext =await _context.Productcolors
                .Include(p => p.IdcolorNavigation)
                .Include(p => p.IdproductNavigation)
                .Where(m => m.Idproduct == id).ToListAsync();

          

            var product = await _context.Products
              .Include(p => p.IdmenuNavigation)
            
              .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            ViewData["product"] = product;
            return View( applicationDbContext);

        }

        // GET: Admin/Productcolors/Details/5
        public async Task<IActionResult> Details(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

           

          

            var productcolor = await _context.Productcolors
                .Include(p => p.IdcolorNavigation)
                .Include(p => p.IdproductNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (productcolor == null)
            {
                return NotFound();
            }

            var product = await _context.Products
             .Include(p => p.IdmenuNavigation)
            
             .FirstOrDefaultAsync(m => m.Id == productcolor.Idproduct);

            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }
            ViewData["product"] = product;

            return View(productcolor);
        }

        // GET: Admin/Productcolors/Create
        public async Task<IActionResult> Create(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/Products/Index");
            }

           

            var product = await _context.Products
             .Include(p => p.IdmenuNavigation)
            
             .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            ViewData["product"] = product;
            ViewData["Idcolor"] = new SelectList(_context.Colors1, "Id", "Name");
            ViewData["Idproduct"] = new SelectList(_context.Products.Where(p=>p.Id==id), "Id", "Title");
            return View();
        }

        // POST: Admin/Productcolors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idcolor,Idproduct,Count")] Productcolor productcolor)
        {
            if (ModelState.IsValid)
            {
                productcolor.Idproduct = productcolor.Idproduct;
                productcolor.Id = null;
                _context.Productcolors.Add(productcolor);
                 _context.SaveChanges();
                return Redirect("/Admin/Productcolors/index/" + productcolor.Idproduct);
            }

            ViewData["Idcolor"] = new SelectList(_context.Colors1, "Id", "Name", productcolor.Idcolor);
            ViewData["Idproduct"] = new SelectList(_context.Products, "Id", "Title", productcolor.Idproduct);

            return View(productcolor);
        }

        // GET: Admin/Productcolors/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productcolor = await _context.Productcolors.FindAsync(id);
            if (productcolor == null)
            {
                return NotFound();
            }

            var product = await _context.Products
             .Include(p => p.IdmenuNavigation)
             .FirstOrDefaultAsync(m => m.Id == productcolor.Idproduct);

            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            ViewData["product"] = product;

            ViewData["Idcolor"]   = new SelectList(_context.Colors1, "Id", "Name", productcolor.Idcolor);
            ViewData["Idproduct"] = new SelectList(_context.Products.Where(a => a.Id == productcolor.Idproduct), "Id", "Title", productcolor.Idproduct);
            return View(productcolor);
        }

        // POST: Admin/Productcolors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Idcolor,Idproduct,Count")] Productcolor productcolor)
        {
            if (id != productcolor.Id)
            {
                return Redirect("/Admin/Productcolors/index/" + productcolor.Idproduct);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productcolor);
                    await _context.SaveChangesAsync();
                    return Redirect("/Admin/Productcolors/index/" + productcolor.Idproduct);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductcolorExists((long)productcolor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Productcolors/index/" + productcolor.Idproduct);
            }

            ViewData["Idcolor"] = new SelectList(_context.Colors1, "Id", "Name", productcolor.Idcolor);
            ViewData["Idproduct"] = new SelectList(_context.Products, "Id", "Title", productcolor.Idproduct);

            return View(productcolor);
        }

        // GET: Admin/Productcolors/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           

            var productcolor = await _context.Productcolors
                .Include(p => p.IdcolorNavigation)
                .Include(p => p.IdproductNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (productcolor == null)
            {
                return NotFound();
            }

            var product = await _context.Products
           .Include(p => p.IdmenuNavigation)
           
           .FirstOrDefaultAsync(m => m.Id == productcolor.Idproduct);

            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            ViewData["product"] = product;

            return View(productcolor);
        }

        // POST: Admin/Productcolors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var productcolor = await _context.Productcolors.FindAsync(id);
            _context.Productcolors.Remove(productcolor);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Productcolors/index/" + productcolor.Idproduct);
        }

        private bool ProductcolorExists(long id)
        {
            return _context.Productcolors.Any(e => e.Id == id);
        }


    }
}

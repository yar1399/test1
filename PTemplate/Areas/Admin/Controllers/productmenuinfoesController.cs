using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Models;

namespace PTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class productmenuinfoesController : Controller
    {
       // private readonly _1868_yarbaseContext _context;
        [Obsolete]
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public productmenuinfoesController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/productmenuinfoes
        [Obsolete]
        public async Task<IActionResult> Index(long? Idmenu = 0, int? paging = 1)
        {

           // var _1868_yarbaseContext = _context.productmenuinfo.Include(p => p.idsubmenuNavigation).Where(a=>a.idsubmenu==1);


            if (Idmenu == null )
            {
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            IQueryable<Productmenuinfo> applicationDbContext;
            if (Idmenu == 0)
                applicationDbContext = _context.Productmenuinfos.Include(p => p.IdsubmenuNavigation)
                    .OrderByDescending(o => o.Number)
                    .OrderByDescending(o => o.Date);
          
            else
                applicationDbContext = _context.Productmenuinfos.Include(p => p.IdsubmenuNavigation)
                    .Where(a => a.Idsubmenu == Idmenu).AsQueryable().OrderByDescending(o => o.Number )
                    .OrderByDescending(o => o.Date);




            if (paging == null)
                paging = 1;

            var b = applicationDbContext.GetPaged<Productmenuinfo>((int)paging, 20);

            ViewData["PageSize"] = b.PageSize;
            ViewData["PageCount"] = b.PageCount;
            ViewData["CurrentPage"] = b.CurrentPage;
            ViewData["FirstRowOnPage"] = b.FirstRowOnPage;
           
            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m =>  mg.Any(meg => (long)meg.Id == (long)m.Id )).ToList();

            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name");

            return View(await applicationDbContext.ToListAsync());

        }

        // GET: Admin/productmenuinfoes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            var productmenuinfo = await _context.Productmenuinfos
                .Include(p => p.IdsubmenuNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productmenuinfo == null)
            {
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            return View(productmenuinfo);
        }

        // GET: Admin/productmenuinfoes/Create
        public IActionResult Create()
        {

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();

            ViewData["idsubmenu"] = new SelectList(ss, "Id", "Name");
         
            return View();
        }

        // POST: Admin/productmenuinfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idsubmenu,Title,Date,Number")] Productmenuinfo productmenuinfo)
        {
            if (ModelState.IsValid)
            {
                productmenuinfo.Date = DateTime.Now;
                productmenuinfo.Id = null;
                _context.Productmenuinfos.Add(productmenuinfo);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            ViewData["idsubmenu"] = new SelectList(_context.Menus, "Id", "Title", productmenuinfo.Idsubmenu);
            return View(productmenuinfo);
        }

        // GET: Admin/productmenuinfoes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            var productmenuinfo = await _context.Productmenuinfos.FindAsync(id);
            if (productmenuinfo == null)
            {
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();


            //DateTime result;
            //if (!DateTime.TryParse(productmenuinfo.date.ToString(), out result))
            //{
            //    result = DateTime.ParseExact(productmenuinfo.date.ToString(), "yyyy-MM-ddT24:mm:ssK", System.Globalization.CultureInfo.InvariantCulture);
            //    // result = result.AddDays(1);
            //    productmenuinfo.date = result;
            //}

           

            ViewData["idsubmenu"] = new SelectList(ss, "Id", "Name", productmenuinfo.Idsubmenu);

           
            return View(productmenuinfo);
        }

        // POST: Admin/productmenuinfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Idsubmenu,Title,Date,Number")] Productmenuinfo productmenuinfo)
        {
            if (id != productmenuinfo.Id)
            {
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productmenuinfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!productmenuinfoExists((long)productmenuinfo.Id))
                    {
                        return Redirect("/Admin/productmenuinfoes/Index");
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/productmenuinfoes/Index");
            }
            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();

            ViewData["idsubmenu"] = new SelectList(ss, "Id", "Name", productmenuinfo.Idsubmenu);
            return View(productmenuinfo);
        }

        // GET: Admin/productmenuinfoes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            var productmenuinfo = await _context.Productmenuinfos
                .Include(p => p.IdsubmenuNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productmenuinfo == null)
            {
                return Redirect("/Admin/productmenuinfoes/Index");
            }

            return View(productmenuinfo);
        }

        // POST: Admin/productmenuinfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var productmenuinfo = await _context.Productmenuinfos.FindAsync(id);
            _context.Productmenuinfos.Remove(productmenuinfo);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/productmenuinfoes/Index");
        }

        private bool productmenuinfoExists(long id)
        {
            return _context.Productmenuinfos.Any(e => e.Id == id);
        }
    }
}

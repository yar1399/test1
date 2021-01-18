using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Controllers
{
    [Authorize]
    public class addressesController : Controller
    {
        [Obsolete]
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public addressesController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: addresses
        public async Task<IActionResult> Index()
        {
            var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var _1868_yarbaseContext = _context.Productaddresses
                //.Include(p => p.IduserNavigation)
                .Where(p => p.Iduser == iduser && p.Isactive==true);
            return View(await _1868_yarbaseContext.ToListAsync());
        }

        // GET: addresses/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productaddress = await _context.Productaddresses
                //.Include(p => p.IduserNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productaddress == null)
            {
                return NotFound();
            }

            return View(productaddress);
        }

        // GET: addresses/Create
        public IActionResult Create()
        {

            ViewData["address"] = "";
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id");
            return View();
        }

        // POST: addresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Iduser,Namefamily,Tell,Address,City,Province,Postalcode,Isactive,Isactivebase,Createdate")] Productaddress productaddress)
        {
            ViewData["address"] = "";

            if (string.IsNullOrEmpty(productaddress.Namefamily)||
                string.IsNullOrEmpty(productaddress.City)||
                string.IsNullOrEmpty(productaddress.Address)||
                string.IsNullOrEmpty(productaddress.Province)||
                string.IsNullOrEmpty(productaddress.Tell)||
                string.IsNullOrEmpty(productaddress.Postalcode))
            {
                ViewData["address"] = "تمامی اطلاعات را کامل وارد نمائید";
                return View(productaddress);
            }

            if (string.IsNullOrEmpty(productaddress.Postalcode))
            {
                ViewData["address"] = "کد پستی را وارد نمائید";
                return View(productaddress);
            }


          


            if (string.IsNullOrEmpty(productaddress.Tell))
            {
                ViewData["address"] = "تلفن را وارد نمائید";
                return View(productaddress);
            }

            if (productaddress.Tell.Length!=11)
            {
                ViewData["address"] = "تلفن را صحیح وارد نمائید";
                return View(productaddress);
            }


            if (productaddress.Postalcode.Length != 10)
            {
                ViewData["address"] = "کد پستی را صحیح وارد نمائید";
                return View(productaddress);
            }




            if (ModelState.IsValid )
            {
                if (productaddress.Postalcode.Length == 10 && productaddress.Tell.Length == 11)
                {
                    var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    productaddress.Iduser = iduser;
                    productaddress.Isactive = true;
                    productaddress.Createdate = DateTime.Now;
                    productaddress.Isactivebase = true;

                    var bb = _context.sp_productaddressinsert(productaddress);

                    if (bb.idcode == 1)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
               

             //_context.Add(productaddress);
            // await _context.SaveChangesAsync();

               
            }

            
               
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", productaddress.Iduser);

            return View(productaddress);

        }

        [HttpGet]
        public async Task<IActionResult> EditIsActiveAddress(long? id=0)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var productaddress = await _context.Productaddresses.Where(a => a.Id == id && a.Iduser == iduser).FirstOrDefaultAsync();
            if (productaddress == null)
            {
                return NotFound();
            }

            var address =await  _context.sp_productaddresschangeactive(iduser, productaddress.Id);

            return Redirect("/addresses/Index");
          //  return View("Index");
        }


        // GET: addresses/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var productaddress = await _context.Productaddresses.Where(a=>a.Id==id && a.Iduser== iduser).FirstOrDefaultAsync();
            if (productaddress == null)
            {
                return NotFound();
            }

            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", productaddress.Iduser);
            return View(productaddress);
        }

        // POST: addresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Iduser,Namefamily,Tell,Address,City,Province,Postalcode,Isactive,Isactivebase,Createdate")] Productaddress productaddress)
        {
            if (id != productaddress.Id)
            {
                return NotFound();
            }


            var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var prod = await _context.Productaddresses.Where(a => a.Id == id && a.Iduser == iduser).FirstOrDefaultAsync();
            if (prod == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    productaddress.Isactive = prod.Isactive;
                    productaddress.Isactivebase = prod.Isactivebase;
                    productaddress.Iduser = iduser;
                    _context.sp_productaddressupdate(id,productaddress);
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductaddressExists(productaddress.Id))
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
            //ViewData["Iduser"] = new SelectList(_context.AspNetUsers, "Id", "Id", productaddress.Iduser);
            return View(productaddress);
        }

        // GET: addresses/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productaddress = await _context.Productaddresses
                //.Include(p => p.IduserNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productaddress == null)
            {
                return NotFound();
            }

            return View(productaddress);
        }

        // POST: addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id=0)
        {
            if (id==0 )
            {
                return NotFound();
            }
            var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var productaddress = await _context.Productaddresses.Where(p=>p.Id==id && p.Iduser== iduser).FirstOrDefaultAsync();
            if (productaddress == null)
            {
                return NotFound();
            }

          await  _context.sp_productaddressdelete(iduser, productaddress.Id);
           
            return RedirectToAction(nameof(Index));
        }

        private bool ProductaddressExists(long id)
        {
            return _context.Productaddresses.Any(e => e.Id == id);
        }
    }
}

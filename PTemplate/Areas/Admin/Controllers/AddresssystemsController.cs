using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data.DataBase;
using System.Security.Principal;
using PTemplate.Data;
using PTemplate.Data.DB;
using System.Text.Json;

namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AddresssystemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddresssystemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Addresssystems
        public IActionResult addmap(Single lat =0, Single lng =0)
        {

            if (lat == 0 && lng==0)
            {
                return NotFound();
            }

            List<dbMessage> ts = new List<dbMessage>();


            dbMessage dc = new dbMessage();
            Addresssystem addresssystem = _context.Addresssystems
                          .FirstOrDefault();
            if (addresssystem == null)
            {

                dc.message = "NO";
                dc.idcode = 1;
                ts.Add(dc);

            }else
            {
                dc.message = "Yes";
                dc.idcode = 1;
                ts.Add(dc);
            }

            addresssystem.Lat = lat;
            addresssystem.Lng = lng;

            _context.Addresssystems.Update(addresssystem);
            int i=  _context.SaveChanges();
            if(i==0)
            {
                dc.message = "NO";
                dc.idcode = 1;
                ts.Add(dc);
            }


            return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
          
        }


        public IActionResult setmap()
        {

            Addresssystem addresssystem = _context.Addresssystems
                           .FirstOrDefault();

            if (addresssystem == null)
            {
                return NotFound();
            }

            return View(addresssystem);
        }

        // GET: Admin/Addresssystems/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var addresssystem = await _context.Addresssystems
                .FirstOrDefaultAsync();
            if (addresssystem == null)
            {
                return NotFound();
            }

            return View(addresssystem);
        }

        // GET: Admin/Addresssystems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Addresssystems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Tell,Fax,Description,Province,City,Address,Email,Postalcode,Text,Namemanger")] Addresssystem addresssystem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addresssystem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addresssystem);
        }

        // GET: Admin/Addresssystems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addresssystem = await _context.Addresssystems.FindAsync(id);
            if (addresssystem == null)
            {
                return NotFound();
            }
            return View(addresssystem);
        }

        // POST: Admin/Addresssystems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Tell,Fax,Description,Province,City,Address,Email,Postalcode,Text,Namemanger,Time")] Addresssystem addresssystem)
        {
            if (id != addresssystem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Addresssystem addres = _context.Addresssystems.AsNoTracking()
                          .FirstOrDefault();
                    addresssystem.Lng = addres.Lng;
                    addresssystem.Lat = addres.Lat;
                    addresssystem.Id = id;
                    _context.Addresssystems.Update(addresssystem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddresssystemExists(addresssystem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Addresssystems/Details/"+id);
            }
            return View(addresssystem);
        }

        // GET: Admin/Addresssystems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addresssystem = await _context.Addresssystems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addresssystem == null)
            {
                return NotFound();
            }

            return View(addresssystem);
        }

        // POST: Admin/Addresssystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addresssystem = await _context.Addresssystems.FindAsync(id);
            _context.Addresssystems.Remove(addresssystem);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Addresssystems/Index");
        }

        private bool AddresssystemExists(int id)
        {
            return _context.Addresssystems.Any(e => e.Id == id);
        }
    }
}

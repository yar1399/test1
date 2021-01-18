using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Controllers
{
    public class shabakekharidController : Controller
    {
        private readonly ApplicationDbContext _context;
        static string key { get; set; } = "codingaffairscom";
        public shabakekharidController(ApplicationDbContext context)
        {
            _context = context;
          String st=  Encrypt("reza");


        }


        public static string Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.CBC;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        // GET: shabakekharid
        public async Task<IActionResult> Index()
        {
            return View(await _context.Addresssystems.ToListAsync());
        }

        // GET: shabakekharid/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: shabakekharid/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: shabakekharid/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: shabakekharid/Edit/5
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

        // POST: shabakekharid/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Tell,Fax,Description,Province,City,Address,Email,Postalcode,Text,Namemanger")] Addresssystem addresssystem)
        {
            if (id != addresssystem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addresssystem);
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
                return RedirectToAction(nameof(Index));
            }
            return View(addresssystem);
        }

        // GET: shabakekharid/Delete/5
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

        // POST: shabakekharid/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addresssystem = await _context.Addresssystems.FindAsync(id);
            _context.Addresssystems.Remove(addresssystem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddresssystemExists(int id)
        {
            return _context.Addresssystems.Any(e => e.Id == id);
        }
    }
}

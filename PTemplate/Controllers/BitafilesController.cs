using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Data.DB;
using PTemplate.Models.DataViewModel;

namespace PTemplate.Controllers
{
    [Authorize]
    public class BitafilesController : Controller
    {
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly  IHostingEnvironment _environment;


        //public BitafilesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        [Obsolete]
        public BitafilesController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        //public BitafilesController( IHostingEnvironment environment)
        //{
        //    _environment = environment;
        //}

        // GET: Bitafiles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Bitafiles;
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("فایل در خواست نشد");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot\\uploads", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats  officedocument.spreadsheetml.sheet"},  
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadBita(IFormFile files)
        {
            if (ModelState.IsValid)
            {
                var formFile = files;
                if (formFile == null || formFile.Length == 0)
                {
                    ModelState.AddModelError("", "فایل خالی است.");
                    return RedirectToAction("Index", "Bitafiles");
                  
                }


                if (formFile.ContentType != "application/pdf")
                {
                    ModelState.AddModelError("", "فقط فایل های PDF.");
                    return RedirectToAction("Index", "Bitafiles");
                }


                if (formFile.Length >= 870000)
                {
                    ModelState.AddModelError("", "فایل کمتر از 800 کیلو باشند.");
                    return RedirectToAction("Index", "Bitafiles");
                }

                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads");
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }

                string nameFile = User.Identity.Name + "-" + new Random().Next(70000) + "-" + formFile.FileName;
                var filePath = Path.Combine(uploadsRootFolder, nameFile);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(fileStream).ConfigureAwait(false);
                }

                Data.DataBase.Bitafile bitafile = new Data.DataBase.Bitafile();
                bitafile.Datecreate = DateTime.Now;
                bitafile.Iduser= User.FindFirst(ClaimTypes.NameIdentifier).Value;
                bitafile.Name = formFile.FileName;
                bitafile.Namefile = nameFile;
                //ApplicationDbContext _context = new ApplicationDbContext();
                _context.Add(bitafile);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Bitafiles");
            }

            return RedirectToAction("Index", "Bitafiles");
        }






        // GET: Bitafiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitafile = await _context.Bitafiles
                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bitafile == null)
            {
                return NotFound();
            }

            return View(bitafile);
        }

       
        // GET: Bitafiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitafile = await _context.Bitafiles
                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bitafile == null)
            {
                return NotFound();
            }

            return View(bitafile);
        }

        // POST: Bitafiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string iduser = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var bitafile = await _context.Bitafiles.Where(p=>p.Id==id && p.Iduser== iduser).FirstOrDefaultAsync();
            _context.Bitafiles.Remove(bitafile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BitafileExists(int id)
        {
            return _context.Bitafiles.Any(e => e.Id == id);
        }
    }
}

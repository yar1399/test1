using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using System.Security.Claims;
using PTemplate.Models.DataViewModel;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using PTemplate.Models.Enum;
using Microsoft.AspNetCore.Authorization;

namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "Manager,Admin,Oprator")]
    [Area("Admin")]
    public class imageprofilesController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public imageprofilesController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/imageprofiles
        public async Task<IActionResult> Index()
        {

            return View(await _context.Imageprofiles.ToListAsync());
        }

        // GET: Admin/imageprofiles/Details/5
        public async Task<IActionResult> Details()
        {

            var iduserBase = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var imageprofile = await _context
                .Imageprofiles
                .Where(m => m.Iduser == iduserBase).OrderBy(a=>a.Id).FirstOrDefaultAsync();

            return View(imageprofile);
        }

        // GET: Admin/imageprofiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/imageprofiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(UploadViewModel files)
        {
            //if (ModelState.IsValid)
            //{
                var formFile = files.Photo;
                if (formFile == null || formFile.Length == 0)
                {
                    ModelState.AddModelError("", "فایل انتخاب نشده است.");
                    return View(viewName: "Details");
                }


                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads") + "/profile/";
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }

                string namrfile = new Random().Next(200, 900).ToString() + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + Path.GetExtension(formFile.FileName);

                var filePath = Path.Combine(uploadsRootFolder, namrfile);


                UploadViewModel.Image_resize(formFile.OpenReadStream(), filePath, (TypsImgesize)TypsImgesize.profile);

                var iduserBase = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            Imageprofile img = new Imageprofile();


                img.Iduser = iduserBase;
                img.Path = namrfile;
            img.Isactive = true;
                _context.Add(img);
             int count=   await _context.SaveChangesAsync();
            if(count==0)
            {

                var filePathDelete = Path.Combine(uploadsRootFolder, namrfile);
                var fileInfo = new System.IO.FileInfo(filePathDelete);
                fileInfo.Delete();
            }
                return Redirect("/Admin/imageprofiles/Details");
            //}
         //   return View();
        }

        // GET: Admin/imageprofiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageprofile = await _context.Imageprofiles.FindAsync(id);
            if (imageprofile == null)
            {
                return NotFound();
            }
            return View(imageprofile);
        }

        // POST: Admin/imageprofiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,iduser,path,isactive")] Imageprofile imageprofile)
        {
            if (id != imageprofile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imageprofile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!imageprofileExists(imageprofile.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/imageprofiles/Details");
            }
            return View(imageprofile);
        }

        // GET: Admin/imageprofiles/Delete/5
        public async Task<IActionResult> Delete()
        {
            var iduserBase = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var imageprofile = await _context
                .Imageprofiles
                .Where(m => m.Iduser == iduserBase).OrderBy(a => a.Id).FirstAsync();

            return View(imageprofile);
        }

        // POST: Admin/imageprofiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iduserBase = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var imageprofile = await _context
                .Imageprofiles
                .Where(m => m.Iduser == iduserBase).OrderBy(a => a.Id).FirstAsync();

            if (imageprofile != null)
            {
                _context.Imageprofiles.Remove(imageprofile);
              int count=  await _context.SaveChangesAsync();
                if (count != 0)
                {


                    var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads") + "/profile/";
                    if (!Directory.Exists(uploadsRootFolder))
                    {
                        Directory.CreateDirectory(uploadsRootFolder);
                    }

                    var filePathDelete = Path.Combine(uploadsRootFolder, imageprofile.Path);
                    var fileInfo = new System.IO.FileInfo(filePathDelete);
                    fileInfo.Delete();
                }
            }

            return Redirect("/Admin/imageprofiles/Details");
        }

        private bool imageprofileExists(int id)
        {
            return _context.Imageprofiles.Any(e => e.Id == id);
        }
    }
}

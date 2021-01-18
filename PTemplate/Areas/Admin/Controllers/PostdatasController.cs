using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using PTemplate.Data;
using PTemplate.Data.DataBase;

namespace PTemplate.Areas.Admin.Controllers
{

    [Authorize(Roles = "Manager,Admin,Oprator")]
    [Area("Admin")]
    public class PostdatasController : Controller
    {
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public PostdatasController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/Postdatas
        public async Task<IActionResult> Index(long? id=0)
        {

            if (id==0)
            {            
                return Redirect("/Admin/Posts/Index");
            }


            //var po = await _context.Post.Include(p => p.IdmenuNavigation).Where(p => p.Idpost == id).FirstOrDefaultAsync();

            //if(po==null)
            //{
            //    return Redirect("/Admin/Posts/Index");
            //}

            List<Postdatum> applicationDbContext;
            if(id==0)
                applicationDbContext = await _context.Postdata.Include(p => p.IddatatypeNavigation).Include(p => p.IdpostNavigation).ToListAsync();
            else
                applicationDbContext = await _context.Postdata.Include(p => p.IddatatypeNavigation).Include(p => p.IdpostNavigation).Where(p=>p.Idpost==id).ToListAsync();

          


            ViewData["Idpost"] = id;
            ViewData["post"] = await _context.Posts
                .Include(p=>p.IdmenuNavigation)
                .Include(p=>p.IdposttoptypeNavigation)
                .Include(p=>p.IdposttypeNavigation)
                .Where(p => p.Id == id).FirstOrDefaultAsync();

            return View( applicationDbContext);
        }

        // GET: Admin/Postdatas/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postdata = await _context.Postdata
                .Include(p => p.IddatatypeNavigation)
                .Include(p => p.IdpostNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (postdata == null)
            {
                return NotFound();
            }

            return View(postdata);
        }

        // GET: Admin/Postdatas/Create
        public IActionResult Create(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            ViewData["Iddatatype"] = new SelectList(_context.Datatypes, "Id", "Name");
            ViewData["Idpost"] = new SelectList(_context.Posts.Where(a=>a.Id==id), "Id", "Title");
            return View();
        }

        // POST: Admin/Postdatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idpost,Iddatatype,Pathdata,Isactive,Description")] Postdatum postdata)
        {

            if (ModelState.IsValid)
            {
                _context.Add(postdata);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Postdatas/Index/" + postdata.Idpost);
            }

            ViewData["Iddatatype"] = new SelectList(_context.Datatypes, "Id", "Name", postdata.Iddatatype);
            ViewData["Idpost"] = new SelectList(_context.Posts, "Id", "Title", postdata.Idpost);

            return View(postdata);
        }

        // GET: Admin/Postdatas/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postdata = await _context.Postdata.FindAsync(id);
            if (postdata == null)
            {
                return NotFound();
            }
            ViewData["Iddatatype"] = new SelectList(_context.Datatypes, "Id", "Name", postdata.Iddatatype);
            ViewData["Idpost"] = new SelectList(_context.Posts, "Id", "Title", postdata.Idpost);
            return View(postdata);
        }

        // POST: Admin/Postdatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Idpost,Iddatatype,Pathdata,Isactive,Description")] Postdata postdata)
        {
            if (id != postdata.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postdata);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostdataExists(postdata.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return Redirect("/Admin/Postdatas/Index/" + postdata.Idpost);
              //  return RedirectToAction(nameof(Index), "Postdatas", postdata.Idpost);
            }
            ViewData["Iddatatype"] = new SelectList(_context.Datatypes, "Id", "Id", postdata.Iddatatype);
            ViewData["Idpost"] = new SelectList(_context.Posts, "Id", "Id", postdata.Idpost);
            return View(postdata);
        }

        // GET: Admin/Postdatas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postdata = await _context.Postdata
                .Include(p => p.IddatatypeNavigation)
                .Include(p => p.IdpostNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postdata == null)
            {
                return NotFound();
            }

            return View(postdata);
        }

        // POST: Admin/Postdatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var postdata = await _context.Postdata.FindAsync(id);
            _context.Postdata.Remove(postdata);
            await _context.SaveChangesAsync();
           
            //File
            try
            {
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads") + "/post/";
                var filePath = Path.Combine(uploadsRootFolder, postdata.Pathdata);
                var fileInfo = new System.IO.FileInfo(filePath);
           
                fileInfo.Delete();
            }
            catch { }
           
            return Redirect( "/Admin/Postdatas/Index/"+ postdata.Idpost);
        }

        

        private bool PostdataExists(long id)
        {
            return _context.Postdata.Any(e => e.Id == id);
        }


    }
}

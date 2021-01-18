using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTemplate.Areas.Admin.Data;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Models;
using PTemplate.Models.Enum;

namespace PTemplate.Areas.Admin.Controllers
{

    [Authorize(Roles = "Manager,Admin,Oprator")]
    [Area("Admin")]
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public PostsController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        public async Task<IActionResult> bot(long? id = 0)
        {

            if (id == 0)
            {
                return Redirect("/Admin/Posts/Index");
            }


            var product = await _context.Posts.Include(a => a.IdmenuNavigation).Where(a => a.Id == id).FirstOrDefaultAsync();
            if (product == null)
            {
                return Redirect("/Admin/Posts/Index");
            }

            var bot = _context.BotTelegrams.FirstOrDefaultAsync();
            if (bot == null)
            {
                ViewData["message"] = "اطلاعات روبات را چک کنید.";
                return View("bot", product);
            }
            if (bot.Result.Isactivediscription.Value)
                ViewData["discription"] = bot.Result.Description;
            else
                ViewData["discription"] = "";
            ViewData["message"] = "";
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> botmessage(long? id = 0, string message = "")
        {

            if (id == 0 || string.IsNullOrEmpty(message))
            {

                return Redirect("/Admin/Posts/Index");
            }
            ViewData["discription"] = "";
            var pro = await _context.Posts.Include(a => a.IdmenuNavigation).Where(a => a.Id == id).FirstOrDefaultAsync();

            if (pro == null)
            {
                return Redirect("/Admin/Posts/Index");
            }

            if (!(bool)pro.Isactive)
            {
                ViewData["message"] = "محصول فعال نیست";
                return View("bot", pro);
            }

            var data = await _context.Postdata.Where(p => p.Idpost == pro.Id && p.Iddatatype == (int)TypsImgesize.imgepluse && p.Isactive == true).OrderByDescending(a => a.Id).FirstOrDefaultAsync();

            if (data == null)
            {
                ViewData["message"] = "محصول عکس برای ارسال ندارد";
                return View("bot", pro);
            }

            var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads") + "/post/" + data.Pathdata;


            var bot = _context.BotTelegrams.FirstOrDefaultAsync();
            if (bot == null)
            {
                ViewData["message"] = "اطلاعات روبات را چک کنید.";
                return View("bot", pro);
            }

            try
            {

                if (bot.Result.Isactive.Value)
                {

                    string path = uploadsRootFolder; // All File Allowed : pdf, mp3, jpg ,...
                    string fileName = Path.GetFileName(path);
                    byte[] file = System.IO.File.ReadAllBytes(path);
                    if (botTellegram.SendFileToChannel_bot(file, fileName, bot.Result.Token, "@" + bot.Result.Namechanale))
                    {
                        botTellegram.message_bot(message, bot.Result.Token, "@" + bot.Result.Namechanale);
                    }

                }
                else
                {
                    ViewData["message"] = "ربات غیر فعال است.";
                    return View("bot", pro);
                }
            }
            catch
            {
                ViewData["message"] = "خطا در ارسال دوباره تلاش کنید.";
                return View("bot", pro);

            }

            ViewData["message"] = "مطلب با موفقیت ارسال شد";
            return View("bot", pro);
        }


        // GET: Admin/Posts
        public async Task<IActionResult> Index(long? Idmenu,int? paging)
        {

           
          var applicationDbContext= (Idmenu == null || Idmenu==0) ? 
            _context.Posts
            .Include(p => p.IdmenuNavigation)
            .Include(p => p.IdposttypeNavigation)
            .OrderByDescending(a=>a.Datecreate)
            .OrderByDescending(a=>a.Datecreate)

           : 
           _context.Posts.Where(p=>p.Idmenu== Idmenu)
           .Include(p => p.IdmenuNavigation)
           .Include(p => p.IdposttypeNavigation)
           .OrderByDescending(a => a.Datecreate)
           .OrderByDescending(a => a.Datecreate);

            if (paging == null)
                paging = 1;
            
            var b = applicationDbContext.GetPaged<Post>((int)paging, 20);
            //ViewBag.Paging = Set_Paging((int)paging, 10, b.RowCount, "activeLink", Url.Action("Index", "Paging"), "disableLink");
            return View(b);
        }

        // GET: Admin/Posts/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.IdmenuNavigation)
                .Include(p => p.IdposttypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Admin/Posts/Create
        public IActionResult Create()
        {
            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "Name");
            ViewData["Idposttype"] = new SelectList(_context.Posttypes, "Id", "Name");
            ViewData["Idposttoptype"] = new SelectList(_context.Posttoptypes, "Id", "Name");
            return View();
        }

        // POST: Admin/Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Iduser,Idposttype,Idposttoptype,Idmenu,Title,Description,Text,Pathdata,Datecreate,Isactive,Iswrite,Datestart")] Post post)
        {

            if (post != null)
                if (!string.IsNullOrEmpty(post.Title)   && !string.IsNullOrEmpty(post.Description) && post.Datestart!=null)
                {
                    var id = User.FindFirst(ClaimTypes.NameIdentifier).Value;

                 
                    post.Iduser = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    post.Datecreate = DateTime.Now;
                    _context.Add(post);
                    await _context.SaveChangesAsync();
                    return Redirect("/Admin/Posts/Index");
                }

            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "name", post.Idmenu);
            ViewData["Idposttype"] = new SelectList(_context.Posttypes, "Id", "name", post.Idposttype);
            ViewData["Idposttoptype"] = new SelectList(_context.Posttypes, "Id", "name", post.Idposttoptype);

            return View(post);
        }

        // GET: Admin/Posts/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "Name", post.Idmenu);
            ViewData["Idposttype"] = new SelectList(_context.Posttypes, "Id", "Name", post.Idposttype);
            ViewData["Idposttoptype"] = new SelectList(_context.Posttoptypes, "Id", "Name", post.Idposttoptype);
            return View(post);
        }  
        
      

        // POST: Admin/Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Iduser,Idposttype,Idposttoptype,Idmenu,Title,Description,Text,Pathdata,Datecreate,Isactive,Iswrite,Datestart")] Post post)
        {

            if (id != post.Id)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    var po =  _context.Posts.Where(a=>a.Id==id).AsNoTracking().First();
                 //   post.Id = id;
                    post.Iduser =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    post.Datecreate = po.Datecreate; 
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Posts/Index");
            }


            ViewData["Idmenu"] = new SelectList(_context.Menus, "Id", "Description", post.Idmenu);
            ViewData["Idposttype"] = new SelectList(_context.Posttypes, "Id", "Description", post.Idposttype);
            return View(post);


        }

        // GET: Admin/Posts/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.IdmenuNavigation)
                .Include(p => p.IdposttypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Admin/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Posts/Index");
        }

        private bool PostExists(long id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}

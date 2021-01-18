using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using PTemplate.Models;
using PTemplate.Models.DataViewModel;
using PTemplate.Models.Enum;



namespace PTemplate.Areas.Admin.Controllers
{
    [Authorize(Roles = "Manager,Admin")]
    [Area("Admin")]
   
    public class ProductsController : Controller
    {
        [Obsolete]
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public ProductsController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        public async Task<IActionResult> bot(long? id = 0)
        {

            if (id == 0)
            {
                return Redirect("/Admin/Products/Index");
            }


            var product = await _context.Products.Include(a => a.IdmenuNavigation).Where(a => a.Id == id).FirstOrDefaultAsync();
            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
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
        public async Task<IActionResult> botmessage(long? id=0 ,string message="")
        {

            if (id == 0 || string.IsNullOrEmpty( message))
            {

                return Redirect("/Admin/Products/Index");
            }

            ViewData["discription"] = "";
            var pro = await _context.Products.Include(a => a.IdmenuNavigation).Where(a => a.Id == id).FirstOrDefaultAsync();

            if (pro == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            if (!(bool)pro.Isactive)
            {
                ViewData["message"] = "محصول فعال نیست";
                return View("bot", pro);
            }

            var data =await _context.Productdata.Where(p => p.Idproduct == pro.Id && p.Iddatatype == (int)TypsImgesize.imgepluse && p.Isactive==true).OrderByDescending(a=>a.Id).FirstOrDefaultAsync();

            if(data==null)
            {
                ViewData["message"] = "محصول عکس برای ارسال ندارد";
                return View("bot", pro);
            }

            var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads") + "/product/" + data.Pathdata;

            var bot = _context.BotTelegrams.FirstOrDefaultAsync();

            if(bot==null)
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
                    if (botTellegram.SendFileToChannel_bot(file, fileName, bot.Result.Token,"@"+ bot.Result.Namechanale))
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
            catch {
                ViewData["message"] = "خطا در ارسال دوباره تلاش کنید.";
                return View("bot", pro);

    }

            ViewData["message"] = "مطلب با موفقیت ارسال شد";
            return View("bot", pro);

        }

        // GET: Admin/Products
        public async Task<IActionResult> Index(long? Idmenu=0, int? paging=1)
        {
            var applicationDbContext = (Idmenu == null || Idmenu == 0)?
         _context.Products
         .Include(p => p.IdmenuNavigation)
         .OrderByDescending(a => a.Datecreate)
         .OrderByDescending(a => a.Datecreate)
        :
        _context.Products.Where(p => p.Idmenu == Idmenu)
        .Include(p => p.IdmenuNavigation)

        .OrderByDescending(a => a.Datecreate)
        .OrderByDescending(a => a.Datecreate);


            if (paging == null)
                paging = 1;

            // var b = applicationDbContext.GetPaged<Product>((int)paging, 20);

            ViewData["PageSize"] = 1; //b.PageSize;
            ViewData["PageCount"] = 5;// b.PageCount;
            ViewData["CurrentPage"] =1;// b.CurrentPage;
            ViewData["FirstRowOnPage"] = 1;// b.FirstRowOnPage;

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();


            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name");

            return View(applicationDbContext);
        }



        // GET: Admin/Products
        public async Task<IActionResult> banner(long? Idmenu = 0, int? paging = 1)
        {

            //var mg = _context.Menugroup.Where(b => b.Istype == true).ToList();
            var applicationDbContext = (Idmenu == null || Idmenu == 0) ?
            _context.Productdata
            .Include(p => p.IddatatypeNavigation).Include(p => p.IdproductNavigation)
            .Where(p => p.Iddatatype == (int)TypsImgesize.banner && p.Isactive == true)
            .OrderByDescending(a => a.Datecreate)
            .OrderByDescending(a => a.Datecreate) : 
           _context.Productdata
           .Include(p => p.IddatatypeNavigation)
           .Include(p => p.IdproductNavigation)
            .Where(p => p.Iddatatype == (int)TypsImgesize.banner && p.Isactive == true && _context.Products.Any(m => m.Idmenu == Idmenu && m.Id == p.Id))
            .OrderByDescending(a => a.Datecreate)
            .OrderByDescending(a => a.Datecreate);

            if (paging == null)
                paging = 1;

            //  var b = applicationDbContext.GetPaged<Product>((int)paging, 20);

            //ViewData["PageSize"] = b.PageSize;
            //ViewData["PageCount"] = b.PageCount;
            //ViewData["CurrentPage"] = b.CurrentPage;
            //ViewData["FirstRowOnPage"] = b.FirstRowOnPage;

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();


            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name");

            return View(applicationDbContext);
        }


        // GET: Admin/Products
        public async Task<IActionResult> slider(long? Idmenu = 0, int? paging = 1)
        {

            //var mg = _context.Menugroup.Where(b => b.Istype == true).ToList();
            var applicationDbContext = (Idmenu == null || Idmenu == 0)
            ?
            _context.Productdata
            .Include(p => p.IddatatypeNavigation).Include(p=>p.IdproductNavigation)
            .Where(p=>p.Iddatatype==(int) TypsImgesize.Slider && p.Isactive==true)

            .OrderByDescending(a => a.Datecreate)
            .OrderByDescending(a => a.Datecreate)

           :
           _context.Productdata.Include(p => p.IddatatypeNavigation).Include(p => p.IdproductNavigation)
            .Where(p => p.Iddatatype == (int)TypsImgesize.Slider && p.Isactive == true && _context.Products.Any(m=>m.Idmenu==Idmenu && m.Id==p.Id ))
           .OrderByDescending(a => a.Datecreate)
           .OrderByDescending(a => a.Datecreate);

            if (paging == null)
                paging = 1;

          //  var b = applicationDbContext.GetPaged<Product>((int)paging, 20);

            //ViewData["PageSize"] = b.PageSize;
            //ViewData["PageCount"] = b.PageCount;
            //ViewData["CurrentPage"] = b.CurrentPage;
            //ViewData["FirstRowOnPage"] = b.FirstRowOnPage;

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();


            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name");

            return View(applicationDbContext);
        }


        [HttpGet]
        public async Task<IActionResult> ProductsDataPost(long? id=0)
        {


            if (id == null || id == 0)
            {
                return Redirect("/Admin/Products/Index");
            }

            var up = new UploadViewModel();
            up.idpost = id.ToString();

            var pro= await _context.Products.Include(a=>a.IdmenuNavigation)
                .Where(p => p.Id == id).FirstOrDefaultAsync();

            if(pro==null)
            {
                return Redirect("/Admin/Products/Index");
            }

            ViewData["product"] = pro;
            ViewData["Datatype"] = new SelectList(_context.Productdatatypes, "Id", "Name");


            return View(up);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductsDataPost(UploadViewModel files)
        {
            if (ModelState.IsValid)
            {
                var formFile = files.Photo;
                if (formFile == null || formFile.Length == 0)
                {
                    ModelState.AddModelError("", "فایل ارسالی خالی می باشد.");
                    return View(viewName: "Index");
                }

                
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads")+ "/product/";
                if (!Directory.Exists(uploadsRootFolder ))
                {
                    Directory.CreateDirectory(uploadsRootFolder );
                }

                string namefile = new Random().Next(200, 900).ToString()+DateTime.Now.Year+ DateTime.Now.Month+ DateTime.Now.Day+"_"+ DateTime.Now.Hour+"_"+ DateTime.Now.Minute + Path.GetExtension(formFile.FileName) ;

                var filePath = Path.Combine(uploadsRootFolder, namefile);


                UploadViewModel.Image_resize(formFile.OpenReadStream(), filePath, (TypsImgesize)(int.Parse(files.Iddatatype)));


                if(int.Parse(files.Iddatatype)== (int)TypsImgesize.imgepluse)
                {
                     filePath = Path.Combine(uploadsRootFolder, "350_"+namefile);
                    UploadViewModel.Image_resize(formFile.OpenReadStream(), filePath, TypsImgesize.imgepluseSmale);

                }

                //using (Image<Rgba32> image = Image.Load(filePath))
                //{
                //    image.Mutate(x => x
                //         .Resize(image.Width / 2, image.Height / 2)
                //         .Grayscale());

                //    image.Save(filePath); // Automatic encoder selected based on extension.
                //}

                //using (var fileStream = new FileStream(filePath, FileMode.Create))
                //{
                //    await formFile.CopyToAsync(fileStream).ConfigureAwait(false);
                //}

                // _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT store.productdata ON");
                Productdatum pu = new Productdatum();
             //   pu.Id = null;
                pu.Idproduct =long.Parse( files.idpost);
                pu.Iddatatype = byte.Parse(files.Iddatatype);
                pu.Pathdata = namefile;
                pu.Description = files.description;
                pu.Isactive = files.isActive;

                _context.Productdata.Add(pu);

                await  _context.SaveChangesAsync();
             //   _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT store.productdata OFF");
                return Redirect("/Admin/Products/ProductDataIndex/" + files.idpost);
               
            }

            return Redirect("/Admin/Products/Index");


        }

        [Obsolete]
        public async Task<IActionResult> ProductDataIndex(long? id = 0)
        {

            if (id == 0)
            {
                return Redirect("/Admin/Products/Index");
            }


            //var po = await _context.Post.Include(p => p.IdmenuNavigation).Where(p => p.Idpost == id).FirstOrDefaultAsync();

            //if(po==null)
            //{
            //    return Redirect("/Admin/Posts/Index");
            //}

            List<Productdatum> applicationDbContext;
            if (id == 0)
                applicationDbContext = await _context.Productdata
                    .Include(p => p.IddatatypeNavigation)
                    .Include(p => p.IdproductNavigation)
                    .ToListAsync();
            else
                applicationDbContext =  _context.Productdata
                    .Include(p => p.IddatatypeNavigation)
                    .Include(p => p.IdproductNavigation)
                    .Where(p => p.Idproduct == id)
                    .ToList();




            ViewData["IdProduct"] = id;
            ViewData["Product"] = await _context.Products.
                 Include(p => p.IdmenuNavigation)
                .Where(p => p.Id == id).FirstOrDefaultAsync();

            return View(applicationDbContext);

        }


        // GET: Admin/Postdatas/Delete/5
        public async Task<IActionResult> ProductdatasDelete(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/Products/ProductDataIndex/"+ id);
            }

            var postdata = await _context.Productdata
                .Include(p => p.IddatatypeNavigation)
                .Include(p => p.IdproductNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postdata == null)
            {
                return Redirect("/Admin/Products/ProductDataIndex/" + id);
            }

            return View(postdata);
        }


        // POST: Admin/Postdatas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductdatasDelete(long id)
        {
            var postdata = await _context.Productdata.FindAsync(id);
            _context.Productdata.Remove(postdata);
            await _context.SaveChangesAsync();

            //File
            try
            {
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads") + "/product/";
                var filePath = Path.Combine(uploadsRootFolder, postdata.Pathdata);
                var fileInfo = new System.IO.FileInfo(filePath);

                fileInfo.Delete();


                if(postdata.Iddatatype==(int)TypsImgesize.imgepluse)
                {
                    var uploadsRootFolder1 = Path.Combine(_environment.WebRootPath, "uploads") + "/product/";
                    var filePath1 = Path.Combine(uploadsRootFolder, "350_"+postdata.Pathdata);
                    var fileInfo1 = new System.IO.FileInfo(filePath1);

                    fileInfo1.Delete();
                }
            }
            catch { }

            return Redirect("/Admin/Products/ProductDataIndex/" + postdata.Idproduct);
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.IdmenuNavigation)
               
                .FirstOrDefaultAsync(m => m.Id == id);

            
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();

            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name");

          //ViewData["Idpost"] = new SelectList(_context.Post, "Id", "Title");

            return View();

        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create([Bind("Id,Idmenu,Price,Datecreate,Isactive,Description,Title,Text,Moneypost")] ProductInsert product)
        {

            if (ModelState.IsValid)
            {
               
                product.iduser = User.FindFirst(ClaimTypes.NameIdentifier).Value;
               
                var result = (await _context.sp_productinsert(product)).FirstOrDefault();

                if (result != null)
                {
                    if (result.idcode == 1)
                    {
                        return Redirect("/Admin/Products/Index");
                    }
                }
            }

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();


            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name", product.Idmenu);
           
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductDataDeAactive(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            var product = await _context.Productdata.FindAsync(id);
            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            product.Isactive = false;
            _context.Productdata.Update(product);
            _context.SaveChanges();
            
            return Redirect("/Admin/Products/slider/" + product.Idproduct);

         //   return View(product);
        }

        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }
            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();

            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name", product.Idmenu);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Idmenu,Price,Datecreate,Isactive,Description,Title,Text,Moneypost")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var pro = await _context.Products.FindAsync(id);
                    pro.Idmenu = product.Idmenu;
                    pro.Isactive = product.Isactive;
                    pro.Moneypost = product.Moneypost;
                    pro.Price = product.Price;
                    pro.Description = product.Description;
                    pro.Text = product.Text;
                    pro.Title = product.Title;

                    _context.Update(pro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Products/Index");
            }

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();

            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name", product.Idmenu);

            return View(product);
        }



        public async Task<IActionResult> Editpost(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            //var post = await _context.Post.FindAsync(id);
            //if (post == null)
            //{
            //    return Redirect("/Admin/Products/Index");
            //}



            var product = await _context.Products
             .Include(p => p.IdmenuNavigation)
             
             .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            ViewData["product"] = product;

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();

            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name", product.Idmenu);
            //ViewData["Idposttype"] = new SelectList(_context.Posttype, "Id", "Name", post.Idposttype);
            //ViewData["Idposttoptype"] = new SelectList(_context.Posttoptype, "Id", "Name", post.Idposttoptype);

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editpost(long id, [Bind("Id,Iduser,Idmenu,Title,Description,Text,Pathdata,Datecreate,Isactive")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    post.Iduser = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    post.Datecreate = DateTime.Now;
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!PostExists(post.Id))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }

            var mg = _context.Menugroups.Where(b => b.Istype == true).ToList();

            var ss = _context.Menus.AsEnumerable().Where(m => mg.Any(meg => (long)meg.Id == (long)m.Id)).ToList();

            ViewData["Idmenu"] = new SelectList(ss, "Id", "Name", post.Idmenu);
            ViewData["Idposttype"] = new SelectList(_context.Posttypes, "Id", "Name", post.Idposttype);
            return View(post);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            ViewData["messge"] = "";

            var product = await _context.Products
                .Include(p => p.IdmenuNavigation)
               
                .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return Redirect("/Admin/Products/Index");
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var product = await _context.Products
               
                .Include(a=>a.IdmenuNavigation)
                .Where(a=>a.Id==id).FirstOrDefaultAsync();
            try
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                List<Productdatum> data = await _context.Productdata.Where(po => po.Idproduct == product.Id).ToListAsync();
                try
                {
                    foreach (var i in data)
                    {
                        var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "uploads") + "/product/";
                        var filePath = Path.Combine(uploadsRootFolder, i.Pathdata);
                        var fileInfo = new System.IO.FileInfo(filePath);
                        fileInfo.Delete();
                    }



                }
                catch { }
            }
            catch {
                ViewData["messge"] = "این کالا به دلیل موجود اقلام فروشی در سبد خرید امکان حذف ندارد اگر مایل هستید آن را غیر فعال کنید";
                return View("Delete", product);
            }





            return Redirect("/Admin/Products/Index");
        }

        private bool ProductExists(long id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Data.DB;
using PTemplate.Models;
using PTemplate.Models.DataViewModel;
using PTemplate.Models.Enum;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace PTemplate.Controllers
{
   
    public class cbkalaController : Controller
    {

        ApplicationDbContext _context;

        public cbkalaController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }

        [HttpGet]
        public JsonResult AutoCompleteName(string filter_name)
        {

            var customers = _context.sp_productsubmenucompletelist(filter_name);

            return Json(customers);
        }

        [HttpPost]
        public JsonResult AutoComplete(AutoModel auto)
        {

            var customers = _context.sp_productsubmenucompletelist(auto.Name);

            return Json(customers);
        }

        public IActionResult UpdateProduct(string idsubfactor,long? idproduct=0,int? countsefaresh=0,long? idproductcolor=0)
        {

            if (string.IsNullOrEmpty(idsubfactor))
                return new JsonResult(".انتخاب نا معتبر است");

            if(idproduct==0|| countsefaresh==0|| idproductcolor==0)
                return new JsonResult("انتخاب نا معتبر است.");


            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var dbv = _context.sp_subfactorupdate(userId, idsubfactor,(long) idproduct, (int)countsefaresh, (long)idproductcolor);

            if (dbv.idcode == 2 || dbv.idcode == 0)
                return new JsonResult(dbv.message);


            return new JsonResult("Yes");
        }

        public IActionResult DeleteProduct(string idsubfactor )
        {

            if (string.IsNullOrEmpty( idsubfactor))
                return new JsonResult("انتخاب نا معتبر است");

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

           


            var dbv = _context.sp_subfactordelete(userId, idsubfactor);

            if (dbv.idcode == 2)
                return new JsonResult(dbv.message);


            return new JsonResult("Yes");
        }

        public  IActionResult insertProduct(long? idptoduct = 0, int? count = 0, int? idcolor = 0)
        {

            if (count <= 0 || idcolor <= 0 || idptoduct <= 0)
                return new JsonResult("انتخاب نا معتبر است");

            var Pro = _context.Products
                .Where(p => p.Id == idptoduct)
                .FirstOrDefault();

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(userId==null)
                return new JsonResult("وارد سامانه شوید و اگر هنوز عضو از ما نیست به ما بپوندید (عضو شوید)");

            var dbv= _context.sp_subfactorinsert(userId  , Pro.Id, (int)count, (long)idcolor);

            if(dbv.idcode==2)
                return new JsonResult(dbv.message);


            return new JsonResult("Yes");
        }

        public async Task<IActionResult> Index()
        {
            StoryViewModel storyViewModel = new StoryViewModel();
            storyViewModel.biner = _context.sp_productbannerlatest();
           

            storyViewModel.Sliders = _context.sp_productsliderlatestlist().Result;
            storyViewModel.lastproducts = _context.sp_productlatestlist(12);
            storyViewModel.products = _context.sp_productalllist(1,20,null,null).Result;
            if(User.Identity.IsAuthenticated)
            {  
                var iduser = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                storyViewModel.subfactors = _context.sp_subfactorlist(iduser).Result;
                foreach (var i in storyViewModel.subfactors)
                {
                    storyViewModel.sumsubfactor += i.factorsubmoney * i.countfactorsub;
                    storyViewModel.sumoffer += i.offpercent * i.countfactorsub;
                }
            }

            var menu = storyViewModel.menus = await _context.Menugroups.Include(m => m.Menus).Where(a => a.Istype == true)
                .ToListAsync();

            return View(storyViewModel);

        }

        public async Task< IActionResult> Product(int? id=0)
        {

            if(id==0)
            {
                return Redirect("/error/Index/106769");
            }

            productViewModel productView = new productViewModel();

            productView.product = _context.Products
                
                .Include(p=>p.IdmenuNavigation)
                .Where(p => p.Id == id).FirstOrDefault();

            if (productView.product == null)
            {
                return Redirect("/error/Index/106769");
            }

            productView.postdatas =await _context.Productdata.Where(pd => pd.Idproduct == id).ToListAsync();
            productView.procolor =await _context.Productcolors.Include(p=>p.IdcolorNavigation).Where(pd => pd.Idproduct == productView.product.Id).ToListAsync();
            productView.productinfo =await _context.Productinfos.Include(p=>p.IdproductmenuinfoNavigation).Where(pd => pd.Idproduct == productView.product.Id).ToListAsync();

            return View(productView);
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout(int id=0)
        {
            if (id==0)
            {
                return Redirect("/cbkala/Cart");
            }
           
            if(id== (int)sendposttype.postBus)
            {
                ViewData["posttype"] = (int)sendposttype.postBus;
            }
            else
            {
                ViewData["posttype"] = (int)sendposttype.postPishtaz;
            }
           

            return View();
        }

        public async Task<IActionResult> Category(int page = 1, long count = 0, long group = 0, long menu = 0, int maxmoney = 2, int minmoney = 2, int isactiveproduct = 2, string name = "")
        {

            if (count == 0)
            {
                count = 20;
            }

            bool? maxminpro = false, isactivepro = false;

            ViewData["minmoney"] = minmoney;

            ViewData["maxmoney"] = maxmoney;
            ViewData["isactiveproduct"] = isactiveproduct;
            @ViewData["menu"] = menu;

            if (isactiveproduct == 1)
            {
                isactivepro = true;
            }
            else
            {
                isactivepro = null;
            }

            if (maxmoney == 1)
            {
                maxminpro = true;
                ViewData["maxmoney"] = 1;
                ViewData["minmoney"] = 0;
            }
            else
            if (minmoney == 1)
            {
                maxminpro = false;
                ViewData["maxmoney"] = 0;
                ViewData["minmoney"] = 1;
            }
            else
            {
                ViewData["maxmoney"] = 0;
                ViewData["minmoney"] = 0;
                maxminpro = null;
            }

            //if (isactiveproduct == 2)
            //{
            //    ViewData["isactiveproduct"] = 0;
            //}



            catagoryProsuryViewModel catagory = new catagoryProsuryViewModel();

            if (group!=0)
            {
                catagory.products = await _context.sp_productbygrouplist(1, count, isactivepro, maxminpro, group);
            }
            else if(!string.IsNullOrEmpty(name))
            {
                catagory.products = await _context.sp_productbynamelist(1, count, isactivepro, maxminpro, name);
            }
            else if (menu == 0)
                catagory.products = await _context.sp_productalllist(1, count, isactivepro , maxminpro);
            else
                catagory.products = await _context.sp_productallwithmenulist(menu, page, count,  isactivepro, maxminpro);

            //var bb= catagory.products.Get

            ViewData["menu"] = menu;
            catagory.menugroups = await _context.Menugroups.Include(m => m.Menus).Where(a => a.Istype == true)
                .ToListAsync();

            var pro = catagory.products.FirstOrDefault();
            if (pro == null)
            {
                ViewData["PageSize"] = 1;
                ViewData["PageCount"] = 1;
                ViewData["CurrentPage"] = 1;
                ViewData["FirstRowOnPage"] = 1;
            }
            else
            {
                var co = pro.totalrows / count;
                if (co == 0)
                    co = 1;
                ViewData["PageSize"] = co;
                ViewData["PageCount"] = co;
                ViewData["CurrentPage"] = page;
                ViewData["FirstRowOnPage"] = 1;
            }

            return View(catagory);
        }
    
        public IActionResult Contactus()
        {
            return View();
        }

        public IActionResult Howtoorder()
        {
            return View();
        }

        public IActionResult Howtopay()
        {
            return View();
        }

        public IActionResult Howtosendorder()
        {
            return View();
        }

        public IActionResult policy()
        {
            return View();
        }

        public IActionResult privacy()
        {
            return View();
        }

        public IActionResult questions()
        {
            return View();
        }

        public IActionResult error(int? code = 0)
        {
            ViewData["code"] = code;
            return View();
        }

    }
}
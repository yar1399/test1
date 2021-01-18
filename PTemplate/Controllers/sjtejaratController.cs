using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Models;
using PTemplate.Models.DataViewModel;
using PTemplate.Models.JobTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PTemplate.Models.JobTime;

namespace PTemplate.Controllers
{
    public class sjtejaratController : Controller
    {


        private readonly ApplicationDbContext _context;

        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public sjtejaratController(ApplicationDbContext context, IHostingEnvironment environment)
        {

            _environment = environment;
            _context = context;


        


        }


        public IActionResult Index( int paging = 1)
        {

            MaindadarasViewModel mainView = new MaindadarasViewModel();
            //PagedResult<Post> PostRe;

            /* if (idmenu == 0)
             {

                 PostRe = _context.Post.OrderByDescending(a=>a.Datecreate).GetPaged<Post>((int)paging, 10);
             }
             else
             {
                 PostRe = _context.Post.Where(p => (long)p.Idmenu == idmenu).OrderByDescending(a => a.Datecreate).GetPaged<Post>((int)paging, 10);
             }*/

            mainView.ListPost = _context.sp_postgetPostPageing(paging,20); //PostRe.Results.ToList();

            int pco = mainView.ListPost.Count == 0 ? 1 : mainView.ListPost.Count / 20 <= 0 ? 1 : mainView.ListPost.Count / 20;

            ViewData["idmenu"] = 0;
            ViewData["paging"] = paging;
            ViewData["PostRe"] = pco;

            //PostRe.PageCount
            mainView.menugroup = _context.Menugroups.ToList();

            //mainView.ListPostVideo = _context.sp_postgetVIdeo();
            //mainView.ListPostMusic = _context.sp_postgetMuscic();

            mainView.ListPostTopSlide = _context.sp_postgetSlide();
            mainView.ListPostpadkast = _context.sp_postgetPadKast();

            //mainView.ListPostImageText = _context.sp_postgetImageText(); 
            mainView.ListPostnews = _context.sp_postgetNews();

            //_context.Post.Where(p => (long)p.Idposttype == (byte)Posts.post ||
            //            (long)p.Idposttype == (byte)Posts.gifandMatch ||
            //            (long)p.Idposttype == (byte)Posts.messageweb ||
            //            (long)p.Idposttype == (byte)Posts.pakagetotrial ||
            //            (long)p.Idposttype == (byte)Posts.semenar ||
            //            (long)p.Idposttype == (byte)Posts.Workshop).OrderByDescending(a => a.Datecreate).Skip(0).Take(10).ToList();
                     

            return View(mainView);
        }


        public IActionResult singlepost(int? id = 0)
        {
            Post post = null;
            List<Postdatum> postDatas = null;
            if (id != 0)
            {
                post = _context.sp_postget((long)id).FirstOrDefault();
            }

            if (post != null)
            {

                postDatas = _context.Postdata.Where(p => p.Idpost == id && p.Isactive == true).ToList();

                string st = DateTime.Now.ToString();
                _context.sp_poststatisticsADD((long)id);
                ViewData["titlepost"] = post.Title;
                ViewData["title"] = post.Title;

            }
            else
            {
                return Redirect("/dadras/index");
            }





            return View(new singlepostViewModel(post, postDatas));

        }
        public IActionResult singlevideo()
        {
            return View();
        }
        public IActionResult archive(int idmenu = 0, int paging = 1)
        {
            var me = _context.Menus.Where(p => p.Id == idmenu).FirstOrDefault();
            if (me != null)
            {
                ViewData["nameMenu"] = me.Name;
            }
            else
            {
                ViewData["nameMenu"] = "همه تکه های برش دانایی";
                idmenu = 0;
            }

            Postarchive mainView = new Postarchive();
            PagedResult<Post> PostRe;

            if (idmenu == 0)
            {
                PostRe = _context.sp_postgetPostMenuall().GetPaged<Post>((int)paging, 10);  //_context.Post.GetPaged<Post>((int)paging, 10);
            }
            else
            {
                PostRe = _context.sp_postgetPostMenuid((long)idmenu).GetPaged<Post>((int)paging, 10); //_context.Post.Where(p => (long)p.Idmenu == idmenu).GetPaged<Post>((int)paging, 10);
            }

            mainView.post = PostRe.Results.ToList();

            ViewData["idmenu"] = idmenu;
            ViewData["paging"] = paging;
            ViewData["PostRe"] = PostRe.PageCount;

            return View(mainView);
        }

        public IActionResult about()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        public IActionResult policy()
        {
            return View();
        }
    }
}

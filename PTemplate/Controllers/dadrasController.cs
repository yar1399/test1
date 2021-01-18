using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PTemplate.Areas.Admin.Data;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Models;
using PTemplate.Models.Data.DBSatare;
using PTemplate.Models.DataViewModel;
using PTemplate.Models.Enum;

namespace PTemplate.Controllers
{
    public class dadrasController : Controller
    {
        private readonly ApplicationDbContext _context;

        [Obsolete]
        private readonly IHostingEnvironment _environment;


      
        public dadrasController(ApplicationDbContext context, IHostingEnvironment environment)
        {

            _environment = environment;
            _context = context;

        }


        public IActionResult Index(int idmenu = 0, int paging = 1)
        {

            MaindadarasViewModel mainView = new MaindadarasViewModel();
            PagedResult<Post> PostRe;

           /* if (idmenu == 0)
            {
              
                PostRe = _context.Post.OrderByDescending(a=>a.Datecreate).GetPaged<Post>((int)paging, 10);
            }
            else
            {
                PostRe = _context.Post.Where(p => (long)p.Idmenu == idmenu).OrderByDescending(a => a.Datecreate).GetPaged<Post>((int)paging, 10);
            }*/

            mainView.ListPost = _context.sp_postgetPost(); //PostRe.Results.ToList();

            ViewData["idmenu"] = idmenu;
            ViewData["paging"] = paging;
            ViewData["PostRe"] = mainView.ListPost;


            mainView.menugroup = _context.Menugroups.ToList();

            mainView.ListPostVideo = _context.sp_postgetVIdeo(); //_context.Post.Where(p => (long)p.Idposttype == (byte)Posts.video).OrderByDescending(a => a.Datecreate).Skip(0).Take(10).ToList();
            mainView.ListPostMusic = _context.sp_postgetMuscic();// _context.Post.Where(p => (long)p.Idposttype == (byte)Posts.music).OrderByDescending(a => a.Datecreate).Skip(0).Take(10).ToList();
           
            mainView.ListPostTopSlide = _context.sp_postgetSlide(); // _context.Post.Where(p => p.Idposttoptype == 2).Skip(0).Take(13).OrderByDescending(a => a.Datecreate).ToList();
            mainView.ListPostpadkast = _context.sp_postgetPadKast(); // _context.Post.Where(p => p.Idposttype == (byte)Posts.padkast).OrderByDescending(a => a.Datecreate).Skip(0).Take(10).ToList();

            mainView.ListPostImageText = _context.sp_postgetImageText();  //_context.Post.Where(p => (long)p.Idposttype == (byte)Posts.textimage).OrderByDescending(a => a.Datecreate).Skip(0).Take(10).ToList();
            mainView.ListPostnews = _context.sp_postgetNews();

                /*.Post.Where(p => (long)p.Idposttype == (byte)Posts.post ||
                            (long)p.Idposttype == (byte)Posts.gifandMatch ||
                            (long)p.Idposttype == (byte)Posts.messageweb ||
                            (long)p.Idposttype == (byte)Posts.pakagetotrial ||
                            (long)p.Idposttype == (byte)Posts.semenar ||
                            (long)p.Idposttype == (byte)Posts.Workshop).OrderByDescending(a => a.Datecreate).Skip(0).Take(10).ToList();
                            */

            return View(mainView);
        }


        public IActionResult singlepost(int? id=0)
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

            }else
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
            if (me!=null)
            {
                ViewData["nameMenu"] = me.Name;
            }
            else {
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
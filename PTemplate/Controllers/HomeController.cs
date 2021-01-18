using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PTemplate.Areas.Admin.Data;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using PTemplate.Models;
using PTemplate.Models.DataViewModel;
using PTemplate.Models.Enum;

namespace PTemplate.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public HomeController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            //string fromaddr = "reza.jamali3@gmail.com";
            //string toaddr = "reza.jamali3@yahoo.com";//TO ADDRESS HERE
            //string password = "hikqzbkyalijnjao";

            //MailMessage msg = new MailMessage();
            //msg.Subject = "Username &password";
            //msg.From = new MailAddress(fromaddr);
            //msg.Body = "Message BODY";
            //msg.To.Add(new MailAddress("reza.jamali3@yahoo.com"));
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtp.gmail.com";
            //smtp.Port = 587;
            //smtp.UseDefaultCredentials = false;
            //smtp.EnableSsl = true;
            //NetworkCredential nc = new NetworkCredential(fromaddr, password);
            //smtp.Credentials = nc;
            //smtp.Send(msg);


            _environment = environment;
            _context = context;
        }


        public IActionResult bita()
        {
           
            return View();
        }

        public IActionResult Index(int idmenu=0,int paging = 1)
        {
            MainViewModel mainView = new MainViewModel();
            PagedResult<Post> PostRe;
            if (idmenu == 0)
            {
                PostRe = _context.Posts.GetPaged<Post>((int)paging, 10);
            }
            else
            {
                 PostRe = _context.Posts.Where(p => (long)p.Idmenu == idmenu).GetPaged<Post>((int)paging, 10);
            }
            mainView.ListPost = PostRe.Results.ToList();
            ViewData["idmenu"] = idmenu;
            ViewData["paging"] = paging;
            ViewData["PostRe"] = PostRe;
            mainView.menugroup = _context.Menugroups.ToList();
            mainView.ListPostVideo = _context.Posts.Where(p => (long)p.Idposttype == (byte)Posts.video).Skip(0).Take(10).ToList();
            mainView.ListPostImageText = _context.Posts.Where(p => (long)p.Idposttype == (byte)Posts.textimage).Skip(0).Take(10).ToList();
            return View(mainView);
        }

        public IActionResult About()
        {
            //  ViewData["Message"] = "YARViewer نرم افزاری برای مدیریت آسان رایانه از راه دور است که به دلیل تحریم نرم افزار ی  Team Viewer که در شرکتها و گروه های پشتبانی نرم افزاری و مدیریتی  در کشور عزیزمان داری محبوبیت بالایی برخوردار بود باعث مشکلات و بالا رفتن هزینه ها و کاهش فروش در پشتبانی و ضعف در حمایت از پشتیبانی از راه دور در نرم افزار های ایرانی شد شرکت نرم افزاری یارایران خلیج فارس به عنوان شرکت نرم افزاری با سرمایه گذاری شرکت پردازش گر کهن اقدام به تولید نرم افزاری شایسته و کاربردی در این زمینه شده است . "

            return View();
        }

        public IActionResult policy()
        {
            return View();
        }


        public IActionResult Contact()
        {
            ContactViewModel contact = new ContactViewModel();
            contact.qution = new SelectqutionContact();
            contact.qution.idqu = "2";
            return View(contact);
        }
        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel b)
        {
            try
            {
                b.idcontactType = byte.Parse(b.qution.idqu);
            }
            catch
            {
                Redirect("/Home/Error/" + (int)error.Exption);
            }
            await b.Procass(_context);
            b.email = "";
            b.message = "*";
            b.name = "";
            return View(b);
        }


        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Post()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.DataViewModel.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

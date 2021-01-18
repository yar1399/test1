using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PTemplate.Data;
using PTemplate.Models.Data.DBSatare;

namespace PTemplate.Controllers
{
    public class NamrangController : Controller
    {

        private readonly ApplicationDbContext _context;


        public NamrangController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Statesticsx()
        {
            return View();
        }

        public IActionResult yourColor(string name , string fameli )
        {


            List<NamranggetcolornameResult> ts;
            if (name == null)
            {
                ts = new List<NamranggetcolornameResult>();
                NamranggetcolornameResult dc = new NamranggetcolornameResult();
                dc.colorname = "NO-2";
                dc.description = "نام  را صحیح وارد کنید";
                ts.Add(dc);
                return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
            }


            if (fameli == null)
            {
                ts = new List<NamranggetcolornameResult>();
                NamranggetcolornameResult dc = new NamranggetcolornameResult();
                dc.colorname = "NO-2";
                dc.description = "نام خانوادگی را صحیح وارد کنید";
                ts.Add(dc);
                return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
            }

          
              

            ts = _context.sp_getcolorname(name, fameli);

            if (ts != null)
            {
                if (ts.Count == 0)
                {
                    ts = new List<NamranggetcolornameResult>();
                    NamranggetcolornameResult dc = new NamranggetcolornameResult();
                    dc.colorname = "NO";
                    dc.description = "موردی یافت نشد";
                    ts.Add(dc);
                    return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
                }
            }

            return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
        } 
        
        public IActionResult yourDescriptionColor(int? id  )
        {


            List<NamgetcolordescriptionResult> ts;
            if (id == null )
            {
                ts = new List<NamgetcolordescriptionResult>();
                NamgetcolordescriptionResult dc = new NamgetcolordescriptionResult();
                dc.name = "NO-2";
                dc.description = "نام رنگ را صحیح وارد کنید";
                ts.Add(dc);
                return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
            }
              

            if (id == 0)
            {
                ts = new List<NamgetcolordescriptionResult>();
                NamgetcolordescriptionResult dc = new NamgetcolordescriptionResult();
                dc.name = "NO-2";
                dc.description = "نام رنگ را صحیح وارد کنید";
                ts.Add(dc);
                return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
            }
              

            ts = _context.sp_getcolordescription(id);
         
        if(ts!=null)
            {
                if(ts.Count==0)
                {
                    ts = new List<NamgetcolordescriptionResult>();
                    NamgetcolordescriptionResult dc = new NamgetcolordescriptionResult();
                    dc.name = "NO";
                    dc.description = "موردی یافت نشد";
                    ts.Add(dc);
                    return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
                }
            }

            return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
        }


        public JsonResult yournamebaby(string fameli,
    string color,
    int gender)
        {

            bool t = gender == 0 ?false:true;


            List<NamgetnamelistbycolorandfamilyResult> ts;
             ts = _context.sp_getnamelistbycolorandfamily(fameli, color, t);

            if (ts != null)
            {
                if (ts.Count == 0)
                {
                    //ts = new List<NamgetnamelistbycolorandfamilyResult>();
                    NamgetnamelistbycolorandfamilyResult dc = new NamgetnamelistbycolorandfamilyResult();
                    dc.name = "NO";
                    dc.meaning = "موردی یافت نشد";
                    ts.Add(dc);
                    return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, });
                }
            }
            return Json(new { ts }, new JsonSerializerOptions { WriteIndented = true, }); 
        }



    }
}

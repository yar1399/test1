using Microsoft.AspNetCore.Http;
using PTemplate.Data;
using PTemplate.Models.Statestics;
using PTemplate.Models.Statestics.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAParser;

using PTemplate.Data;
using PTemplate.Data.DataBase;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PTemplate;
using PTemplate.Models;
using Microsoft.AspNetCore.Mvc.Razor;

public class ApplcationVarlable
    {
    private readonly RequestDelegate _requestDelegate;

    public ApplcationVarlable(RequestDelegate requestDelegate)
    {
        _requestDelegate = requestDelegate;
    }



    public async Task Invoke(HttpContext context)
    {

        string userAgent = context.Request.Headers["User-Agent"].ToString();
        DateTime dt = DateTime.Now.Date;
        if(string.IsNullOrEmpty(userAgent))
        {
            await _requestDelegate(context);
        }
        var uaparser = Parser.GetDefault();
        ClientInfo userinfo = uaparser.Parse(userAgent);
        string iduserBase = null;
        if(context.User!=null)
            if(context.User.Identity.IsAuthenticated)
         iduserBase = context.User.FindFirst(ClaimTypes.NameIdentifier).Value;




        if (Chack(context))
        {
            //don the necessary staffs here to save the count by one
            string key = Guid.NewGuid().ToString();
            context.Response.Cookies.Append("VisitorId", key, new CookieOptions()
            {
              
                Expires = DateTime.Now.AddMinutes(20)
            });
            context.Session.SetString("VisitorId", key);

            stOnlion.Set(new On() { Key = key, Time = DateTime.Now.AddMinutes(20) });

            ApplicationDbContext appA = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());

            
            

            var os = appA.Osses.Where(a => a.Osname == userinfo.OS.Family && userinfo.OS.Major == a.Oskey).FirstOrDefault();
            if (os == null)
            {
                appA.Osses.Add(new Oss()
                {
                    Oskey = userinfo.OS.Major,
                    Osname = userinfo.OS.Family,
                    ImageName = "..."
                });

                appA.SaveChanges();
                os = appA.Osses.Where(a => a.Osname == userinfo.OS.Family && userinfo.OS.Major == a.Oskey).FirstOrDefault();
            }

            var bo = appA.Browsers.Where(a => a.BrowsersName == userinfo.UA.Family && userinfo.UA.Major == a.BrowsersKey).SingleOrDefault();
           
            if (bo == null)
            {
                appA.Browsers.Add(new Browser()
                {
                    BrowsersKey = userinfo.UA.Major,
                    BrowsersName = userinfo.UA.Family,
                    ImageName = "..."
                });

                appA.SaveChanges();

                bo = appA.Browsers.Where(a => a.BrowsersName == userinfo.UA.Family && userinfo.UA.Major == a.BrowsersKey).SingleOrDefault();
            }


            var q=  appA.Statestics.Where(a => a.Day.Value.Year == dt.Date.Year &&
                                               a.Day.Value.Month == dt.Date.Month &&
                                               a.Day.Value.Day == dt.Date.Day).FirstOrDefault();

            if (q==null)
            {
                appA.Statestics.Add(new Statestic()
                {
                    Counter = 1,
                    Day = DateTime.Now.Date
                }) ;
                appA.SaveChanges();
            }
            else
            {
                q.Counter += 1;
                appA.Statestics.Update(q);
                appA.SaveChanges();
            }

            var qnow = appA.Statestics.Where(a => a.Day.Value.Year == dt.Date.Year &&
                                               a.Day.Value.Month == dt.Date.Month &&
                                               a.Day.Value.Day == dt.Date.Day).FirstOrDefault();



            appA.StUsers.Add(new StUser()
            {
                KeyId = key,
                OsId = os.Id,
                BroserId = bo.Id,
                StId = qnow.Id,
                Iduser=iduserBase
            });

            appA.SaveChanges();

            int iduser = appA.StUsers
                .Where(a => a.StId == qnow.Id)
                .Where(a => a.KeyId == key).FirstOrDefault().Id;

            Microsoft.AspNetCore.Http.Headers.RequestHeaders header = context.Request.GetTypedHeaders();
            Uri uriReferer = header.Referer;
            var loc = new GetLocation().get(context.Connection.RemoteIpAddress.ToString());
            int idreffer = StRefferSave(context.Request.Host.ToString(), context.Request.Host +  context.Request.Path, context.Request.Headers["Referer"].ToString(), appA, userinfo.Device.IsSpider);

          
            
         

            StatesticsDetil detils = new StatesticsDetil()
            {
                Date = DateTime.Now,
                Ip =  context.Connection.RemoteIpAddress.ToString(),
                IdstReffer = idreffer,
                Url = context.Request.Host+ context.Request.Path,
                UserId= iduser,
                City= loc==null?"...":loc.city,
                Country= loc==null?"...":loc.country
            };

            appA.StatesticsDetils.Add(detils);
            appA.SaveChanges();


        }
        else
        {
            string key = getkay(context);

            ApplicationDbContext appA = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());

           

            var os = appA.Osses.Where(a => a.Osname == userinfo.OS.Family && userinfo.OS.Major == a.Oskey).FirstOrDefault();
            
            if (os == null)
            {
                appA.Osses.Add(new Oss()
                {
                    Oskey = userinfo.OS.Major,
                    Osname = userinfo.OS.Family,
                    ImageName = "..."
                });

                appA.SaveChanges();
                os = appA.Osses.Where(a => a.Osname == userinfo.OS.Family && userinfo.OS.Major == a.Oskey).FirstOrDefault();
            }

            var bo = appA.Browsers.Where(a => a.BrowsersName == userinfo.UA.Family && userinfo.UA.Major == a.BrowsersKey).SingleOrDefault();

            if (bo == null)
            {
                appA.Browsers.Add(new Browser()
                {
                    BrowsersKey = userinfo.UA.Major,
                    BrowsersName = userinfo.UA.Family,
                    ImageName = "..."
                });

                appA.SaveChanges();

                bo = appA.Browsers.Where(a => a.BrowsersName == userinfo.UA.Family && userinfo.UA.Major == a.BrowsersKey).SingleOrDefault();
            }

            var q = appA.Statestics.Where(a => a.Day.Value.Year == dt.Date.Year &&
                                               a.Day.Value.Month == dt.Date.Month &&
                                               a.Day.Value.Day == dt.Date.Day).FirstOrDefault();

            if (q == null)
 
            {

                appA.Statestics.Add(new Statestic()
                {
                    Counter = 1,
                    Day = DateTime.Now.Date
                });

                appA.SaveChanges();

            var qnow = appA.Statestics.Where(a => a.Day.Value.Year == dt.Date.Year &&
                                               a.Day.Value.Month == dt.Date.Month &&
                                               a.Day.Value.Day == dt.Date.Day).FirstOrDefault();

                int iduser = appA.StUsers
                .Where(a => a.StId == qnow.Id)
                .Where(a => a.KeyId == key).FirstOrDefault().Id;

            Microsoft.AspNetCore.Http.Headers.RequestHeaders header = context.Request.GetTypedHeaders();
            Uri uriReferer = header.Referer;


              int idreffer=  StRefferSave(context.Request.Host.ToString(), context.Request.Host + context.Request.Path, context.Request.Headers["Referer"].ToString(), appA, userinfo.Device.IsSpider);
                var loc = new GetLocation().get(context.Connection.RemoteIpAddress.ToString());
                StatesticsDetil detils = new StatesticsDetil()
                {
                    Date = DateTime.Now,
                    Ip = context.Connection.RemoteIpAddress.ToString(),
                    IdstReffer = idreffer,
                    Url = context.Request.Host  + context.Request.Path,
                    UserId = iduser,
                    City = loc == null ? "..." : loc.city,
                    Country = loc == null ? "..." : loc.country
                };
                appA.StatesticsDetils.Add(detils);
            appA.SaveChanges();
            }
            else
            {
                q.Counter += 1;
                appA.Statestics.Update(q);
                appA.SaveChanges();

                //var a = appA.StUsers
                //        .Where(a => a.StId == q.Id)
                //        .Where(a => a.KeyId == key).FirstOrDefault();

                int iduser = appA.StUsers
                    .Where(a => a.StId == q.Id)
                    .Where(a => a.KeyId == key).FirstOrDefault().Id;

                Microsoft.AspNetCore.Http.Headers.RequestHeaders header = context.Request.GetTypedHeaders();
                Uri uriReferer = header.Referer;

                int idreffer = StRefferSave(context.Request.Host.ToString(), context.Request.Host  + context.Request.Path, context.Request.Headers["Referer"].ToString(), appA, userinfo.Device.IsSpider);
                var loc = new GetLocation().get(context.Connection.RemoteIpAddress.ToString());

                StatesticsDetil detils = new StatesticsDetil()
                {
                    Date = DateTime.Now,
                    Ip = context.Connection.RemoteIpAddress.ToString(),
                    IdstReffer = idreffer,
                    Url = context.Request.Host  + context.Request.Path,
                    UserId = iduser,
                  
                    City = loc == null ? "..." : loc.city,
                    Country = loc == null ? "..." : loc.country
                };
                //try
                //{
                  
                    appA.StatesticsDetils.Add(detils);
                    appA.SaveChanges();

                //}
                //catch {
                //    appA.StatesticsDetils.Update(detils);
                //    appA.SaveChanges();
                //}
            
            }


            

            context.Response.Cookies.Delete("VisitorId", new CookieOptions()
            {
           
                Expires = DateTime.Now.AddMinutes(20)
            });
            context.Session.Remove("VisitorId");

            stOnlion.Update(key);
           
            context.Response.Cookies.Append("VisitorId", key, new CookieOptions()
            {
           
                Expires = DateTime.Now.AddMinutes(20)
            });

            context.Session.SetString("VisitorId", key);
        }
        await _requestDelegate(context);
    }

    public static int StRefferSave(string host,string url, string reffer, ApplicationDbContext appA,bool isSpider)
    {
        //1=دامنه را وارد کرده
        //2=وارد صفحه خاصی شده است
        //3=بک لینک است
        int no = 0;
        bool spider =  isSpider;
        if (reffer == url)
        {
            no = 3;
        }else
        if (host == reffer)
        {
            no = 2;
        }
        else if (string.IsNullOrEmpty(reffer))
        {
            no = 1;
        }
        else
        {
            no = 1;
        }

        var db = appA.StReffers.Where(a => a.Address == reffer).FirstOrDefault();
        if (db == null)
        {
            StReffer _StReffer = new StReffer()
            {
                Address = reffer,
                No = no,
                Spider = spider
            };
            appA.StReffers.Add(_StReffer);
            appA.SaveChanges();

            db = appA.StReffers.Where(a => a.Address == reffer).FirstOrDefault();
            if (db != null)
                return db.Id;
            else
                return 1;
        }
        else
        {
            return db.Id;
        }



    }

    public static bool Chack(HttpContext context)
    {
        try {
            if (String.IsNullOrEmpty(context.Request.Cookies["VisitorId"] ))
            {
                if (String.IsNullOrEmpty(context.Session.GetString("VisitorId")))
                    return true;
                else
                    return false;
            }
           
            else
            {
                return false;
            }
        }
        catch
        {
            throw;
        }
       
    }

    public static string getkay(HttpContext context)
    {
       /* try
        {*/

            if (!string.IsNullOrEmpty(  context.Request.Cookies["VisitorId"]))
            {
                return context.Request.Cookies["VisitorId"].ToString();
            }
               else{ if (!string.IsNullOrEmpty(context.Session.GetString("VisitorId")))
            {
                string st = context.Session.GetString("VisitorId");
                return st;
            }
                  
                else
                    return "";
            }
            
      /*  }
        catch
        {
            return "";
        }*/

    }

}


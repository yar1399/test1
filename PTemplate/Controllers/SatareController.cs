using PTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.Configuration;
using Kavenegar;
using Kavenegar.Exceptions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using PTemplate.Data;
using Microsoft.AspNetCore.Hosting;
using PTemplate.Models.Data.DBSatare;
using System.IO;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System.Data;
using Microsoft.AspNetCore.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.EntityFrameworkCore;

using static Stimulsoft.Report.Func;
using PTemplate.Data.DB;
using System.Security.Cryptography;

namespace PTemplate.Controllers
{
  //  [Route("api/[controller]")]
  //  [ApiController]
    public class SatareController : Controller
    {
        // GET: Satare



        private readonly ApplicationDbContext _context;

        [Obsolete]
        private readonly IHostingEnvironment _environment;
        private readonly IConfiguration _config;
        public SatareController(ApplicationDbContext context, IHostingEnvironment environment, IConfiguration config)
        {

            _environment = environment;
            _context = context;


        }


        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }



        [HttpPost]
        public JsonResult stateupdateorderuser(
          string iduser,
   string token,
   long idnetwork,
   string idmenuorder,
   byte idstatetype)
        {
            var mob = _context.sp_stateupdateorderuser(iduser,
    token,
    idnetwork,
    idmenuorder,
    idstatetype
   );
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult stateupdate(
           string iduser,
    string token,
    long idnetwork,
    string idmenuorder,
    byte idstatetype)
        {
            var mob = _context.sp_stateupdate(iduser,
    token,
    idnetwork,
    idmenuorder,
    idstatetype
   );
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult menuorderitemsupdate(
             string iduser,
             string token,
          long idnetwork,
   string idmenuorder,
   int counter,
   string idmenuitems)
        {
            var mob = _context.sp_menuorderitemsupdate(iduser,
               token,
             idnetwork,
     idmenuorder,
     counter,
     idmenuitems);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult menuorderitemsdelete(
           string iduser,
           string token,
           string idmenuorder,
           string idmenuitems,
           long idnetwork)
        {
            var mob = _context.sp_menuorderitemsdelete(iduser,
           token,
           idmenuorder,
           idmenuitems,
           idnetwork);

            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkprofilemediabytypedelete(
          string iduser,
          string token,
          long idnetwork,
          int idtype )
        {
            var mob = _context.sp_networkprofilemediabytypedelete(
                iduser,
                token,
                idnetwork,
                idtype);


            if (mob != null)
            {
                if (mob.First().idcode == 1)
                {
                    String path = "";
                    var PathList = _context.sp_networkprofilemediapathget(idnetwork, idtype);
                    foreach (Pathfile p in PathList)
                    {
                        if (idtype == 1)
                            path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads/profile/avatar", p.path);
                        else
                            path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads/profile/cover", p.path);
                       
                        System.IO.File.Delete(path);

                    }
                }
            }


            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }



        [HttpPost]
        public JsonResult menuorderlist(
        string iduser,
      string token,
      long idnetwork,

     int PageNumber)
        {
            var order = _context.sp_menuorderlist(iduser,
         token,
         idnetwork,
         PageNumber);
            return Json(new { order }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult menuorderlistshoppinguser(
          string iduser,
        string token,
        long idnetwork,
       
       int PageNumber)
        {
            var order = _context.sp_menuorderlist( iduser,
         token,
         idnetwork,
         PageNumber);
            return Json(new { order }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult menuorderlistshopping(
        string iduser,
       string token,
       long idnetwork,
       int PageNumber)
        {
            var order = _context.sp_menuorderlistshopping(iduser,
         token,
         idnetwork, PageNumber);
            return Json(new { order }, new JsonSerializerOptions { WriteIndented = true, });
        }




        [HttpPost]
        public JsonResult menuorderitemsget(
             string iduser,
          string token,
          string idmenuorder,
          
          long idnetwork)
        {
            var order = _context.sp_menuorderitemsget(iduser,
           token,
           idmenuorder,
          
           idnetwork);
            return Json(new { order }, new JsonSerializerOptions { WriteIndented = true, });
        }



      




        [HttpPost]
        public JsonResult menuorderitemsinsert(
         string    iduser ,
         string token ,
         string idmenuorder ,
    string idmenu ,
	long idnetwork ,
    string  productbarcode ,
    string name ,
	decimal money ,
	decimal moneyuser ,
    decimal discount,
    int count)
        {
            var mob = _context.sp_menuorderitemsinsert(iduser,
    token,
    idmenuorder,
    idmenu,
    idnetwork,
    productbarcode,
    name,
    money,
     moneyuser,
    discount, count);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        } 
        
        
        [HttpPost]
        public JsonResult factorcreate(
             string iduser,
             string token,
             long   idnetwork,
             int     idordertype,
             decimal moneypeyk)
        {
            var mob = _context.sp_factorcreate(iduser, token, idnetwork, idordertype, moneypeyk);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

       



        [HttpPost]
        public JsonResult stateget(
              string iduser,
              string token,
              long idnetwork)
        {
            var mob = _context.sp_stateget(iduser, token, idnetwork);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }




        [HttpPost]
        public JsonResult menudelete(string iduser, string token, string idmenu, long idnetwork)
        {
            var mob = _context.sp_menudelete( iduser, token,  idmenu,  idnetwork);

            if (mob != null)
            {
                if (mob.First().idcode == 1)
                {
                    String path = "";
                    var PathList = _context.sp_menumediapathget(idmenu);
                    foreach (Pathfile p in PathList)
                    {
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads/product", p.path);
                        System.IO.File.Delete(path);
                    }
                }
            }



            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult shoppingnetworkmenuget(string iduser, long idnetwork)
        {

            var shoppingPro = _context.sp_shoppingnetworkmenuget(iduser,idnetwork);
            return Json(new { shoppingPro }, new JsonSerializerOptions { WriteIndented = true, });

        }



        [HttpPost]
        public JsonResult networkdescriptiondelete(
            string iduser,
            string token,
            long idnetwork,
            string description)
        {
            var mob = _context.sp_networkdescriptiondelete(iduser,
             token,
   idnetwork,
   description);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkdescriptioncreate(
            string iduser,
string token,
long idnetwork,
string description)
        {
            var mob = _context.sp_networkdescriptioncreate(
                     iduser,
                     token,
                     idnetwork,
                     description);

            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult shoppingnetworktelldelete(string iduser ,
	string token ,
	long idnetwork,
    string tell)
        {
            var mob = _context.sp_shoppingnetworktelldelete(iduser,
   token,
   idnetwork,tell);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult shoppingnetworktellcreate(string iduser,
   string token,
   long idnetwork,
   string tell)
        {
            var mob = _context.sp_shoppingnetworktellcreate(iduser,
   token,
   idnetwork, tell);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networktypenetworkUpdate(

 string iduser,
 string token,
 long idnetwork,
 int idtype)
        {
            var mob = _context.sp_networktypenetworkUpdate(iduser,
   token,
   idnetwork,
   idtype);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkshoppingdetailsget(

  string iduser,
  string token,
  long idnetwork)
        {
            var details = _context.sp_networkshoppingdetailsget(iduser,
   token,
   idnetwork);
            return Json(new { details }, new JsonSerializerOptions { WriteIndented = true, });
        }
            

        [HttpPost]
        public JsonResult networkshoppingcreate(
       int idproductshoppingtype,
    string namenetwork,
    string iduser,
    string token)
        {
            var mob = _context.sp_networkshoppingcreate( idproductshoppingtype,
     namenetwork,
     iduser,
     token);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }



        [HttpPost]
        public async Task<JsonResult> menucreate(
          IEnumerable<IFormFile> files,
          String iduser,
          String token,
          long idnetwork,
          String name,
          String description,
          decimal money,
          decimal moneyuser,
          int idunit,
          String datestart,
          String dateend
        )
        {
           
            List<Data.DB.dbMessage> mob = new List<Data.DB.dbMessage>();
            string pa = "";
            mob.Add(new Data.DB.dbMessage());
            mob[0].idcode = 1;
            mob[0].message = "...";
            mob[0].code = 0;

            string result = "";
            string[] extensions = { ".png", ".jpg", ".jpeg" };
            string namefile = "...";
            if (files.Count() != 0)
            {
                var file = files.First();

                string ext = Path.GetExtension(file.FileName.ToLower());

                if (!extensions.Any(x => x.Equals(ext, StringComparison.OrdinalIgnoreCase)))
                {
                    mob[0].idcode = 2;
                    mob[0].message = "داده ارسالی صحیح نمی باشد.";
                    mob[0].code = 0;
                    return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });

                }

                if (file.Length < 0)
                {

                    mob[0].idcode = 2;
                    mob[0].message = "داده ارسالی صحیح نمی باشد.";
                    mob[0].code = 0;

                    return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
                }

                namefile = Guid.NewGuid() + new Random().Next(1, 1000).ToString() + ext;

                pa = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads/product", namefile);

                using (System.IO.Stream stream = new FileStream(pa, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

             mob = _context.sp_menucreate( iduser,
           token,
           idnetwork,
           name,
           description,
           money,
           moneyuser,
           idunit,
           datestart,
           dateend,
           namefile);

            if (mob == null)
            {
                mob[0].idcode = 2;
                mob[0].message = "داده ارسالی صحیح نمی باشد.";
                mob[0].code = 0;
                System.IO.File.Delete(pa);
            }
            else if (mob[0].idcode == 1)
            {
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }
            else
            {
                System.IO.File.Delete(pa);
            }


            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networksettinguserget(
        string iduser,
        string token,
        long idnetwork)
        {
            var mob = _context.sp_networksettinguserget(idnetwork, iduser, token);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networksettinguserdelete(
         string iduser,
         string token,
         long   idnetwork,
         int    idsettingtype )
        {
            var mob = _context.sp_networksettinguserdelete(iduser,
                token,
                idnetwork,
                idsettingtype);

            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networksettingusercreate(
          string iduser,
  string token,
  long idnetwork ,
    int idsettingtype 
)
        {
            var mob = _context.sp_networksettingusercreate( iduser,
   token,
   idnetwork,
     idsettingtype
    );
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkshoppinggeodelete(
            long idnetwork,
            string iduser,
            string token
            )
        {
            var mob = _context.sp_networkshoppinggeodelete(idnetwork,iduser,token);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }




        [HttpPost]
        public JsonResult networkshoppinggeocreate(
         long    idnetwork,
         string  geo,
         string  iduser ,
         string  token 
)
        {
            var mob = _context.sp_networkshoppinggeocreate(
                idnetwork,
      geo,
     iduser,
    token
    );
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }




        [HttpPost]
        public JsonResult productshoppingtypelist(
         string namesearch,
         double latitude,
         double longitude ,
         int distancefilter,
         int moneyfilter,
         int distance)
        {
            var mob = _context.sp_productshoppingtypelist(namesearch,
           latitude ,
           longitude ,
           distancefilter,
           moneyfilter,
           distance);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult productshoppingtypeonetypelist(
          long idproductshoppingtype,
          double latitude = 0,
          double longitude = 0,
          int distance = 0)
        {



            var mob = _context.sp_productshoppingtypeonetypelist(idproductshoppingtype,
     latitude, longitude,
     distance);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult productshoppingtypealllist(

           double latitude,
          double longitude,
           int distance)
        {
            var mob = _context.sp_productshoppingtypealllist(
           latitude,
           longitude,
           distance);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }




        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getsport()
        {
                              
            var sports = _context.sp_Sport();
            return Json(new { sports }, new JsonSerializerOptions { WriteIndented = true, });

        }


        [HttpGet]
        public async Task<JsonResult> zarenPal(string id, string code, int product)
        {

            //  var payment = await new Zarinpal.Payment("YourMerchantId", Amount);


            var sports = _context.sp_Sport();
            return Json(new { sports }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public async Task<JsonResult> getMobile(
            string mobile,
            int idsoftwaremodel=3,
            int idusertypesms=1)
        {
            decimal mor;
            if (mobile.Length == 12 && decimal.TryParse(mobile, out mor)  && mobile[0] == '9' && mobile[1] == '8')
            {
                var mob1 = _context.sp_UserSMS(mobile,(byte) idsoftwaremodel, (byte)idusertypesms);
                var mob = mob1.First();
                if (mob.idcode == 1)
                {
                    var sender = "10006571865573";
                    var receptor = mobile;
                    var message = mob.code + ":" + "کداحراز شبکه خرید.پرسود و منفعت";
                    var api = new Kavenegar.KavenegarApi("777353354F636E4A7331547750447A504D6A726F373234535578594869536C6F");
                    try
                    {
                        var result = api.Send(sender, receptor, message);
                    }
                    catch (ApiException ex)
                    {
                        mob.idcode = 4;
                        mob.message = ex.Message;
                    }
                    catch (Kavenegar.Exceptions.HttpException ex)
                    {
                        mob.idcode = 4;
                        mob.message = ex.Message;

                    }
                }
              
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }
            else
            {
                var mob = new
                {
                    idcode = 2,
                    message = "شماره تلفن همراه صحیح وارد نمائید.",
                    code = 0
                };
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }

        }


        [HttpPost]
        public JsonResult UserCreate(
     string mobile,
     string code,
     string pass,
             string name
    )
        {



            var mob = _context.sp_UserCreate(mobile, pass, code, name);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


     

        [HttpPost]
        public JsonResult UserSMSChack(
        string mobile
      , string code
      , int    typesms)
        {

            var mob1 = _context.sp_UserSMSChack(mobile, code, typesms);
            var mob = mob1.First();

                if (mob.idcode == 1)
                {
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }
                else
                {
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }
           


        }

        //[HttpPost]
        //public async Task<JsonResult> getchackMobile(
        //  string _mobile
        // ,string code)
        //{
      
        //   var mob = _context.sp_UserSMSCode(_mobile, code).First();
             
        //    if (mob != null)
        //    {

        //        if (mob.idcode == 1)
        //        {
        //            return Json(mob, new JsonSerializerOptions { WriteIndented = true, });
        //        }
        //        else
        //        {

        //            return Json(mob, new JsonSerializerOptions { WriteIndented = true, });
        //        }
        //    }else
        //    {
        //        mob.idcode = 2;
        //        mob.message = "کد تایید نشد.";
        //        mob.code = 0;
        //        return Json(mob, new JsonSerializerOptions { WriteIndented = true, });
        //    }
      

        //}



        [HttpPost]
        public async Task<JsonResult> UserLoginPass(
           string _mobile
         , string pass
         , int softwaremodel)
        {

            var mobile = _context.sp_UserLoginPass(_mobile, pass, softwaremodel);
            var mob = mobile.First();
            if (mobile != null)
            {

                if (mob.idcode == 1)
                {
                    var user = _context.sp_UserGet(_mobile).First();
                    var network1 = _context.sp_networkGet(user.iduser, user.token.ToString(), 1);
                    networkGetResult network2 = new networkGetResult();

                    network2 = network1.FirstOrDefault();
                    UserProfileGat profile = new UserProfileGat();
                    object network;
                    if (network2 != null)
                    {
                        network = new
                        {


                            id = network2.id,
                            iduser = network2.iduser,
                            
                            idnetworktype = network2.idnetworktype,
                            nickname = network2.nickname,
                            createnetworkdate = network2.createnetworkdate,
                            isactive = network2.isactive

                        };
                        var profile1 = _context.sp_UserProfileGat(network2.id);
                        //if (profile1.FirstOrDefault() != null || !profile1.Any())
                        profile = profile1.FirstOrDefault();
                    }
                    else
                    {
                        network = null;
                        profile = null;
                    }


                    var mob1 = new
                    {
                        iduser = user.iduser,
                        mobile = _mobile,
                        token = user.token.ToString(),
                        isactive = true,

                        network,

                        profile,
                        mob

                    };

                    return Json(mob1, new JsonSerializerOptions { WriteIndented = true, });
                }
                else
                {
                    
                    networkGet network = null;
                    UserProfileGat profile = null;
                    var mob1 = new
                    {
                        iduser = 0,
                        mobile = "-",
                        token = "-",
                        isactive = false,
                        network,
                        profile,
                        mob

                    };
                    return Json(mob1, new JsonSerializerOptions { WriteIndented = true, });
                }
            }
            return Json(new { mobile }, new JsonSerializerOptions { WriteIndented = true, });

        }





        [HttpPost]
        public async Task<JsonResult> networksettingusergetactivesettings( long idnetwork)
        {
            
            var mob1 = _context.sp_networksettingusergetactivesettings(idnetwork);
            return Json(mob1, new JsonSerializerOptions { WriteIndented = true, }); 
        }

        [HttpPost]
        public async Task<JsonResult> getshopingMe(string iduser, string code, long idnetwork)
        {

            Data.DB.dbMessage mes = new Data.DB.dbMessage() { code = 1, idcode = 1, message = "موفق" };
            List<networkshoppingdetailsgResult> shoping = _context.sp_networkshoppingdetailsget(iduser, code, idnetwork);
            var setting = _context.sp_networksettingusergetactivesettings(idnetwork);
           

            if (shoping == null)
                mes.code = 2;
            else
                if(shoping.Count==0)
                mes.code = 2;

            var shopingMe = new
            {
             
                setting ,
                shoping ,
                mob = mes

            };

           return Json(shopingMe, new JsonSerializerOptions { WriteIndented = true, }); ;
        }


            [HttpPost]
        public async Task<JsonResult> getMobileCode(
           string _mobile
          , string code
           )
        {
       
            var mobile = _context.sp_UserSMSCode(_mobile, code);
            var mob = mobile.First();
            if (mobile != null )
            {

                if (mob.idcode == 1)
                {

                    var user = _context.sp_UserGet(_mobile).First();
                    var network1 = _context.sp_networkGet(user.iduser, user.token.ToString(),1);
                    networkGetResult network2 = new networkGetResult();

                    network2 = network1.FirstOrDefault();
                    UserProfileGat profile = new UserProfileGat();
                    object network;
                    if (network2 != null)
                    {
                        network = new
                        {


                            id = network2.id,
                            iduser = network2.iduser,
                            idnetworktype = network2.idnetworktype,
                            nickname = network2.nickname,
                            createnetworkdate = network2.createnetworkdate,
                            isactive = network2.isactive


                        };
                        var profile1 = _context.sp_UserProfileGat(network2.id);
                        //if (profile1.FirstOrDefault() != null || !profile1.Any())
                        profile = profile1.FirstOrDefault();
                    }
                    else
                    {
                        network = null;
                        profile = null;
                    }

                    var mob1 = new
                    {
                        iduser = user.iduser,
                        mobile = _mobile,
                        token = user.token.ToString(),
                        isactive = true,

                        network,

                        profile,
                        mob

                    };
                    return Json(mob1, new JsonSerializerOptions { WriteIndented = true, });
                }
                else
                {
//var user = _context.sp_UserGet(_mobile).First();
                    networkGet network = null;// _context.networkGet(user.id, 1).First();
                    UserProfileGat profile = null;// _context.UserProfileGat(network.id).First();
                    var mob1 = new
                    {
                        iduser = 0,
                        mobile = "-",
                        token = "-",
                        isactive = false,
                        network,
                        profile,
                        mob

                    };
                    return Json(mob1, new JsonSerializerOptions { WriteIndented = true, });
                }
            }

            return Json(new { mobile }, new JsonSerializerOptions { WriteIndented = true, });

        }


        [HttpPost]
        // POST api/values
        public JsonResult SportMusle(int sportmusle)
        {
            var _sportmusle = _context.sp_sportmusle(sportmusle);
            return Json(new { _sportmusle }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        // POST api/values
        public JsonResult moveGet(int idmove)
        {
            var _moveGet = _context.sp_moveGet(idmove);
            return Json(new { _moveGet }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        // POST api/values
        public JsonResult MusleGetAll()
        {
            var Musle = _context.sp_movemusleGetAll();
            return Json(new { Musle }, new JsonSerializerOptions { WriteIndented = true, });
        }



        [HttpPost]
        // POST api/values
        public JsonResult moveinfoGet(
            int idmove)
        {
            var _moveinfoGet = _context.sp_moveinfoGet(idmove);
            return Json(new { _moveinfoGet }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult movesportGet(
           byte idsport
         , byte idmusle)
        {
            var _movesportGet = _context.sp_movesportGet(idsport, idmusle);
            return Json(new { _movesportGet }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        // POST api/values
        public JsonResult sportmusleGetAll(int idsport)
        {
            var _sportmusleGetAll = _context.sp_sportmusleGetAll(idsport);
            return Json(new { _sportmusleGetAll }, new JsonSerializerOptions { WriteIndented = true, });
        }

      /*  [HttpPost]
        public JsonResult networkBase(
          string iduser
        , string code
        , string nickname)
        {
            var network = _context.networkBase(iduser, code, nickname);
            return Json(new { network }, new JsonSerializerOptions { WriteIndented = true, });
        }
        */
        [HttpPost]
        public JsonResult networkcreatePro(
          string iduser
        , string code,
          byte networktype
        , string nickname)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(nickname, "^[a-zA-Z0-9\x20|_]+$"))
            {
                var mob = _context.sp_networkcreatePro(iduser, code, networktype, nickname);
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }
            else
            {
                object mob = new
                {
                    idcode = 2,
                    message = "از کاراکترهای غیر مجاز استفاده شده است",
                    code = 0
                };
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });

            }
        }

        [HttpPost]
        public JsonResult networkchecknickname(
         string iduser
        , string code
        , string nickname)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(nickname, "^[a-zA-Z0-9\x20|_]+$"))
            {

                var mob = _context.sp_networkchecknickname((string)iduser, code, nickname);
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }
            else
            {
                object mob = new
                {
                    idcode = 2,
                    message = "از کاراکترهای غیر مجاز استفاده شده است",
                    code = 0
                };
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });

            }


        }


        [HttpPost]
        public JsonResult networkGet(
         string iduser,
         string code
       , byte networktype)
        {
            var network = _context.sp_networkGet(iduser, code, networktype);
            return Json(new { network }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkGetAllUser(
         string iduser,
         string code
       , byte networktype)
        {
            var network = _context.sp_networkGetAllUser(iduser, code, networktype);
            return Json(new { network }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult UserProfileCreate(
              string iduser
           ,  string code
           ,  bool idsex
           ,  string name
      
           ,  string birthday
           ,  int city
           ,  int county
           ,  int proince
           )
        {
            var mob1 = _context.sp_UserProfileCreate(iduser, code,
             idsex,
             name,
           birthday, city, county, proince);

            String st = DateTime.Parse(birthday).ToString();

            var mob = mob1.FirstOrDefault();
            if (mob.idcode == 1)
            {
                var profile = _context.sp_profileuserGet(iduser, code);
                object obj = new
                {
                    mob,
                    profile = profile.FirstOrDefault()
                };
                return Json(new { obj }, new JsonSerializerOptions { WriteIndented = true, });
            }
            else
            {
                object obj = new
                {
                    mob,
                    profile = new { }
                };
                return Json(new { obj }, new JsonSerializerOptions { WriteIndented = true, });
            }

            //   return Json(new { obj }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UserProfileGat(
         long Idnetwork)
        {
            var userProfileGat = _context.sp_UserProfileGat(Idnetwork);
            return Json(new { userProfileGat }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult vipGet()
        {
            var vip = _context.sp_vipGet();
            return Json(new { vip }, new JsonSerializerOptions { WriteIndented = true, });
        }


        /********************************************************************************/
        private DataTable GenerateDataTable(String json)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("mobile");
            dt.Columns.Add("name");

            // string[] sp = list1.Split('.');
            List<listcontend> List = new List<listcontend>();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(listcontend));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var objects = JArray.Parse(json); // parse as array  


            foreach (JObject root in objects)
            {
                foreach (KeyValuePair<String, JToken> app in root)
                {
                    listcontend n = new listcontend();
                    // var appName = app.Key;
                    n.name = (String)app.Value["name"];
                    n.mobile = (String)app.Value["mobile"];
                    List.Add(n);

                }
            }


            foreach (listcontend li in List)
            {
                DataRow row = dt.NewRow();
                row["mobile"] = li.mobile;
                row["name"] = li.name;

                dt.Rows.Add(row);

            }
           int row1 = dt.Rows.Count;
            return dt;
        }

        [HttpPost]
        public async Task<JsonResult> networkUserCreateContact(
           IEnumerable<IFormFile> files,
            string code)
        {
            object mob;
            string result = "";
            string[] extensions = { ".txt" };

            if (files.Count() == 0)
            {
                mob = new
                {
                    idcode = 2,
                    message = "فایل خالی ارسال شده است.",
                    code = 0
                };
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }


            foreach (var file in files)
            {
                if (!extensions.Any(x => x.Equals(Path.GetExtension(file.FileName.ToLower()), StringComparison.OrdinalIgnoreCase)))
                {
                    mob = new
                    {
                        idcode = 2,
                        message = "داده ارسالی صحیح نمی باشد.",
                        code = 0
                    };
                    return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
                }

                if (file.Length > 0)
                {
                    BinaryReader b = new BinaryReader(file.OpenReadStream());
                    byte[] binData = b.ReadBytes((int)file.Length);

                    result = System.Text.Encoding.UTF8.GetString(binData);

                    // IEnumerable
                    // [FromBody]    List<ParamsObject> paramsList

                    string con =_config.GetConnectionString("DefaultConnection");



                    
                    //SatareApi.Models.Model1 v = new SatareApi.Models.Model1();
                    DataTable dt;

                    /*try
                    {*/
                        JObject jsonObj = JObject.Parse(result);


                    string iduser1 = jsonObj["menu"]["iduser"].ToString();

                    code = jsonObj["menu"]["code"].ToString();
                    string js = jsonObj["menu"]["array"].ToString();
                      
                        string iduser= iduser1;

                      //  long.TryParse(iduser1, out iduser);



                        dt = GenerateDataTable(js);
                        int i = dt.Rows.Count;




                 //       SqlParameter tellParameter = new SqlParameter("@tell", dt);
                  //      tellParameter.SqlDbType = SqlDbType.Structured;
                  //      tellParameter.TypeName = "privatebase.listtell";


                    //SqlParameter tellParameter = new SqlParameter
                    //{
                    //    ParameterName = "@tell",
                    //    SqlDbType = SqlDbType.Structured,
                    //    TypeName= "privatebase.listtell",
                    //    Direction = ParameterDirection.Input,
                    //    Value = dt
                    //};

                    //SqlParameter iduserParameter = new SqlParameter
                    //    {
                    //        ParameterName = "@iduser",
                    //        SqlDbType = SqlDbType.NVarChar,
                    //        Direction = ParameterDirection.Input,
                    //        Value = iduser1
                    //    };

                    //    SqlParameter codeParameter = new SqlParameter
                    //    {
                    //        ParameterName = "@code",
                    //        SqlDbType = SqlDbType.NVarChar,
                    //        Direction = ParameterDirection.Input,
                    //        Value = code
                    //    };

                    // var bb=  v.Database.SqlQuery<sport>("EXEC [move].[_Sport]").ToList<sport>();

                    var t = _context.sp_networkUserCreateContent(iduser1, code, dt);
                               

                        if (t.First().idcode == 2)
                        {
                            mob = new
                            {
                                idcode = 2,
                                message = "عملیات ناموفق",
                                code = 0
                            };
                            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
                        }
                        else
                        {
                            mob = new
                            {
                                idcode = 1,
                                message = "عملیات انجام شد.",
                                code = 0
                            };
                            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
                        }
                 /*   }
                    catch
                    {
                        mob = new
                        {
                            idcode = 2,
                            message = "خطا در پردازش",
                            code = 0
                        };
                        return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
                    }*/
                }
            }

            mob = new
            {
                idcode = 2,
                message = "هیچ پردازشی انجام نشد.",
                code = 0
            };
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkuserGet(
        string iduser,
        string code)
        {
            var network = _context.sp_networkuserGet(iduser, code);
            return Json(new { network }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkuserupdateGet(
       string iduser,
       string code)
        {
            var network = _context.sp_networkuserupdateGetDate(iduser, code);
            return Json(new { network }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkuserupdate(
       string iduser,
       string code)

        {
            var network = _context.sp_networkuserupdateGet(iduser, code);
            return Json(new { network }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkpostGetUser(
       string iduser,
       string code,
       int PageNo)
        {
            var post = _context.sp_networkpostGetUser(iduser, code, PageNo, 15);
            object network = new
            {
                date = DateTime.Now,
                post
            };

            return Json(new { network }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkpostGet(
        string iduser,
        string code,
        long idnetwork,
        int PageNo)
        {
            var post = _context.sp_networkpostGet(iduser, code, idnetwork, PageNo, 15);
            object network = new
            {
                date = DateTime.Now,
                post
            };

            return Json(new { network }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkpostcreate(
       string iduser,
       string code,
       long idnetwork,
       byte posttype,
       string name,
       string discription)

        {
            var mob = _context.sp_networkpostcreate(iduser, code, idnetwork,
               posttype,
               name,
               discription);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkpostdelete(
             string iduser,
             string code,
             long idnetwork,
             long idpost)
        {
            var mob = _context.sp_networkpostdelete(iduser, code, idnetwork, idpost);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkdate()
        {
            var mob = new
            {
                idcode = 1,
                message = "تاریخ با موفقیت ارسال شد.",
                code = DateTime.Now
            };
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkuserupdateCreate(
        string iduser,
        string code,
        int state)
        {
            var mob = _context.sp_networkuserupdateCreate(iduser, code, state);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult profileuserGet(
        string iduser,
        string code)
        {
            var profile = _context.sp_profileuserGet(iduser, code);
            return Json(new { profile }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult profileuserbirthdayCreate(
        string iduser,
        string code,
        string berth)
        {
            var mob = _context.sp_profileuserbirthdayCreate(iduser, code, DateTime.Parse(berth));
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult profileuserdescriptionCreate(
       string iduser,
       string code,
       string discription)
        {
            var mob = _context.sp_profileuserdescriptionCreate(iduser, code, discription);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult profileusernameCreate(
       string iduser,
       string code,
       string name)
        {
            var mob = _context.sp_profileusernameCreate(iduser, code, name);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult profileuserphoneCreate(
      string iduser,
      string code,
      string phone)
        {
            var mob = _context.sp_profileuserphoneCreate(iduser, code, phone);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult profileuserregioncityCreate(
     string iduser,
     string code,
     int idcity,
     int idcounty,
     int idprovince)
        {
            var mob = _context.sp_profileuserregioncityCreate(iduser, code,
                idcity,
                idcounty,
                idprovince);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult provinceGet()
        {
            var province = _context.sp_provinceGet();
            return Json(new { province }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult countyGetid(
     int idprovince)
        {
            var county = _context.sp_countyGetid(idprovince);
            return Json(new { county }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult citygetid(
        int idprovince,
        int idcounty)
        {
            var city = _context.sp_citygetid(idprovince, idcounty);
            return Json(new { city }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networknicknameCreate(
    string iduser,
    String code,
    String nickname,
    long network)
        {
            var mob = _context.sp_networknicknameCreate(iduser,
                code, nickname, network);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult productshoppingsubtypeautocompletelist(
    string namesearch)
        {
            var auto = _context.sp_productshoppingsubtypeautocompletelist(namesearch);
            return Json(new { auto }, new JsonSerializerOptions { WriteIndented = true, });
        }


    //    [HttpPost]
    //    public JsonResult UserProfileCreateEmdade(
    //string iduser,
    //string code,
    //string plack,
    //String name,

    //int idcity,
    //int idcounty,
    //int idprovince)
    //    {

    //        var mob1 = _context.UserProfileCreateEmdade(iduser, code, plack
    //            ,
    //           name,
    //          idcity, idcounty, idprovince);


    //        UserProfileCreateEmdadeResult mob = mob1.First();
    //        if (mob.idcode == 1)
    //        {
    //            var profile = _context.profileuserGetEmdade(iduser, code);
    //            object obj = new
    //            {
    //                mob,
    //                profile = profile.FirstOrDefault()
    //            };
    //            return Json(new { obj }, new JsonSerializerOptions { WriteIndented = true, });
    //        }
    //        else
    //        {
    //            object obj = new
    //            {
    //                mob,
    //                profile = new { }
    //            };
    //            return Json(new { obj }, new JsonSerializerOptions { WriteIndented = true, });
    //        }

    //        //   return Json(new { obj }, new JsonSerializerOptions { WriteIndented = true, });
    //    }



     //   [HttpPost]
     //   public JsonResult UserProfileCreate(
     //string iduser,
     //string code,
     //Boolean idsex,
     //String name,
     //String berthday,
     //int idcity,
     //int idcounty,
     //int idprovince)
     //   {

     //       var mob1 = _context.sp_UserProfileCreate(iduser, code,
     //          idsex,
     //          name,
     //         DateTime.Parse(berthday), idcity, idcounty, idprovince);

     //       String st = DateTime.Parse(berthday).ToString();

     //       dbMessage mob = mob1.FirstOrDefault();
     //       if (mob.idcode == 1)
     //       {
     //           var profile = _context.sp_profileuserGet(iduser, code);
     //           object obj = new
     //           {
     //               mob,
     //               profile = profile.FirstOrDefault()
     //           };
     //           return Json(new { obj }, new JsonSerializerOptions { WriteIndented = true, });
     //       }
     //       else
     //       {
     //           object obj = new
     //           {
     //               mob,
     //               profile = new { }
     //           };
     //           return Json(new { obj }, new JsonSerializerOptions { WriteIndented = true, });
     //       }

     //       //   return Json(new { obj }, new JsonSerializerOptions { WriteIndented = true, });
     //   }

        [HttpPost]
        public JsonResult networkprofilemediaCreate(
        string iduser,
        string code
      , long idnetwork,
        byte idtype,
        String discription,
        String path)
        {
            var mob = _context.sp_networkprofilemediaCreate(iduser, code,
                idnetwork, idtype, discription, path);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkprofilemediadelete(
       string iduser,
       string code
     , long idnetwork,
       long idmediaprofile)
        {
            var mob = _context.sp_networkprofilemediadelete(iduser, code,
                idnetwork, idmediaprofile);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkprofilemediaGet(
      string iduser,
      string code
    , long idnetwork)
        {
            var profile = _context.sp_networkprofilemediaGet(iduser,
                code,
                idnetwork);
            return Json(new { profile }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkSocialGetuser(
     string iduser,
     string code
   , long idnetwork)
        {
            var social = _context.sp_networkSocialGetuser(iduser,
                code,
                idnetwork);
            return Json(new { social }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkSocialGetabout(
       string iduser,
       string code,
       long idnetwork)
        {
            var social = _context.sp_networkSocialGetabout(iduser,
                code,
                idnetwork);
            return Json(new { social }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult networkblockCreate(
      string iduser,
      string code
    , long idnetwork)
        {
            var mob = _context.sp_networkblockCreate(iduser, code, idnetwork);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult networkSocialuserFllowingGat(
              string iduser,
              string code,
              long idnetwork,
              int PageNo)
        {
            var mob = _context.sp_networkSocialuserFllowingGat(iduser, code,
                idnetwork, PageNo, 25);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }



        [HttpPost]
        public JsonResult networkuserCreate(
       string iduser,
       string code,
       long idnetwork,
       int idstate,
       int idtype,
       string idu)
        {
            var mob = _context.sp_networkuserCreate(iduser, code,idnetwork, idstate, idtype, idu);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


       


    


        [HttpPost]
        public JsonResult UsernewPass(
     string mobile,
     string code,
     string pass
    )
        {
            var mob = _context.sp_UsernewPass(mobile, pass,code );
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }



        [HttpPost]
        public JsonResult networkSocialstateuserGat(
       string iduser,
       string code,
       long idnetwork,
       int idstate,
       int idtype,
       int PageNo)
        {
            var mob = _context.sp_networkSocialstateuserGat(iduser, code,
                idnetwork, idstate, idtype, PageNo, 25);
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult valuetypeGet(
        string iduser,
        string code)
        {
            var value = _context.sp_valuetypeGet(iduser, code);
            return Json(new { value }, new JsonSerializerOptions { WriteIndented = true, });
        }

        [HttpPost]
        public JsonResult valuebodyGet(
     string iduser,
     string code)
        {
            var value = _context.sp_valuebodyGet(iduser, code);
            return Json(new { value }, new JsonSerializerOptions { WriteIndented = true, });
        }


        [HttpPost]
        public JsonResult UserRolesGet(
     string iduser,
     string code)
        {
            var role = _context.sp_UserRolesGet(iduser, code);
            return Json(new { role }, new JsonSerializerOptions { WriteIndented = true, });
        }



        [HttpPost]
        public JsonResult valuebodyCreate(
       string iduser,
       string code,
       byte idvalue,
       long idclient,
       Decimal value,
       string date)
        {
            var mob = _context.sp_valuebodyCreate(iduser, code,
               idvalue, idclient, value, DateTime.Parse(date));
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }




        public async Task<JsonResult> uploadImage(
          IEnumerable<IFormFile> files,
          String iduser,
          String code,
          long idnetwork,
          byte idtype,
          String discription
         )
        {

            List<Data.DB.dbMessage> mob = new List<Data.DB.dbMessage>();
            mob.Add(new Data.DB.dbMessage());
            mob[0].idcode = 1;
            mob[0].message = "...";
            mob[0].code = 0;
            
            string result = "";
            string[] extensions = { ".png", ".jpg", ".jpeg" };

            if (files.Count() == 0)
            {

                mob[0].idcode = 2;
                mob[0].message = "فایل خالی ارسال شده است.";
                mob[0].code = 0;
               
                return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
            }


            foreach (var file in files)
            {
                string ext = Path.GetExtension(file.FileName.ToLower());

                if (!extensions.Any(x => x.Equals(ext, StringComparison.OrdinalIgnoreCase)))
                {
                    mob[0].idcode = 2;
                    mob[0].message = "داده ارسالی صحیح نمی باشد.";
                    mob[0].code = 0;

                    break;
                }

                if (file.Length < 0)
                {

                    mob[0].idcode = 2;
                    mob[0].message = "داده ارسالی صحیح نمی باشد.";
                        mob[0].code = 0;
                   
                    return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
                }

                string name = Guid.NewGuid()+new Random().Next(1,1000).ToString()+ ext, path="";
               
                if(idtype==1)
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads/profile/avatar", name);
                else
                   path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads/profile/cover", name);
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }


                 mob = _context.sp_networkprofilemediaCreate(iduser, code,
                  idnetwork, idtype, discription, name);
               
                if(mob == null)
                {
                    mob[0].idcode = 2;
                    mob[0].message = "داده ارسالی صحیح نمی باشد.";
                    mob[0].code = 0;
                    System.IO.File.Delete(path);
                }
                else
                if(mob[0].idcode==1)
                {
                  
                    return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
                }
                else
                {
                  
                    System.IO.File.Delete(path);
                }

               
              
            }
            return Json(new { mob }, new JsonSerializerOptions { WriteIndented = true, });
        }

    }
}
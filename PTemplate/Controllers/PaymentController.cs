using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PTemplate.Data;
using PTemplate.Models;
using System.Security.Claims;
using PTemplate.Models.Enum;
using PTemplate.Models.Payment;
using PTemplate.Models.DataViewModel;
using Microsoft.AspNetCore.Authorization;

namespace PTemplate.Controllers
{
    public class PaymentController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PaymentController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task< IActionResult> Index([FromQuery(Name = "Y")] string iduser= "Irbae/1ZuIWf9315TXfzcA==", [FromQuery(Name = "R")]string token= "8vEOEaxXIkWUVBAQ5VuF7jH/Q+TrUxEtb94JZLiwEFs=")
        {


            if(string.IsNullOrEmpty(iduser) || string.IsNullOrEmpty(token))
            {
                return Redirect("/Home/Error/" + (int)error.Autroy);
            }


            PaymentModelView modelView = new PaymentModelView();
            modelView.iduser = iduser;
            modelView.token = token;

          

            //modelView.products = await _context.GetdbProductListAllAsync();
            //modelView.dbbuyuser = await _context.buytypegetinfouser((byte)SoftWeare.yarviewer, long.Parse(YAR.Decrypt(iduser)), YAR.Decrypt(token));
            //if (modelView.dbbuyuser == null)
            //{
            //    return Redirect("/Home/Error/" + (int)error.Autroy);
            //}

            //if (modelView.dbbuyuser.idcode != 1)
            //{
            //    return Redirect("/Home/Error/" + (int)error.Autroy);
            //}


            return View(modelView);

        }

 

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PaymentProduct(int? typepost)
        {

            if (typepost==null)
            {
                return Redirect("/cbkala/Cart/NOCO");
            }

            if(typepost!=(int)sendposttype.postBus && typepost != (int)sendposttype.postPishtaz)
            {
                return Redirect("/cbkala/Card/NOCO");
            }

            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/cbkala/Card/NOCO");
            }

            var iduser = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(iduser) )
            {
                return Redirect("/cbkala/Cart/NOCO");
            }

            var subproduct = _context.sp_userfactorconfirm(iduser);

            if (subproduct.idcode == 2)
            {
                return Redirect("/cbkala/Cart/NOCO");
            }

            if (subproduct.money==0)
            {
                return Redirect("/cbkala/Cart/NOCO");
            }

            //مرچنت کد خود را وارد کنید
            var payment = await new Zarinpal.Payment("9c561c7a-7a07-11e9-ae3e-000c29344814", (int)subproduct.money)
                .PaymentRequest("حامد استوک",
                 Url.Action(nameof(PaymentVerify), "Payment", (int)subproduct.money, Request.Scheme));

            Verify verify = new Verify();
            verify.isVerify = false;
            verify.message = "عملیات ناموفق";
            verify.refid = 0;

            if (payment.Authority.Length==36)
            {
                verify.message = "دوباره تلاش کنید .";
                return View("Verify", verify);
            }


            if (payment.Status == 100)
            {
                var pay =  _context.sp_factorupdate(iduser, payment.Authority.ToString(), payment.Status.ToString(),(int)sendpaytype.onlion, (int)typepost);
                if (pay != null)
                    if (pay.idcode == 1)
                        return (IActionResult)Redirect("https://www.zarinpal.com/pg/StartPay/" + payment.Authority + "/ZarinGate");
                    else
                        return View("Verify", verify);
                else
                    return View("Verify", verify);
            }
            else
            {
                return View("Verify", verify);
            }

            return (IActionResult)Redirect("/Error/" + (int)error.paymentget);
        }


      

        public async Task<IActionResult> PaymentVerify(int amount, string Authority, string Status)
        {
            //توجه
            //بهتر است که به جای ارسال مبلغ به این متد، در این متد هم مبلغ را محاسبه کنید و سپس ادامه دهید.
            //****************
            Verify verify = new Verify();
            verify.isVerify = false;
            verify.message = "عملیات ناموفق";
            verify.refid = 0;

            if (Status == "NOK")
            {
                return View("Verify", verify);
            }
          
            //var iduser = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var pay = _context.sp_factorauthoritychecking(Authority);


            if(pay==null)
            {
                verify.message = "شناسه نامعتبر .";
                return View("Verify", verify);
            }

            if (pay.money<=0)
            {
                verify.message = "مبلغ صفر می باشد .";
                return View("Verify", verify);
            }

           


            ////گرفتن تاییدیه پرداخت
            var verification = await new Zarinpal
               .Payment("9c561c7a-7a07-11e9-ae3e-000c29344814", (Int32)pay.money)
               .Verification(Authority);


            verify.refid = verification.RefId;

            ////ارسال به صفحه خطا
            if (verification.Status != 100)
            {


                if (pay.idcode == 2)
                {
                    var dbsd = _context.sp_factorupdateforsyncbuyerror(Authority, verification.Status, verification.RefId.ToString());
                    verify.refid = verification.RefId;
                    verify.message = pay.message;
                    return View("Verify", verify);
                }



                var db = _context.sp_factorupdateforsuccessfulbuy(Authority, verification.Status, verification.RefId.ToString());
                verify.message = db.message;
                sms.sendMessage("","");
                return View("Verify", verify);
            }


         
            return View("Verify", verify);


        }
    }
}
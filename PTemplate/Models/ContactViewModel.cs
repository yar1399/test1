using PTemplate.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace PTemplate.Models.DataViewModel
{
    //public class ContactViewModel
    //{
    //    public bool isActiveMessage { set; get; }
    //    public string Messageuser { set; get; }

    //    [Required]
    //    [Display(Name = "نام")]
    //    public string name { get; set; }

    //    [Required]
    //    [EmailAddress]
    //    [Display(Name = "ادرس پست الترونیک")]
    //    public string email { get; set; }
    //    [Required]
    //    [Display(Name = "پیام")]
    //    public string message { get; set; }

    //    [Required]
    //    [Display(Name = "نوع پیام")]
    //    public byte idcontactType { get; set; }

    //    public SelectqutionContact qution { get; set; }

    //    public async Task<bool> InsertMessage(ApplicationDbContext context)
    //    {
    //        if (string.IsNullOrEmpty(name))
    //        {
    //            return false;
    //        }
    //        if (string.IsNullOrEmpty(email))
    //        {
    //            return false;
    //        }
    //        if (string.IsNullOrEmpty(message))
    //        {
    //            return false;
    //        }
    //        if (idcontactType>=4 || idcontactType<=0)
    //        {
    //            return false;
    //        }

    //        await context.contactinsert(idcontactType,0,name,email,message);

    //        return true;
    //    }

    //    public async Task Procass(ApplicationDbContext context)
    //    {
    //        if (await InsertMessage(context))
    //        {
    //            isActiveMessage = true;
    //            if (qution.idqu == "1")
    //                Messageuser = "با تشکر از سوال شما کاربر گرامی در سریع ترین زمان ممکن پاسخ به ایمیل شما ارسال می شود";
    //            else if (qution.idqu == "2")
    //                Messageuser = "کاربر گرامی پیشنهادات شما باعث بهتر شدن و تکامل و بهبود من دادرس خواهد شد";
    //            else if (qution.idqu == "3")
    //                Messageuser = "کاربر گرامی انتقاد شما باعث بهبود کیفیت و خدمات خواهد شد. من دادرس خواهد شد";
    //        }
    //        else
    //        {
    //            isActiveMessage = true;
    //            Messageuser = "لطفا برای پاسخ گویی و عمل کرد ما تمامی موارد خواسته شد در ارتباط با را تکمیل کنید.";
    //        }
    //    }
    //}
}

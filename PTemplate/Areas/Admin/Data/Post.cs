using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
using PTemplate.Models;

namespace PTemplate.Areas.Admin.Data
{
    //public partial class Post
    //{
    //    public Post()
    //    {
    //        Posttop = new HashSet<Posttop>();
    //    }

    //    [Key]
    //    [Required(ErrorMessage = "شماره پست را وارد نمائید")]
    //    [Display(Name = "شناسه ")]
    //    public long Id { get; set; }

    //    [Required(ErrorMessage = "شناسه کاربر را وارد نمائید")]
    //    [Display(Name = "شناسه کاربر ")]
    //    public string Iduser { get; set; }

    //    [Required(ErrorMessage = "نوع پست را وارد نمائید")]
    //    [Display(Name = "نوع پست ")]
    //    public byte? Idposttype { get; set; }

    //    [Required(ErrorMessage = "نوع نمایش را وارد نمائید")]
    //    [Display(Name = "نوع نمایش ")]
    //    public byte? Idposttoptype { get; set; }


    //    [Required(ErrorMessage = "زیر دسته را وارد نمائید")]
    //    [Display(Name = "زیر دسته ")]
    //    public long? Idmenu { get; set; }

    //    [Required(ErrorMessage = "عنوان را وارد نمائید")]
    //    [Display(Name = "عنوان ")]
    //    public string Title { get; set; }

    //    [Required(ErrorMessage = "توضیح را وارد نمائید")]
    //    [Display(Name = "توضیح ")]
    //    public string Description { get; set; }

    //    [Required(ErrorMessage = "متن را وارد نمائید")]
    //    [Display(Name = "متن ")]
    //    public string Text { get; set; }

    //    [Required(ErrorMessage = "داده را وارد نمائید")]
    //    [Display(Name = "داده ")]
    //    public string Pathdata { get; set; }

    //    [Required(ErrorMessage = "تاریخ ساخت را وارد نمائید")]
    //    [Display(Name = "تاریخ ساخت ")]
    //    public DateTime? Datecreate { get; set; }

    //    [Required(ErrorMessage = "فعال را وارد نمائید")]
    //    [Display(Name = "فعال ")]
    //    public bool? Isactive { get; set; }

    //    [Required(ErrorMessage = "فعال نوشتن را وارد نمائید")]
    //    [Display(Name = "نوشتن فعال ")]
    //    public bool? Iswrite { get; set; }

    //    public virtual Menu IdmenuNavigation { get; set; }
    //    public virtual Posttoptype IdposttoptypeNavigation { get; set; }
    //    public virtual Posttype IdposttypeNavigation { get; set; }
    //    public virtual ICollection<Posttop> Posttop { get; set; }
    //    //public virtual User IduserNavigation { get; set; }


    //}
}

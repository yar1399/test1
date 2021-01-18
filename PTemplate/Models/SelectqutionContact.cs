using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models
{
    public class SelectqutionContact
    {
        public string idqu { get; set; }

        public List<SelectListItem> qution { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "سوال" },
            new SelectListItem { Value = "2", Text = "پیشنهاد" },
            new SelectListItem { Value = "3", Text = "انتقاد"  },
        };
    }
}

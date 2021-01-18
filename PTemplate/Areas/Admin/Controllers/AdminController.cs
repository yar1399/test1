using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PTemplate.Areas.Admin.Controllers
{   
    
    [Authorize(Roles = "Manager,Admin,Oprator")]
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index(long? id)
        {
            return View();
        }
    }
}
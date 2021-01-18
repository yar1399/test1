using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PTemplate.Controllers
{
    public class ErrorController : Controller
    {

       

        public ErrorController()
        {
           
        }


        public IActionResult Index(int? id = 0)
        {
            ViewData["code"] = id;
            return View();
        }


        public IActionResult error(int? code = 0)
        {

            return View();
        }

       
       
    }
}
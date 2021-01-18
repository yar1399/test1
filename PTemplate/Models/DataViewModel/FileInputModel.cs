using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.DataViewModel
{
    public class  FileInputModel
    {
        [Required(ErrorMessage = "Please select a file.")]
     
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }
    }

}

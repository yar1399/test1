using PTemplate.Data.DataBase;
using System.Collections.Generic;

namespace PTemplate.Models.DataViewModel
{
    public class productViewModel
    {

        public Product product { get; set; }
       // public Product product { get; set; }

      public List<Productdatum> postdatas { get; set; }
      public List< Productcolor> procolor { get; set; }
      public List< Productinfo> productinfo { get; set; }


    }
}
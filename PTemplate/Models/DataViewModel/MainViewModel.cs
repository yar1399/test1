using PTemplate.Areas.Admin.Data;
using PTemplate.Data;
using PTemplate.Data.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.DataViewModel
{
    public class MainViewModel
    {
        ApplicationDbContext _context;
    

      public List<Menugroup> menugroup { set; get; }
      public Post postTak { set; get; }
      public List<Post> ListPost { set; get; }
      public List<Post> ListPostVideo { set; get; }
      public List<Post> ListPostImageText { set; get; }
    

      


    }
}

using PTemplate.Data;
using PTemplate.Data.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.DataViewModel
{
    public class MaindadarasViewModel
    {

        ApplicationDbContext _context;


        public List<Menugroup> menugroup { set; get; }
        public Post postTak { set; get; }
        public List<Post> ListPostTopSlide { set; get; }
        public List<Post> ListPostMusic { set; get; }
        public List<Post> ListPost { set; get; }
        public List<Post> ListPostpadkast { set; get; }
        public List<Post> ListPostVideo { set; get; }

        public List<Post> ListPostImageText;
        public List<Post> ListPostnews { set; get; }





    }
}

using PTemplate.Data.DataBase;
using PTemplate.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.DataViewModel
{

    public class StoryViewModel
    {
        public List<productStory> Sliders { get; set; }
        public productStory biner { get; set; }
        public List<productStory> lastproducts { get; set; }
        public List<productStory> products { get; set; }
        public List<subfactorlist> subfactors { get; set; }


        public List<Menugroup> menus  { get; set; }

        public decimal sumsubfactor { get; set; }
        public decimal sumoffer { get; set; }


    }

}

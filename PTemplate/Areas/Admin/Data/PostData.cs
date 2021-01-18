using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Areas.Admin.Data
{
    public partial class PostData
    {
        public PostData()
        {
          
        }

        [Key]
        public long id { set; get; }
        public long idpost { set; get; }



        //public long? Idpost
        //{
        //    get { return idpost;  }
        //    set { idpost = value; }
        //}
        public byte? iddatatype { set; get; }
        public string pathdata { set; get; }
        public bool isactive { set; get; }
        public string description { set; get; }

     
        //public virtual Post IdpostNavigation { get; set; }

        //public virtual datatype datype { get; set; }



    }
}

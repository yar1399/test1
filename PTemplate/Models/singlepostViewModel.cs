using PTemplate.Areas.Admin.Data;
using PTemplate.Data.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.DataViewModel
{
    public class singlepostViewModel
    {
        public singlepostViewModel(Post post, List<Postdatum> postData)
        {
            this.postData = postData;
            this.post = post;
        }
        public Post post { set; get; }
        public List<Postdatum> postData { set; get; }

    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Browser
    {
        public Browser()
        {
            StUsers = new HashSet<StUser>();
        }

        public int Id { get; set; }
        public string ImageName { get; set; }
        public string BrowsersKey { get; set; }
        public string BrowsersName { get; set; }
        public string BrowsersNameFa { get; set; }
        public string Tag { get; set; }
        public string Color { get; set; }

        public virtual ICollection<StUser> StUsers { get; set; }
    }
}

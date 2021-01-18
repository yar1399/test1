using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Comment
    {
        public int Id { get; set; }
        public byte? Idsoftwaremodel { get; set; }
        public string Text { get; set; }
        public string Iduser { get; set; }

        public virtual Softwaremodel IdsoftwaremodelNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}

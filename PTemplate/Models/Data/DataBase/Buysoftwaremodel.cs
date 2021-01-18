using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Buysoftwaremodel
    {
        public Buysoftwaremodel()
        {
            Buytypes = new HashSet<Buytype>();
            Buyusertimes = new HashSet<Buyusertime>();
        }

        public int Id { get; set; }
        public byte? Idsoftwaremodel { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Usercounts { get; set; }
        public bool? Isactive { get; set; }

        public virtual Softwaremodel IdsoftwaremodelNavigation { get; set; }
        public virtual ICollection<Buytype> Buytypes { get; set; }
        public virtual ICollection<Buyusertime> Buyusertimes { get; set; }
    }
}

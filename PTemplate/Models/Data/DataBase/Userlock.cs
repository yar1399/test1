using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Userlock
    {
        public int Id { get; set; }
        public string Iduser { get; set; }
        public long? Iduseroprator { get; set; }
        public byte? Iduserlocktype { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }

        public virtual User IduserNavigation { get; set; }
        public virtual Userlocktype IduserlocktypeNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Profileuserregioncity
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public int? Idprovince { get; set; }
        public int? Idcounty { get; set; }
        public int? Idcity { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}

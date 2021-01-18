using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Buysoftwaremodelusercount
    {
        public Guid Id { get; set; }
        public long? Idparentbuyusertime { get; set; }
        public string Idsystem { get; set; }
        public byte? Idsoftwaremodel { get; set; }
        public string Systemloginname { get; set; }
        public byte? Idos { get; set; }
    }
}

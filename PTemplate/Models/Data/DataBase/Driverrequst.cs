using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Driverrequst
    {
        public long Id { get; set; }
        public long? Iduserdriver { get; set; }
        public long? Iduser { get; set; }
        public byte? Idrequstsate { get; set; }
        public DateTime? Datecreate { get; set; }
        public DateTime? Dateend { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Vipuser
    {
        public Guid Id { get; set; }
        public long? Iduser { get; set; }
        public int? Idvip { get; set; }
        public DateTime? Date { get; set; }
        public string Expiredate { get; set; }
        public string Status { get; set; }
    }
}

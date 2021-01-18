using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Valuebody
    {
        public Guid Id { get; set; }
        public byte? Idvalue { get; set; }
        public long? Idclient { get; set; }
        public decimal? Value { get; set; }
        public DateTime Date { get; set; }
        public long? Iduser { get; set; }
    }
}

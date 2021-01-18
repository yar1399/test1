using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Moveratinguser
    {
        public Guid Id { get; set; }
        public long? Iduser { get; set; }
        public int? Idmove { get; set; }
        public DateTime? Cratedate { get; set; }
        public float? Rate { get; set; }

        public virtual Move IdmoveNavigation { get; set; }
    }
}

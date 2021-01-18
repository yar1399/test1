using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Movesport
    {
        public Guid Id { get; set; }
        public byte? Idsport { get; set; }
        public int? Idmove { get; set; }

        public virtual Move IdmoveNavigation { get; set; }
    }
}

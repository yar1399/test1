using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Move
    {
        public Move()
        {
            Moveinfos = new HashSet<Moveinfo>();
            Moveratingusers = new HashSet<Moveratinguser>();
            Movesports = new HashSet<Movesport>();
        }

        public int Id { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isfree { get; set; }
        public string Name { get; set; }
        public string Namefa { get; set; }
        public float? Rating { get; set; }

        public virtual ICollection<Moveinfo> Moveinfos { get; set; }
        public virtual ICollection<Moveratinguser> Moveratingusers { get; set; }
        public virtual ICollection<Movesport> Movesports { get; set; }
    }
}

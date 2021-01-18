using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class StUser
    {
        public StUser()
        {
            StatesticsDetils = new HashSet<StatesticsDetil>();
        }

        public int Id { get; set; }
        public int? StId { get; set; }
        public string KeyId { get; set; }
        public int? BroserId { get; set; }
        public int? OsId { get; set; }
        public string Iduser { get; set; }

        public virtual Browser Broser { get; set; }
        public virtual Oss Os { get; set; }
        public virtual Statestic St { get; set; }
        public virtual ICollection<StatesticsDetil> StatesticsDetils { get; set; }
    }
}

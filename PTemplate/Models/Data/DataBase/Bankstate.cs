using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Bankstate
    {
        public Bankstate()
        {
            Factor1s = new HashSet<Factor1>();
        }

        public int Id { get; set; }
        public byte? Idbanktype { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Code { get; set; }

        public virtual Banktype IdbanktypeNavigation { get; set; }
        public virtual ICollection<Factor1> Factor1s { get; set; }
    }
}

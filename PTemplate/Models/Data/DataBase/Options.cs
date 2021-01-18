using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Options
    {
        public Options()
        {
            Softwaremodeloptions = new HashSet<Softwaremodeloptions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? Idsoftwaremodel { get; set; }

        public virtual Softwaremodel IdsoftwaremodelNavigation { get; set; }
        public virtual ICollection<Softwaremodeloptions> Softwaremodeloptions { get; set; }
    }
}

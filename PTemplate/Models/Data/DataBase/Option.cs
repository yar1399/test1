using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Option
    {
        public Option()
        {
            Softwaremodeloptions = new HashSet<Softwaremodeloption>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? Idsoftwaremodel { get; set; }

        public virtual Softwaremodel IdsoftwaremodelNavigation { get; set; }
        public virtual ICollection<Softwaremodeloption> Softwaremodeloptions { get; set; }
    }
}

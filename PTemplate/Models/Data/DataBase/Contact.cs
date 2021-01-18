using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Contact
    {
        public long Id { get; set; }
        public byte? Idcontacttype { get; set; }
        public byte? Idsoftwaremodel { get; set; }
        public string Iduser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public virtual Contacttype IdcontacttypeNavigation { get; set; }
        public virtual Softwaremodel IdsoftwaremodelNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}

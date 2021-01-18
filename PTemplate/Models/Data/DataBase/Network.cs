using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Network
    {
        public Network()
        {
            Menu1s = new HashSet<Menu1>();
            Networkdescriptions = new HashSet<Networkdescription>();
            Networkprofilemedia = new HashSet<Networkprofilemedium>();
            Networksettingusers = new HashSet<Networksettinguser>();
            Networkshoppings = new HashSet<Networkshopping>();
            Networkshoppingtells = new HashSet<Networkshoppingtell>();
            Networktells = new HashSet<Networktell>();
            Usermedia = new HashSet<Usermedium>();
        }

        public long Id { get; set; }
        public byte? Idnetworktype { get; set; }
        public string Iduser { get; set; }
        public string Nickname { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isactiveoprator { get; set; }
        public bool? Isdeletesystem { get; set; }
        public DateTime? Createnetworkdate { get; set; }
        public DateTime? Createdatedelete { get; set; }

        public virtual Networktype IdnetworktypeNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
        public virtual ICollection<Menu1> Menu1s { get; set; }
        public virtual ICollection<Networkdescription> Networkdescriptions { get; set; }
        public virtual ICollection<Networkprofilemedium> Networkprofilemedia { get; set; }
        public virtual ICollection<Networksettinguser> Networksettingusers { get; set; }
        public virtual ICollection<Networkshopping> Networkshoppings { get; set; }
        public virtual ICollection<Networkshoppingtell> Networkshoppingtells { get; set; }
        public virtual ICollection<Networktell> Networktells { get; set; }
        public virtual ICollection<Usermedium> Usermedia { get; set; }
    }
}

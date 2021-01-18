using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class User
    {
        public User()
        {
            Buyusertimes = new HashSet<Buyusertime>();
            Comments = new HashSet<Comment>();
            Contacts = new HashSet<Contact>();
            LockCounters = new HashSet<LockCounter>();
            Networkname1s = new HashSet<Networkname1>();
            Networks = new HashSet<Network>();
            Pays = new HashSet<Pay>();
            Softwaremodeloptions = new HashSet<Softwaremodeloption>();
            UserRoles = new HashSet<UserRole>();
            Useractives = new HashSet<Useractive>();
            Userdeletes = new HashSet<Userdelete>();
            Useremailconfirmations = new HashSet<Useremailconfirmation>();
            Useremails = new HashSet<Useremail>();
            Userlocks = new HashSet<Userlock>();
            Userpasses = new HashSet<Userpass>();
            Usersystemips = new HashSet<Usersystemip>();
            Usertellconfirmations = new HashSet<Usertellconfirmation>();
            Usertells = new HashSet<Usertell>();
            Usertokens = new HashSet<Usertoken>();
        }

        public string Id { get; set; }
        public DateTime Datecreate { get; set; }

        public virtual ICollection<Buyusertime> Buyusertimes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<LockCounter> LockCounters { get; set; }
        public virtual ICollection<Networkname1> Networkname1s { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<Pay> Pays { get; set; }
        public virtual ICollection<Softwaremodeloption> Softwaremodeloptions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Useractive> Useractives { get; set; }
        public virtual ICollection<Userdelete> Userdeletes { get; set; }
        public virtual ICollection<Useremailconfirmation> Useremailconfirmations { get; set; }
        public virtual ICollection<Useremail> Useremails { get; set; }
        public virtual ICollection<Userlock> Userlocks { get; set; }
        public virtual ICollection<Userpass> Userpasses { get; set; }
        public virtual ICollection<Usersystemip> Usersystemips { get; set; }
        public virtual ICollection<Usertellconfirmation> Usertellconfirmations { get; set; }
        public virtual ICollection<Usertell> Usertells { get; set; }
        public virtual ICollection<Usertoken> Usertokens { get; set; }
    }
}

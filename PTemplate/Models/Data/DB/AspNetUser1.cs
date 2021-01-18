using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class AspNetUser1
    {
        public AspNetUser1()
        {
            AspNetUserClaim1s = new HashSet<AspNetUserClaim1>();
            //AspNetUserLogin1s = new HashSet<AspNetUserLogin1>();
            //AspNetUserToken1s = new HashSet<AspNetUserToken1>();
            Factor1s = new HashSet<Factor1>();
            Productaddresses = new HashSet<Productaddress>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<AspNetUserClaim1> AspNetUserClaim1s { get; set; }
        //public virtual ICollection<AspNetUserLogin1> AspNetUserLogin1s { get; set; }
        //public virtual ICollection<AspNetUserToken1> AspNetUserToken1s { get; set; }
        public virtual ICollection<Factor1> Factor1s { get; set; }
        public virtual ICollection<Productaddress> Productaddresses { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class AspNetUsers1
    {
        public AspNetUsers1()
        {

            AspNetUserClaims = new HashSet<AspNetUserClaims1>();
            //AspNetUserLogins = new HashSet<AspNetUserLogin1>();
            //AspNetUserRoles = new HashSet<AspNetUserRoles1>();
            //AspNetUserTokens = new HashSet<AspNetUserToken1>();
            Factor1 = new HashSet<Factor1>();
            //Imageprofile = new HashSet<Imageprofile>();
            Productaddress = new HashSet<Productaddress>();

        }

        [System.ComponentModel.DataAnnotations.Key]
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

        public virtual ICollection<AspNetUserClaims1> AspNetUserClaims { get; set; }
        //public virtual ICollection<AspNetUserLogin1> AspNetUserLogins { get; set; }
        //public virtual ICollection<AspNetUserRoles1> AspNetUserRoles { get; set; }
        //public virtual ICollection<AspNetUserToken1> AspNetUserTokens { get; set; }
        public virtual ICollection<Factor1> Factor1 { get; set; }
        //public virtual ICollection<Imageprofile> Imageprofile { get; set; }
        public virtual ICollection<Productaddress> Productaddress { get; set; }
    }


}
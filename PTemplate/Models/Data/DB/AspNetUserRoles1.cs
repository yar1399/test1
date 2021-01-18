using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    [Keyless]
    public partial class AspNetUserRoles1
    {
       
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRole1 Role { get; set; }
        public virtual AspNetUsers1 User { get; set; }
    }
}

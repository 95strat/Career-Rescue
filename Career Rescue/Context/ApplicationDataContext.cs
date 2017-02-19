using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Career_Rescue.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Career_Rescue.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}
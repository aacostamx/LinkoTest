using LinkoTest.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkoTest.DataAccess
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext() : base("LinkoConnection")
        {

        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}
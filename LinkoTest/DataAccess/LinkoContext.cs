using LinkoTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LinkoTest.DataAccess
{
    public class LinkoContext : DbContext
    {
        public DbSet<Libro> Libros { get; set; }

        public LinkoContext() : base("LinkoConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
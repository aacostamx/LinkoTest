namespace LinkoTest.DataAccess.IdentityMigrations
{
    using LinkoTest.Models;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LinkoTest.DataAccess.IdentityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"DataAccess\IdentityMigrations";
        }

        protected override void Seed(LinkoTest.DataAccess.IdentityContext context)
        {
            string password = string.Empty;
            var passwordHash = new PasswordHasher();

            password = passwordHash.HashPassword("Linko#1");
            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    Email = "antonio@linko.mx",
                    UserName = "antonio@linko.mx",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = password
                });

            password = passwordHash.HashPassword("Linko#2");
            context.Users.AddOrUpdate(u => u.UserName,
            new ApplicationUser
            {
                Email = "bmartinez@linko.mx",
                UserName = "bmartinez@linko.mx",
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = password
            });

            password = passwordHash.HashPassword("Linko#3");
            context.Users.AddOrUpdate(u => u.UserName,
            new ApplicationUser
            {
                Email = "prueba@linko.mx",
                UserName = "prueba@linko.mx",
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = password
            });
        }
    }
}

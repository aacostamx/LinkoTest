namespace LinkoTest.DataAccess.LinkoMigrations
{
    using LinkoTest.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LinkoTest.DataAccess.LinkoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataAccess\LinkoMigrations";
        }

        protected override void Seed(LinkoTest.DataAccess.LinkoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Libros.AddOrUpdate(li => li.LibroId,
                new Libro { NombreLibro = "Pedro P�ramo", Autor = "Juan Rulfo", ISBN = "978-1-60309" },
                new Libro { NombreLibro = "Aura", Autor = "Carlos Fuentes", ISBN = "978-1-60309" },
                new Libro { NombreLibro = "Hasta no verte, Jes�s m�o", Autor = "Elena Poniatowska", ISBN = "" },
                new Libro { NombreLibro = "La feria", Autor = " Juan Jos� Arreola", ISBN = "978-1-60309" },
                new Libro { NombreLibro = "Batallas en el desierto", Autor = "Jos� Emilio Pacheco", ISBN = "" },
                new Libro { NombreLibro = "El laberinto de la soledad", Autor = "Octavio Paz", ISBN = "" },
                new Libro { NombreLibro = "Los pasos de L�pez", Autor = "Jorge Ibarg�engoitia", ISBN = "978-1-60309" },
                new Libro { NombreLibro = "La tumba", Autor = "Jos� Agust�n", ISBN = "978-1-89183" },
                new Libro { NombreLibro = "Bal�n Can�n", Autor = "Rosario Castellanos", ISBN = "978-1-89183" }
            );


        }
    }
}

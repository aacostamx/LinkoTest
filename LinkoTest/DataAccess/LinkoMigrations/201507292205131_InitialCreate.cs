namespace LinkoTest.DataAccess.LinkoMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        LibroId = c.Int(nullable: false, identity: true),
                        NombreLibro = c.String(nullable: false, maxLength: 70),
                        Autor = c.String(nullable: false, maxLength: 45),
                        ISBN = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => t.LibroId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Libro");
        }
    }
}

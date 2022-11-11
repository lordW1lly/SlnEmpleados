namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creandoDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Legajo = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Departamento_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departamentoes", t => t.Departamento_Id)
                .Index(t => t.Departamento_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleadoes", "Departamento_Id", "dbo.Departamentoes");
            DropIndex("dbo.Empleadoes", new[] { "Departamento_Id" });
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Departamentoes");
        }
    }
}

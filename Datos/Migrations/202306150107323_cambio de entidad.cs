namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiodeentidad : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Detalle", new[] { "articuloID" });
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Fealt = c.DateTime(),
                        Femod = c.DateTime(),
                        Febaj = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Detalle", "ArticuloID");
            DropTable("dbo.categoria");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.categoria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        fealt = c.DateTime(),
                        femod = c.DateTime(),
                        febaj = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            DropIndex("dbo.Detalle", new[] { "ArticuloID" });
            DropTable("dbo.Categoria");
            CreateIndex("dbo.Detalle", "articuloID");
        }
    }
}

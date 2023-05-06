namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class caja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caja",
                c => new
                    {
                        idcaja = c.Int(nullable: false, identity: true),
                        fecha_inicio = c.DateTime(nullable: false),
                        fecha_cierre = c.DateTime(),
                    })
                .PrimaryKey(t => t.idcaja);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Caja");
        }
    }
}

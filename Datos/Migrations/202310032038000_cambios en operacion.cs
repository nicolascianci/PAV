namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosenoperacion : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Operacion", "TotalSinDescuento");
            DropColumn("dbo.Operacion", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Operacion", "Total", c => c.Double(nullable: false));
            AddColumn("dbo.Operacion", "TotalSinDescuento", c => c.Double(nullable: false));
        }
    }
}

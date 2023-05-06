namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class avance2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.articulo", "stock", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.articulo", "stock", c => c.Int(nullable: false));
        }
    }
}

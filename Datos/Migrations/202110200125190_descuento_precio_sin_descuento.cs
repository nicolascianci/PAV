namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class descuento_precio_sin_descuento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operacion", "totas_sin_descuento", c => c.Double(nullable: false));
            AddColumn("dbo.Operacion", "descuento", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operacion", "descuento");
            DropColumn("dbo.Operacion", "totas_sin_descuento");
        }
    }
}

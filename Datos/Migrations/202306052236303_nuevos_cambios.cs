namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevos_cambios : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Detalle", name: "ID_Operacion", newName: "IDOperacion");
            RenameIndex(table: "dbo.Detalle", name: "IX_ID_Operacion", newName: "IX_IDOperacion");
            AddColumn("dbo.Caja", "FechaInicio", c => c.DateTime(nullable: false));
            AddColumn("dbo.Caja", "FechaCierre", c => c.DateTime());
            AddColumn("dbo.Detalle", "precioUnitario", c => c.Double(nullable: false));
            AddColumn("dbo.Operacion", "TipoOperacion", c => c.Int(nullable: false));
            AddColumn("dbo.Operacion", "puntoVenta", c => c.Int(nullable: false));
            AddColumn("dbo.Operacion", "numeroVenta", c => c.Int(nullable: false));
            AddColumn("dbo.Operacion", "totalSinDescuento", c => c.Double(nullable: false));
            CreateIndex("dbo.articulo", "CategoriaId");
            AddForeignKey("dbo.articulo", "CategoriaId", "dbo.categoria", "id");
            DropColumn("dbo.Caja", "fecha_inicio");
            DropColumn("dbo.Caja", "fecha_cierre");
            DropColumn("dbo.Detalle", "precio_unitario");
            DropColumn("dbo.Operacion", "Tipo_operacion");
            DropColumn("dbo.Operacion", "punto_venta");
            DropColumn("dbo.Operacion", "numero_venta");
            DropColumn("dbo.Operacion", "totas_sin_descuento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Operacion", "totas_sin_descuento", c => c.Double(nullable: false));
            AddColumn("dbo.Operacion", "numero_venta", c => c.Int(nullable: false));
            AddColumn("dbo.Operacion", "punto_venta", c => c.Int(nullable: false));
            AddColumn("dbo.Operacion", "Tipo_operacion", c => c.Int(nullable: false));
            AddColumn("dbo.Detalle", "precio_unitario", c => c.Double(nullable: false));
            AddColumn("dbo.Caja", "fecha_cierre", c => c.DateTime());
            AddColumn("dbo.Caja", "fecha_inicio", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.articulo", "CategoriaId", "dbo.categoria");
            DropIndex("dbo.articulo", new[] { "CategoriaId" });
            DropColumn("dbo.Operacion", "totalSinDescuento");
            DropColumn("dbo.Operacion", "numeroVenta");
            DropColumn("dbo.Operacion", "puntoVenta");
            DropColumn("dbo.Operacion", "TipoOperacion");
            DropColumn("dbo.Detalle", "precioUnitario");
            DropColumn("dbo.Caja", "FechaCierre");
            DropColumn("dbo.Caja", "FechaInicio");
            RenameIndex(table: "dbo.Detalle", name: "IX_IDOperacion", newName: "IX_ID_Operacion");
            RenameColumn(table: "dbo.Detalle", name: "IDOperacion", newName: "ID_Operacion");
        }
    }
}

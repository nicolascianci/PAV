namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class avance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.articulo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        CostoSinIva = c.Double(nullable: false),
                        PorcentajeIva = c.Double(nullable: false),
                        MargenDeGanancia = c.Double(nullable: false),
                        Estado = c.Int(nullable: false),
                        fealt = c.DateTime(),
                        femod = c.DateTime(),
                        febaj = c.DateTime(),
                        stock = c.Int(nullable: false),
                        CategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
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
            
            CreateTable(
                "dbo.Detalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ID_Operacion = c.Int(),
                        articuloID = c.Int(nullable: false),
                        precio_unitario = c.Double(nullable: false),
                        cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.articulo", t => t.articuloID, cascadeDelete: true)
                .ForeignKey("dbo.Operacion", t => t.ID_Operacion)
                .Index(t => t.ID_Operacion)
                .Index(t => t.articuloID);
            
            CreateTable(
                "dbo.Operacion",
                c => new
                    {
                        ID_Operacion = c.Int(nullable: false, identity: true),
                        Tipo_operacion = c.Int(nullable: false),
                        punto_venta = c.Int(nullable: false),
                        numero_venta = c.Int(nullable: false),
                        total = c.Double(nullable: false),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Operacion);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detalle", "ID_Operacion", "dbo.Operacion");
            DropForeignKey("dbo.Detalle", "articuloID", "dbo.articulo");
            DropIndex("dbo.Detalle", new[] { "articuloID" });
            DropIndex("dbo.Detalle", new[] { "ID_Operacion" });
            DropTable("dbo.Operacion");
            DropTable("dbo.Detalle");
            DropTable("dbo.categoria");
            DropTable("dbo.articulo");
        }
    }
}

namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeros_cambios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        CostoSinIva = c.Double(nullable: false),
                        PorcentajeIva = c.Double(nullable: false),
                        MargenDeGanancia = c.Double(nullable: false),
                        Estado = c.Int(nullable: false),
                        Fealt = c.DateTime(),
                        Femod = c.DateTime(),
                        Febaj = c.DateTime(),
                        Stock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId)
                .Index(t => t.CategoriaId);
            
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
            
            CreateTable(
                "dbo.Caja",
                c => new
                    {
                        IdCaja = c.Int(nullable: false, identity: true),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaCierre = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdCaja);
            
            CreateTable(
                "dbo.Detalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDOperacion = c.Int(),
                        ArticuloID = c.Int(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Articulo", t => t.ArticuloID, cascadeDelete: true)
                .ForeignKey("dbo.Operacion", t => t.IDOperacion)
                .Index(t => t.IDOperacion)
                .Index(t => t.ArticuloID);
            
            CreateTable(
                "dbo.Operacion",
                c => new
                    {
                        ID_Operacion = c.Int(nullable: false, identity: true),
                        TipoOperacion = c.Int(nullable: false),
                        PuntoVenta = c.Int(nullable: false),
                        NumeroVenta = c.Int(nullable: false),
                        TotalSinDescuento = c.Double(nullable: false),
                        Descuento = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Operacion);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detalle", "IDOperacion", "dbo.Operacion");
            DropForeignKey("dbo.Detalle", "ArticuloID", "dbo.Articulo");
            DropForeignKey("dbo.Articulo", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.Detalle", new[] { "ArticuloID" });
            DropIndex("dbo.Detalle", new[] { "IDOperacion" });
            DropIndex("dbo.Articulo", new[] { "CategoriaId" });
            DropTable("dbo.Operacion");
            DropTable("dbo.Detalle");
            DropTable("dbo.Caja");
            DropTable("dbo.Categoria");
            DropTable("dbo.Articulo");
        }
    }
}

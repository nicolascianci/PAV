using Dominio;
using Dominio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Datos
{
    public class R_ABMArticulos
    {
        private Modelo repositorio;

        public R_ABMArticulos()
        {
            repositorio = new Modelo();
        }

        public List<GestionArticulosViewModel> Actualizar()
        {
            return repositorio.articulos.Where(x => x.febaj == null).Select(p => new GestionArticulosViewModel
            {
                IdArticulo = p.id,
                descripcionArticulo = p.Descripcion,
                costoSinIva = p.CostoSinIva,
                costoConIva = p.CostoConIva,
                precioFinal = p.Preciofinal,
                estadoProducto = p.Estado,
                nombreCategoria = p.categoria.Nombre
            }).ToList();
        }

        public void AgregarProducto(articulo p)
        {
            //int id_siguiente = repositorio.articulos.OrderByDescending(x => x.id).FirstOrDefault().id + 1;
            p.fealt = DateTime.Now;
            //p.id = id_siguiente;
            
            repositorio.articulos.Add(p);
            repositorio.SaveChanges();
        }

        public void EditarProducto(articulo p)
        {
            articulo _articulo = repositorio.articulos.Where(x => x.id == p.id).FirstOrDefault();

            _articulo.id = p.id;
            _articulo.Codigo = p.Codigo;
            _articulo.Descripcion = p.Descripcion;
            _articulo.CostoSinIva = p.CostoSinIva;
            _articulo.PorcentajeIva = p.PorcentajeIva;
            _articulo.MargenDeGanancia = p.MargenDeGanancia;
            _articulo.Estado = p.Estado;
            _articulo.femod = DateTime.Now;
            _articulo.stock = p.stock;
            _articulo.CategoriaId = p.CategoriaId;
            _articulo.categoria = p.categoria;            
            
            
            repositorio.SaveChanges();
        }

        public void EliminarProducto(articulo p)
        {
            var _producto = repositorio.articulos.Where(x => x.id == p.id).FirstOrDefault();
            _producto.febaj = DateTime.Now;
            //repositorio.articulos.Remove(_producto);
            repositorio.SaveChanges();
        }

        public List<GestionArticulosViewModel> BuscarProductos(string nombre)
        {
            return repositorio.articulos.Where(x => x.Descripcion.Contains(nombre)).Select(p => new GestionArticulosViewModel
            {
                IdArticulo = p.id,
                descripcionArticulo = p.Descripcion,
                costoConIva = p.CostoConIva,
                costoSinIva = p.CostoSinIva,
                precioFinal = p.Preciofinal,
                estadoProducto = p.Estado,
                nombreCategoria = p.categoria.Nombre
            }).ToList();
        }

        public List<categoria> Buscar_Todas_Categorias()
        {
            return repositorio.categorias.Where(x => x.febaj == null).ToList();
        }

        public List<CategoriaViewModel> Buscar_Todas_Categorias_Item()
        {
            List<CategoriaViewModel> lista_tmp = new List<CategoriaViewModel>();

            lista_tmp = repositorio.categorias.Where(x => x.febaj == null).Select(p => new CategoriaViewModel
            {
                idCategoria = p.id,
                nombreCategoria = p.Nombre
            }).ToList();

            return lista_tmp;
        }

        public categoria GetCategoria(int idcategoria)
        {
            return repositorio.categorias.Where(p => p.febaj == null && p.id == idcategoria).FirstOrDefault();
        }

        public articulo BuscarArticuloId(int idarticulo)
        {
            return repositorio.articulos.Where(p => p.febaj == null && p.id == idarticulo).FirstOrDefault();
        }
    }
}

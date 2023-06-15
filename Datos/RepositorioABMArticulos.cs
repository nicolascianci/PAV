using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Datos
{
    public class RepositorioABMArticulos
    {
        private Modelo _repositorio;

        public RepositorioABMArticulos()
        {
            _repositorio = new Modelo();
        }

        public List<Articulo> Actualizar()
        {
            return _repositorio.articulos.Where(x => x.Febaj == null).ToList();
        }

        public void AgregarProducto(Articulo p)
        {            
            p.Fealt = DateTime.Now;            
            
            _repositorio.articulos.Add(p);
            _repositorio.SaveChanges();
        }

        public void EditarProducto(Articulo p)
        {
            Articulo _articulo = _repositorio.articulos.Where(x => x.Id == p.Id).FirstOrDefault();

            _articulo.Id = p.Id;
            _articulo.Codigo = p.Codigo;
            _articulo.Descripcion = p.Descripcion;
            _articulo.CostoSinIva = p.CostoSinIva;
            _articulo.PorcentajeIva = p.PorcentajeIva;
            _articulo.MargenDeGanancia = p.MargenDeGanancia;
            _articulo.Estado = p.Estado;
            _articulo.Femod = DateTime.Now;
            _articulo.Stock = p.Stock;
            _articulo.CategoriaId = p.CategoriaId;
            _articulo.Categoria = p.Categoria;            
            
            
            _repositorio.SaveChanges();
        }

        public void EliminarProducto(Articulo p)
        {
            var _producto = _repositorio.articulos.Where(x => x.Id == p.Id).FirstOrDefault();
            _producto.Febaj = DateTime.Now;
            //repositorio.articulos.Remove(_producto);
            _repositorio.SaveChanges();
        }

        public Articulo BuscarArticulo(int idArticulo)
        {
            return _repositorio.articulos.Where(p => p.Febaj == null && p.Id == idArticulo).FirstOrDefault();
        }

        public List<Articulo> BuscarProductos(string nombre)
        {
            return _repositorio.articulos.Where(x => x.Descripcion.Contains(nombre)).ToList();
        }

        public List<Categoria> BuscarTodasCategorias()
        {
            return _repositorio.Categorias.Where(x => x.Febaj == null).ToList();
        }
        

        public Categoria GetCategoria(int idCategoria)
        {
            return _repositorio.Categorias.Where(p => p.Febaj == null && p.Id == idCategoria).FirstOrDefault();
        }        
    }
}

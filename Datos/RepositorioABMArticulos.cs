using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Windows.Forms;

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
            return _repositorio.Articulos.Where(x => x.Febaj == null).ToList();
        }

        public void AgregarProducto(Articulo p)
        {            
            p.Fealt = DateTime.Now;            
            
            _repositorio.Articulos.Add(p);
            _repositorio.SaveChanges();
        }

        public void EditarProducto(Articulo p)
        {
            Articulo _articulo = _repositorio.Articulos.Where(x => x.Id == p.Id).FirstOrDefault();

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
            var _producto = _repositorio.Articulos.Where(x => x.Id == p.Id).FirstOrDefault();
            _producto.Febaj = DateTime.Now;
            //repositorio.articulos.Remove(_producto);
            _repositorio.SaveChanges();
        }

        public Articulo BuscarArticulo(int idArticulo)
        {
            return _repositorio.Articulos.Where(p => p.Febaj == null && p.Id == idArticulo).FirstOrDefault();
        }

        public List<Articulo> BuscarProductos(string nombre)
        {
            return _repositorio.Articulos.Where(x => x.Descripcion.Contains(nombre)).ToList();
        }

        public List<Categoria> BuscarTodasCategorias()
        {
            return _repositorio.Categorias.Where(x => x.Febaj == null).ToList();
        }
        

        public Categoria GetCategoria(int idCategoria)
        {
            return _repositorio.Categorias.Where(p => p.Febaj == null && p.Id == idCategoria).FirstOrDefault();
        }

        public bool ValidarArticulo(Articulo articulo)
        {
            Articulo _articulo = _repositorio.Articulos.Where(p => p.Codigo == articulo.Codigo).FirstOrDefault();

            if(_articulo != null && _articulo.Id != articulo.Id)
            {
                MessageBox.Show("Existe otro articulo con el mismo Codigo.", "Validar Articulo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(articulo.Descripcion == null || articulo.Descripcion == string.Empty)
            {
                MessageBox.Show("Debe escribir la descripcion del articulo.", "Validar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(articulo.CostoSinIva <= 0)
            {
                MessageBox.Show("El Precio del costo debe ser mayor a 0.", "Validar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(articulo.PorcentajeIva < 0)
            {
                MessageBox.Show("El porcentaje de IVA debe ser positivo.", "Validar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (articulo.MargenDeGanancia <= 0)
            {
                MessageBox.Show("El margen de ganancia debe ser mayor a 0.", "Validar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

using Datos;
using Dominio;
using Dominio.ViewModels;
using Interfaces;
using Sistema.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
    public class PresentadorGestionArticulos
    {
        IGestionProducto _vista;
        RepositorioABMArticulos _repositorio;

        public PresentadorGestionArticulos(IGestionProducto vistaPar)
        {
            _vista = vistaPar;
            _repositorio = new RepositorioABMArticulos();
        }


        public List<GestionArticulosViewModel> ActualizarListado()
        {
            return _repositorio.Actualizar().Select(p => new GestionArticulosViewModel
            {
                IdArticulo = p.Id,
                DescripcionArticulo = p.Descripcion,
                CostoSinIva = p.CostoSinIva,
                CostoConIva = p.CostoConIva,
                PrecioFinal = p.Preciofinal,
                EstadoProducto = p.Estado,
                NombreCategoria = p.Categoria.Nombre
            }).ToList();
            
        }

        public List<GestionArticulosViewModel> BuscarProductos(string nombre)
        {
            
            return _repositorio.BuscarProductos(nombre).Select(p => new GestionArticulosViewModel
            {
                IdArticulo = p.Id,
                DescripcionArticulo = p.Descripcion,
                CostoSinIva = p.CostoSinIva,
                CostoConIva = p.CostoConIva,
                PrecioFinal = p.Preciofinal,
                EstadoProducto = p.Estado,
                NombreCategoria = p.Categoria.Nombre
            }).ToList(); ;
            
        }

        public void AgregarArticulo()
        {
            ABMArticulos _formulario = new ABMArticulos();
            _formulario._nuevo = true;
            _formulario.ShowDialog();
        }

        public void EditarArticulo(int idArticulo)
        {
            Articulo _articulo = _repositorio.BuscarArticulo(idArticulo);
            ABMArticulos _formulario = new ABMArticulos();
            _formulario._nuevo = false;
            _formulario.ActualizarProducto(_articulo);
            _formulario.ShowDialog();
        }

        public void EliminarArticulo(int idarticulo)
        {
            Articulo _articulo = _repositorio.BuscarArticulo(idarticulo);
            ABMArticulos _formulario = new ABMArticulos();
            _formulario.ActualizarProducto(_articulo);
            _formulario.EliminarProducto();
        }
    }
}

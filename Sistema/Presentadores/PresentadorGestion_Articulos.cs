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
    public class PresentadorGestion_Articulos
    {
        IGestion_Producto vista_tmp;
        R_ABMArticulos _repositorio;

        public PresentadorGestion_Articulos(IGestion_Producto vista_par)
        {
            vista_tmp = vista_par;
            _repositorio = new R_ABMArticulos();
        }


        public List<GestionArticulosViewModel> ActualizarListado()
        {            
            return _repositorio.Actualizar();
            
        }

        public List<GestionArticulosViewModel> BuscarProductos(string nombre)
        {
            
            return _repositorio.BuscarProductos(nombre);
            
        }

        public void AgregarArticulo()
        {
            ABM_Articulos _formulario = new ABM_Articulos();
            _formulario._nuevo = true;
            _formulario.ShowDialog();
        }

        public void EditarArticulo(int idarticulo)
        {
            articulo _articulo = _repositorio.BuscarArticuloId(idarticulo);
            ABM_Articulos _formulario = new ABM_Articulos();
            _formulario._nuevo = false;
            _formulario.ActualizarProducto(_articulo);
            _formulario.ShowDialog();
        }

        public void EliminarArticulo(int idarticulo)
        {
            articulo _articulo = _repositorio.BuscarArticuloId(idarticulo);
            ABM_Articulos _formulario = new ABM_Articulos();
            _formulario.ActualizarProducto(_articulo);
            _formulario.EliminarProducto();
        }
    }
}

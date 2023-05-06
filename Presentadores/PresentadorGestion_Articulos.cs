using Datos;
using Dominio;
using Interfaces;
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

        public PresentadorGestion_Articulos(IGestion_Producto vista_par)
        {
            vista_tmp = vista_par;
        }


        public List<articulo> ActualizarListado()
        {
            R_ABMArticulos _repositorio = new R_ABMArticulos();
            return _repositorio.Actualizar();
            
        }

        public List<articulo> BuscarProductos(string nombre)
        {
            R_ABMArticulos _repositorio = new R_ABMArticulos();
            return _repositorio.BuscarProductos(nombre);
            
        }
    }
}

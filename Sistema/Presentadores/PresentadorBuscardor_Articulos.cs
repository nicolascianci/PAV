using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
    public class PresentadorBuscardor_Articulos
    {
        List<articulo> lista_articulos = new List<articulo>();
        R_Articulos _repositorio;

        public PresentadorBuscardor_Articulos()
        {
            _repositorio = new R_Articulos();

           
        }
    }
}

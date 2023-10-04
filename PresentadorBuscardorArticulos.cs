using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
    public class PresentadorBuscardorArticulos
    {
        List<Articulo> lista_articulos = new List<Articulo>();
        RepositorioArticulos _repositorio;

        public PresentadorBuscardorArticulos()
        {
            _repositorio = new RepositorioArticulos();           
        }
    }
}

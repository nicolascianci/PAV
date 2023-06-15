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
    public class PresentadorGestionCategorias
    {
        IGestionCategorias _vista;
        private RepositorioABMCategorias repositorio;

        public PresentadorGestionCategorias(IGestionCategorias vista_par)
        {
            _vista = vista_par;
            repositorio = new RepositorioABMCategorias();
            
        }

        public List<Categoria> MostrarCategorias()
        {
            return repositorio.TodasCategorias();
        }

        public List<Categoria> BuscarCategorias()
        {
            return repositorio.BuscarCategorias(this._vista.NombreCategoria);

        }
    }
}

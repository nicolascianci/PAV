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
    public class PresentadorGestion_Categorias
    {
        IGestion_Categorias vista_tmp;
        private R_ABMCategorias repositorio;

        public PresentadorGestion_Categorias(IGestion_Categorias vista_par)
        {
            vista_tmp = vista_par;
            repositorio = new R_ABMCategorias();
            
        }

        public List<categoria> Mostrar_Categorias()
        {
            return repositorio.Todas_Categorias();
        }

        public List<categoria> Buscar_Categorias()
        {
            return repositorio.Buscar_Categorias(this.vista_tmp.nombre_categoria);

        }
    }
}

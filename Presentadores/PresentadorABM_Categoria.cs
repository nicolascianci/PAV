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
    public class PresentadorABM_Categoria
    {
        IABMCatagorias vista_tmp;
        R_ABMCategorias _repositorio;

        public PresentadorABM_Categoria(IABMCatagorias vista_par)
        {
            vista_tmp = vista_par;
            _repositorio = new R_ABMCategorias();

            vista_tmp.AgregarCategoriaAceptar += this.AgregarCategoria;
            vista_tmp.EditarCategoriaAceptar += this.EditarCategoria;
            vista_tmp.EliminarCategoriaAceptar += this.EliminarCategoria;
        }

        public void AgregarCategoria(object sender, categoria c)
        {
            _repositorio.Agregar_Categoria(c);
        }

        public void EditarCategoria(object sender, categoria c)
        {
            _repositorio.Modificar_Categoria(c);
        }

        public void EliminarCategoria(object sender, categoria c)
        {
            _repositorio.Eliminar_Categoria(c);
        }
    }
}

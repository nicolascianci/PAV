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
        IABMCatagorias _vista;
        RepositorioABMCategorias _repositorio;

        public PresentadorABM_Categoria(IABMCatagorias vistaPar)
        {
            _vista = vistaPar;
            _repositorio = new RepositorioABMCategorias();

            _vista.AgregarCategoriaAceptar += this.AgregarCategoria;
            _vista.EditarCategoriaAceptar += this.EditarCategoria;
            _vista.EliminarCategoriaAceptar += this.EliminarCategoria;
        }

        public void AgregarCategoria(object sender, Categoria c)
        {
            _repositorio.AgregarCategoria(c);
        }

        public void EditarCategoria(object sender, Categoria c)
        {
            _repositorio.ModificarCategoria(c);
        }

        public void EliminarCategoria(object sender, Categoria c)
        {
            _repositorio.EliminarCategoria(c);
        }
    }
}

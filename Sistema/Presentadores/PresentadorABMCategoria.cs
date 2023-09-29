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
    //TODO: No debe invocarse desde el presentador a recursos de la vista, como se corrigió
    //en los repositorios. Revisar todos los casos (en todos los presentadores).
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
            if(this.ValidarCategoria(c.Nombre))
                _repositorio.AgregarCategoria(c);

        }

        public void EditarCategoria(object sender, Categoria c)
        {
            if (this.ValidarCategoria(c.Nombre))
                _repositorio.ModificarCategoria(c);
        }

        public void EliminarCategoria(object sender, Categoria c)
        {
            _repositorio.EliminarCategoria(c);
        }

        private bool ValidarCategoria(string nombreCategoria)
        {
            Categoria _categoria = _repositorio.BuscarCategoria(nombreCategoria);

            if (_categoria != null)
            {
                System.Windows.Forms.MessageBox.Show("Existe una Categoria con ese nombre.", "Validar Categoria", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}

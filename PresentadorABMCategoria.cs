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

            
        }

        public bool AgregarCategoria(Categoria c,out string mens)
        {
            
            if (this.ValidarCategoria(c.Nombre, out mens))
            {
                _repositorio.AgregarCategoria(c);
                mens = "Se guardo la categoria exitosamente.";
                return true;
            }
            else
                return false;
                

        }

        public bool EditarCategoria(Categoria c, out string mens)
        {

            if (this.ValidarCategoria(c.Nombre, out mens))
            {
                _repositorio.ModificarCategoria(c);
                mens = "Se guardo la categoria exitosamente.";
                return true;
            }
            else
                return false;


        }

        public void EliminarCategoria(Categoria c)
        {
            _repositorio.EliminarCategoria(c);
        }

        private bool ValidarCategoria(string nombreCategoria, out string mens)
        {
            Categoria _categoria = _repositorio.BuscarCategoria(nombreCategoria);

            if (_categoria != null)
            {
                //System.Windows.Forms.MessageBox.Show("Existe una Categoria con ese nombre.", "Validar Categoria", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                mens = "Existe una Categoria con ese nombre.";
                return false;
            }

            mens = "";
            return true;
        }

    }
}

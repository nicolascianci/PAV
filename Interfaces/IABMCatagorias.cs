using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IABMCatagorias
    {
        event EventHandler<categoria> AgregarCategoriaAceptar;
        event EventHandler<categoria> EditarCategoriaAceptar;
        event EventHandler<categoria> EliminarCategoriaAceptar;
        void Modificar(categoria categoria_par);
    }
}

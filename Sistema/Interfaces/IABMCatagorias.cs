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
        event EventHandler<Categoria> AgregarCategoriaAceptar;
        event EventHandler<Categoria> EditarCategoriaAceptar;
        event EventHandler<Categoria> EliminarCategoriaAceptar;
        void Modificar(Categoria categoria_par);
    }
}

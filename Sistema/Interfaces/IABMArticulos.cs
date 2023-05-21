using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IABMArticulos
    {
        event EventHandler<articulo> AgregarProductoAceptar;
        event EventHandler<articulo> EditarProductoAceptar;
        event EventHandler<articulo> EliminarProductoAceptar;
        void Modificar(articulo articulo_par);
    }
}

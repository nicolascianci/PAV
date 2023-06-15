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
        event EventHandler<Articulo> AgregarProductoAceptar;
        event EventHandler<Articulo> EditarProductoAceptar;
        event EventHandler<Articulo> EliminarProductoAceptar;
        void Modificar(Articulo articuloPar);
    }
}

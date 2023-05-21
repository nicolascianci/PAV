using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGestion_Producto
    {
        string nombre_articulo { get; }
        void ActualizarLista();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGestion_Categorias
    {
        string nombre_categoria { get; }
        void Actualizar_Categorias();
    }
}

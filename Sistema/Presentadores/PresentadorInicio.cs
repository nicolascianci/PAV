using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
   public class PresentadorInicio
    {
        RepositorioCaja _repositorio_caja;

        public PresentadorInicio()
        {
            _repositorio_caja = new RepositorioCaja();
        }
        public void Abrir_Caja()
        {
            _repositorio_caja.AbrirCaja();
        }

    }
}

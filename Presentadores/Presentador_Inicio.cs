using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
   public class Presentador_Inicio
    {
        R_Caja _repositorio_caja;

        public Presentador_Inicio()
        {
            _repositorio_caja = new R_Caja();
        }
        public void Abrir_Caja()
        {
            _repositorio_caja.Abrir_Caja();
        }

    }
}

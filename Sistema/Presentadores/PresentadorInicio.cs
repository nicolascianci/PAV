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
        //TODO: los guiones bajos solo al principio y en las variables de clase, en ningún otro lado.
        RepositorioCaja _repositorio_caja;

        public PresentadorInicio()
        {
            _repositorio_caja = new RepositorioCaja();
        }
        //TODO: corregir por AbrirCaja (revisar si hay más y corregir)
        public void Abrir_Caja()
        {
            _repositorio_caja.AbrirCaja();
        }

    }
}

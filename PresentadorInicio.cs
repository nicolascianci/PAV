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
        RepositorioCaja _repositorioCaja;

        public PresentadorInicio()
        {
            _repositorioCaja = new RepositorioCaja();
        }
        //TODO: corregir por AbrirCaja (revisar si hay más y corregir)
        public bool AbrirCaja(out string mens)
        {
            if (_repositorioCaja.AbrirCaja(out mens))
                return true;
            else
                return false;
        }

        public void CerrarAbrirCaja(out string mens)
        {
            _repositorioCaja.CerrarAbrirCaja(out mens);
        }

    }
}

using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioCaja
    {
        private Modelo _repositorio;
        private Caja _caja;

        public RepositorioCaja()
        {
            _repositorio = new Modelo();
        }

        public void AbrirCaja()
        {
            if(!_repositorio.Cajas.Any(x => x.FechaCierre == null))
            {
                _caja = new Caja();
                _caja.FechaInicio = DateTime.Now;
                _repositorio.Cajas.Add(_caja);
                _repositorio.SaveChanges();

                MessageBox.Show("Se abrio la caja correctamente");
            }
            else
            {
                DialogResult _resultado = MessageBox.Show("Hay una Caja Abierta desea Cerrarla y Abrir otra?", "Cerrar Caja", MessageBoxButtons.YesNo);

                if(_resultado == DialogResult.Yes)
                {
                    _caja = _repositorio.Cajas.Where(x => x.FechaCierre == null).FirstOrDefault();
                    _caja.FechaCierre = DateTime.Now;
                    _repositorio.SaveChanges();

                    MessageBox.Show("Se cerro la caja correctamente");

                    _caja = new Caja();
                    _caja.FechaInicio = DateTime.Now;
                    _repositorio.Cajas.Add(_caja);
                    _repositorio.SaveChanges();

                    MessageBox.Show("Se abrio la caja correctamente");
                }
            }
        }
    }
}

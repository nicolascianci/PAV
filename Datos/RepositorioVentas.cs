using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioVentas
    {
        private Modelo _repositorio;

        public RepositorioVentas()
        {
            _repositorio = new Modelo();
        }


        public int ObtenerNumero()
        {
            var query = _repositorio.operaciones.Where(x => x.TipoOperacion == Dominio.TipoOperacion.Venta).OrderByDescending(x => x.Fecha).FirstOrDefault();

            if (query != null)
                return query.NumeroVenta + 1;
            else
                return 1;                
        }

        public void GuardarVenta(Operacion operacionPar)
        {           
            _repositorio.operaciones.Add(operacionPar);
            _repositorio.SaveChanges();
        }

        public List<Operacion> BuscarVentas(DateTime desdePar, DateTime hastaPar)
        {

            return (from v in _repositorio.operaciones
                    where v.TipoOperacion == TipoOperacion.Venta
                    && v.Fecha >= desdePar
                    && v.Fecha <= hastaPar
                    select v).ToList();
        }


        public Operacion BuscarVenta(int idVentaPar)
        {
            Operacion item = (from a in _repositorio.operaciones
                              where a.TipoOperacion == TipoOperacion.Venta
                              && a.ID_Operacion == idVentaPar
                              select a).FirstOrDefault();

            return item;
        }

        public List<Detalle> BuscarDetalle(int idOperacion)
        {
            return (from a in _repositorio.Detalle
                    where a.IDOperacion == idOperacion
                    select a).ToList();
        }

    }
}

using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class R_Ventas
    {
        private Modelo repositorio;

        public R_Ventas()
        {
            repositorio = new Modelo();
        }


        public int Obtener_Numero()
        {
            var query = repositorio.operaciones.Where(x => x.Tipo_operacion == Dominio.Tipo_Operacion.Venta).OrderByDescending(x => x.fecha).FirstOrDefault();

            if (query != null)
                return query.numero_venta + 1;
            else
                return 1;                
        }

        public void Guardar_Venta(Operacion operacion_par)
        {
            operacion_par.fecha = DateTime.Now;
            repositorio.operaciones.Add(operacion_par);
            repositorio.SaveChanges();
        }

        public List<Datos_Grilla> Buscar_Ventas(DateTime desde_par, DateTime hasta_par)
        {
            List<Datos_Grilla> lista_tmp = new List<Datos_Grilla>();

            var query = (from v in repositorio.operaciones
                         where v.Tipo_operacion == Tipo_Operacion.Venta
                         && v.fecha >= desde_par
                         && v.fecha <= hasta_par
                         select v).ToList();

            foreach (var item in query)
            {
                Datos_Grilla venta = new Datos_Grilla();
                venta.codigo = item.ID_Operacion;
                venta.columna1 = item.punto_venta.ToString().PadLeft(4, '0') + "-" + item.numero_venta.ToString().PadLeft(8, '0');
                venta.columna2 = item.total;
                venta.columna3 = item.fecha;

                lista_tmp.Add(venta);
            }

            return lista_tmp;
        }


        public Operacion Buscar_Venta(int idventa_par)
        {
            Operacion item = (from a in repositorio.operaciones
                              where a.Tipo_operacion == Tipo_Operacion.Venta
                              && a.ID_Operacion == idventa_par
                              select a).FirstOrDefault();

            return item;
        }

    }
}

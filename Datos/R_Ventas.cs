﻿using Dominio;
using Dominio.ViewModels;
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
            var query = repositorio.operaciones.Where(x => x.TipoOperacion == Dominio.Tipo_Operacion.Venta).OrderByDescending(x => x.fecha).FirstOrDefault();

            if (query != null)
                return query.numeroVenta + 1;
            else
                return 1;                
        }

        public void Guardar_Venta(Operacion operacion_par)
        {
            operacion_par.fecha = DateTime.Now;
            repositorio.operaciones.Add(operacion_par);
            repositorio.SaveChanges();
        }

        public List<ConsultaVentasViewModel> Buscar_Ventas(DateTime desde_par, DateTime hasta_par)
        {
            List<ConsultaVentasViewModel> lista_tmp = new List<ConsultaVentasViewModel>();

            lista_tmp = (from v in repositorio.operaciones
                         where v.TipoOperacion == Tipo_Operacion.Venta
                         && v.fecha >= desde_par
                         && v.fecha <= hasta_par
                         select v).Select(p => new ConsultaVentasViewModel
                         {
                             numeroVenta = p.ID_Operacion,
                             numeroFactura = p.puntoVenta.ToString().PadLeft(4,'0') + '-' + p.numeroVenta.ToString().PadLeft(8,'0'),
                             fechaVenta = p.fecha,
                             totalVenta = p.total
                         }).ToList();

            

            return lista_tmp;
        }


        public Operacion Buscar_Venta(int idventa_par)
        {
            Operacion item = (from a in repositorio.operaciones
                              where a.TipoOperacion == Tipo_Operacion.Venta
                              && a.ID_Operacion == idventa_par
                              select a).FirstOrDefault();

            return item;
        }

    }
}

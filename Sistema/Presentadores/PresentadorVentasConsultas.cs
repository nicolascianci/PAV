using Datos;
using Dominio;
using Dominio.ViewModels;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
    public class PresentadorVentasConsultas
    {
        IConsultaVentas _vista;
        RepositorioVentas repositorio_ventas;

        List<ConsultaVentasViewModel> lista_ventas = new List<ConsultaVentasViewModel>();

        public PresentadorVentasConsultas(IConsultaVentas vistaPar)
        {
            _vista = vistaPar;
            repositorio_ventas = new RepositorioVentas();
            _vista.Total = 0;
        }

        public void Buscar_Ventas()
        {
            lista_ventas = repositorio_ventas.BuscarVentas(this._vista.Desde, this._vista.Hasta).
            Select(p => new ConsultaVentasViewModel
            {
                NumeroVenta = p.ID_Operacion,
                NumeroFactura = $"{p.PuntoVenta : 0000} - {p.NumeroVenta: 00000000}",
                FechaVenta = p.Fecha,
                TotalVenta = p.Total
            }).ToList();
            this._vista.ListaVentas = lista_ventas;
            this._vista.Total = lista_ventas.Sum(x => Convert.ToDecimal(x.TotalVenta));

        }
        

        public void limpiar()
        {
            lista_ventas = new List<ConsultaVentasViewModel>();
            this._vista.ListaVentas = lista_ventas;
            this._vista.Total = 0;
        }
    }
}

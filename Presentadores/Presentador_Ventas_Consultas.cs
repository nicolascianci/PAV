using Datos;
using Dominio;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
    public class Presentador_Ventas_Consultas
    {
        IConsulta_Ventas vista_tmp;
        R_Ventas repositorio_ventas;

        List<Datos_Grilla> lista_ventas = new List<Datos_Grilla>();

        public Presentador_Ventas_Consultas(IConsulta_Ventas vista_par)
        {
            vista_tmp = vista_par;
            repositorio_ventas = new R_Ventas();
            vista_tmp.total = 0;
        }

        public void Buscar_Ventas()
        {
            lista_ventas = repositorio_ventas.Buscar_Ventas(this.vista_tmp.Desde, this.vista_tmp.Hasta);
            this.vista_tmp.lista_ventas = lista_ventas;
            this.vista_tmp.total = lista_ventas.Sum(x => Convert.ToDecimal(x.columna2));

        }
        

        public void limpiar()
        {
            lista_ventas = new List<Datos_Grilla>();
            this.vista_tmp.lista_ventas = lista_ventas;
            this.vista_tmp.total = 0;
        }
    }
}

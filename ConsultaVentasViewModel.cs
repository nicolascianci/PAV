using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ViewModels
{
    public class ConsultaVentasViewModel
    {
        public int NumeroVenta { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaVenta { get; set; }
        public double TotalVenta { get; set; }
    }
}

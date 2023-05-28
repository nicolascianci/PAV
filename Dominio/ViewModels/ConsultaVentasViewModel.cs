using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ViewModels
{
    public class ConsultaVentasViewModel
    {
        public int numeroVenta { get; set; }
        public string numeroFactura { get; set; }
        public DateTime fechaVenta { get; set; }
        public double totalVenta { get; set; }
    }
}

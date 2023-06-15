using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Operacion
    {
        public int ID_Operacion { get; set; }
        public TipoOperacion TipoOperacion { get; set; }
        public int PuntoVenta { get; set; }
        public int NumeroVenta { get; set; }
        public double TotalSinDescuento { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        
        public DateTime Fecha { get; set; }

        //public List<Detalle> operacion_detalle { get; set; }
        public virtual ICollection<Detalle> OperacionDetalle { get; set; }


    }
}

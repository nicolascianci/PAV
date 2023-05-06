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
        public Tipo_Operacion Tipo_operacion { get; set; }
        public int punto_venta { get; set; }
        public int numero_venta { get; set; }
        public double totas_sin_descuento { get; set; }
        public double descuento { get; set; }
        public double total { get; set; }
        
        public DateTime fecha { get; set; }

        //public List<Detalle> operacion_detalle { get; set; }
        public virtual ICollection<Detalle> Operacion_Detalle { get; set; }


    }
}

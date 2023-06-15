using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{    
    public class Detalle
    {

        public int ID { get; set; }


        [ForeignKey("Operacion")]
        public int? IDOperacion { get; set; }

        public int ArticuloID { get; set; }
        public double PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }

        public double Preciofinal
        {
            get
            {
                return Math.Round((double)Cantidad * (double)PrecioUnitario, 2);

            }
        }


        public virtual Articulo Articulo { get; set; }
        public virtual Operacion Operacion { get; set; }
    }
}

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

        public int articuloID { get; set; }
        public double precioUnitario { get; set; }
        public decimal cantidad { get; set; }

        public double Preciofinal
        {
            get
            {
                return Math.Round((double)cantidad * (double)precioUnitario, 2);

            }
        }


        public virtual articulo articulo { get; set; }
        public virtual Operacion Operacion { get; set; }
    }
}

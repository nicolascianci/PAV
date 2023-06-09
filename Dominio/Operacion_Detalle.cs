﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Operacion_Detalle
    {

        public int ID_OperacionDetalle { get; set; }


        [ForeignKey("Operacion")]
        public int? ID_Operacion { get; set; }

        public int articuloID { get; set; }

        public double precio_unitario { get; set; }
        public int cantidad { get; set; }

        public double Preciofinal
        {
            get
            {
                return Math.Round((double)cantidad * (double)precio_unitario, 2);

            }
        }


        public virtual articulo articulo { get; set; }
        public virtual Operacion Operacion { get; set; }
    }
}

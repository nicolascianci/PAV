using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double CostoSinIva { get; set; }
        public double PorcentajeIva { get; set; }
        public double CostoConIva
        {
            get
            {
                return Math.Round((double)CostoSinIva + (double)CostoSinIva * (double)PorcentajeIva, 2);
                
            }
        }

        public double MargenDeGanancia { get; set; }
        public double Preciofinal 
        {
            get 
            {
                return Math.Round((double)CostoConIva + (double)CostoConIva * (double)MargenDeGanancia, 2);               
                     
            }
        }
        public EstadoProducto Estado { get; set; }

        public DateTime? Fealt { get; set; }
        public DateTime? Femod { get; set; }
        public DateTime? Febaj { get; set; }

        public decimal Stock { get; set; }

        public bool ValidarArticulo(out string mensaje)
        {
            if(this.Codigo == null || this.Codigo == string.Empty)
            {
                mensaje = "No ingreso codigo para el articulo.";
                return false;
            }

            if(this.Descripcion == null || this.Descripcion == string.Empty)
            {
                mensaje = "No ingreso la descripcion del articulo.";
                return false;
            }

            if(this.CostoSinIva <= 0)
            {
                mensaje = "El precio de costo debe ser mayor a 0.";
                return false;
            }

            if (this.CostoConIva <= 0)
            {
                mensaje = "El precio de costo debe ser mayor a 0.";
                return false;
            }

            if (this.PorcentajeIva <= 0)
            {
                mensaje = "El porcentaje de IVA debe ser mayor a 0.";
                return false;
            }

            if (this.Preciofinal <= 0)
            {
                mensaje = "El precio de venta debe ser mayor a 0.";
                return false;
            }

            mensaje = "";
            return true;
        }

        //[ForeignKey ("categoria")]
        public int? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}

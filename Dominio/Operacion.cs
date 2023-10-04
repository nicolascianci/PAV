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
        public Operacion()
        {
            this.OperacionDetalle = new List<Detalle>();
        }
        public int ID_Operacion { get; set; }
        public TipoOperacion TipoOperacion { get; set; }
        public int PuntoVenta { get; set; }
        public int NumeroVenta { get; set; }
        public double TotalSinDescuento
        {
            get
            {
                return Math.Round((double)this.OperacionDetalle.Sum(p => (double)p.Cantidad * p.PrecioUnitario), 2);

            }
            
            
        }
        public double Descuento { get; set; }
        public double Total
        {
            get
            {
                return Math.Round((double)this.OperacionDetalle.Sum(p => (double)p.Cantidad * p.PrecioUnitario) * (1- (this.Descuento)/100), 2);

            }
        }
        
        public DateTime Fecha { get; set; }

        //public List<Detalle> operacion_detalle { get; set; }
        public List<Detalle> OperacionDetalle { get; set; }

        public void agregarDetalle(int idArticulo, double cantidad, double precioUnitario)
        {
            Detalle detalle = new Detalle();
            detalle.ArticuloID = idArticulo;
            detalle.Cantidad = (decimal)cantidad;
            detalle.PrecioUnitario = precioUnitario;

            this.OperacionDetalle.Add(detalle);
        }

        public void editarDetalle(int idArticulo, double cantidad, double precioUnitario)
        {
            Detalle detalle = this.OperacionDetalle.Where(p => p.ArticuloID == idArticulo).FirstOrDefault();
            detalle.Cantidad = (decimal)cantidad;
            detalle.PrecioUnitario = precioUnitario;
        }

        public void eliminarDetalle(int idArticulo)
        {
            Detalle detalle = this.OperacionDetalle.Where(p => p.ArticuloID == idArticulo).FirstOrDefault();
            this.OperacionDetalle.Remove(detalle);
        }
        
    }
}

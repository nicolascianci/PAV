using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.ViewModels
{
    public class BuscadorArticulosViewModel
    {        
        public int IdArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public double CostoSinIva { get; set; }
        public double CostoConIva { get; set; }
        public double PrecioFinal { get; set; }
        public decimal Stock { get; set; }
        public EstadoProducto EstadoProducto { get; set; }
        public string NombreCategoria { get; set; }
    }
}

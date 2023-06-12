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
        public string descripcionArticulo { get; set; }
        public double costoSinIva { get; set; }
        public double costoConIva { get; set; }
        public double precioFinal { get; set; }
        public decimal stock { get; set; }
        public EstadoProducto estadoProducto { get; set; }
        public string nombreCategoria { get; set; }
    }
}

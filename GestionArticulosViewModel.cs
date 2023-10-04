using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ViewModels
{
    public class GestionArticulosViewModel
    {
        public int IdArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public double CostoSinIva { get; set; }
        public double CostoConIva { get; set; }
        public double PrecioFinal { get; set; }
        public EstadoProducto EstadoProducto { get; set; }
        public string NombreCategoria { get; set; }
    }
}

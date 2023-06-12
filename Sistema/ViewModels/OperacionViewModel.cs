using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ViewModels
{
    public class OperacionViewModel
    {
        public int idArticulo { get; set; }
        public string descripcionArticulo { get; set; }
        public double precioUnitario { get; set; }
        public double cantidad { get; set; }
        public double total
        {
            get
            {
                return Math.Round((double)cantidad * (double)precioUnitario, 2);

            }
        }
        public double stock { get; set; }
    }
}

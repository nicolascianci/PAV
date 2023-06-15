using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ViewModels
{
    public class OperacionViewModel
    {
        public int IdArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public double PrecioUnitario { get; set; }
        public double Cantidad { get; set; }
        public double Total
        {
            get
            {
                return Math.Round((double)Cantidad * (double)PrecioUnitario, 2);

            }
        }
        public double Stock { get; set; }
    }
}

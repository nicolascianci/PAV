using Dominio;
using Dominio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOperacion
    {
        List<OperacionViewModel> ListaArticulos { get; set; }
        string NombreArticulo { get; set; }
        double Cantidad { get; set; }
        double TotalSinDescuento { get; set; }
        double Descuento { get; set; }
        double TotalConDescuento{ get; set; }
        
        event EventHandler<List<OperacionViewModel>> RealizarOperacion;
    }
}

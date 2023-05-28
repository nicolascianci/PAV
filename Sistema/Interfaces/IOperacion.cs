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
        List<OperacionViewModel> lista_articulos { get; set; }
        string nombre_articulo { get; set; }
        double cantidad { get; set; }
        double total_sin_descuento { get; set; }
        double descuento { get; set; }
        double total_con_descuento{ get; set; }
        //Tipo_Operacion tipo_operacion { get; set; }

        event EventHandler<List<OperacionViewModel>> Realizar_Operacion;
    }
}

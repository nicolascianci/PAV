using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOperacion
    {
        List<Datos_Grilla> lista_articulos { get; set; }
        string nombre_articulo { get; set; }
        double cantidad { get; set; }
        double total_sin_descuento { get; set; }
        double descuento { get; set; }
        double total_con_descuento{ get; set; }
        //Tipo_Operacion tipo_operacion { get; set; }

        event EventHandler<List<Datos_Grilla>> Realizar_Operacion;
    }
}

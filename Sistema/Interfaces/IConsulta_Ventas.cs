using Dominio;
using Dominio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IConsulta_Ventas
    {
        DateTime Desde { get; }
        DateTime Hasta { get; }
        List<ConsultaVentasViewModel> lista_ventas { get; set; }
        int idventa { get; }
        decimal total { set; }
    }
}

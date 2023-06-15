using Dominio;
using Dominio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IConsultaVentas
    {
        DateTime Desde { get; }
        DateTime Hasta { get; }
        List<ConsultaVentasViewModel> ListaVentas { get; set; }
        int IdVenta { get; }
        decimal Total { set; }
    }
}

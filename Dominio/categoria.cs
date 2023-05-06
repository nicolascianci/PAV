using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class categoria
    {
        public int id { get; set; }        
        public string Nombre { get; set; }

        public DateTime? fealt { get; set; }
        public DateTime? femod { get; set; }
        public DateTime? febaj { get; set; }
    }
}

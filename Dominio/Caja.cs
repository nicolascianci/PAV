using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Caja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idcaja { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime? fecha_cierre { get; set; }
        
    }
}

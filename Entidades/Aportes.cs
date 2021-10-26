using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonas.Entidades
{
    public class Aportes
    {
        [Key]
        //AporteId,Fecha,PersonaId,Concepto, Monto
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int PersonaId { get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Persona { get; set; }
        public List<AportesDetalle> DetalleAporte { get; set; } = new List<AportesDetalle>();
    }
}

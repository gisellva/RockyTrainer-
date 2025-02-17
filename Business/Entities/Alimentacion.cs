using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Alimentacion
    {
        public int Id { get; set; }
        public string Ingredientes { get; set; }
        public float Cantidad { get; set; } 
        public DateTime Horario { get; set; }
        public int PerroId { get; set; }
        public Perro Perro { get; set; }
    }
}

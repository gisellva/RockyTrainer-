using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comportamiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Intensidad { get; set; } 
        public int Frecuencia { get; set; } 
        public int PerroId { get; set; }
        public Perro Perro { get; set; }
    }
}

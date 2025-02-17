using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Entrenamiento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int Duracion { get; set; } 
        public string Progreso { get; set; }
        public int PerroId { get; set; }
        public Perro Perro { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Perro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public float Peso { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<Entrenamiento> Entrenamientos { get; set; } = new();
        public List<Alimentacion> Alimentaciones { get; set; } = new();
        public List<Comportamiento> Comportamientos { get; set; } = new();

       
    }
}

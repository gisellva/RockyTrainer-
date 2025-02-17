using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Interfaces.Repositories;


namespace UseCases.UseCases.Registro
{
    public class RegistrarPerro
    {
        private readonly IPerroRepository _perrorepository;
        public RegistrarPerro(IPerroRepository perrorepository)
        {
            _perrorepository = perrorepository;
        }
        public async Task<Perro> AgregarAsync(string nombre, string raza, int edad, float peso, int usuarioid)
        {
            {
                Perro nuevoperro = new Perro
                {
                   Nombre = nombre,
                   Raza = raza,
                   Edad = edad,
                   Peso = peso,
                   UsuarioId = usuarioid
                };
                await _perrorepository.AgregarAsync(nuevoperro);
                return nuevoperro;
            }
        }
    }
}

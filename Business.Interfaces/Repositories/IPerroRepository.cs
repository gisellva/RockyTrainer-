using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Business.Entities;





namespace Business.Interfaces.Repositories
{
    public interface IPerroRepository
    {
        Task AgregarAsync(Perro perro);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistribuidoraDominio;

namespace DistribuidoraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado
            {
                Nombre= "Fulano",
                Email= "fulano@gmail.com",
                Contrasenia= "123"
            };
            if (e.Insertar())
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Todo mal");
        }
    }
}

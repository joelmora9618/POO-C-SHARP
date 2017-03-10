using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            clsContactCliente Cliente = new clsContactCliente("joel", "mora", 20,
                                                              42632047,42632047,"joelmora9618@gmail.com",
                                                              "Buenos aires", "Monte grande", "Bahia blanca 361");

            Console.WriteLine(Cliente.Nombre + " " + Cliente.Apellido + " " + Cliente.Edad);
            Console.WriteLine(Cliente.Telefono1 + " " + Cliente.Telefono2 + " " + Cliente.Gmail);
            Console.WriteLine(Cliente.Direcciones.Provincia + " " + Cliente.Direcciones.Localidad + " " + Cliente.Direcciones.Calle);

            Console.ReadKey();
        }
    }
}

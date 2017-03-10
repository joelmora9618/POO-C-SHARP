using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class clsConsulta : intEntrada
    {
        public void ConsultarDatos(clsContactoCliente Cliente)
        {
            string value;

            Console.WriteLine("ingrese su nombre: ");
            Cliente.Nombre = Console.ReadLine();

            Console.WriteLine("ingrese su apellido: ");
            Cliente.Apellido = Console.ReadLine();

            Console.WriteLine("ingrese su edad: ");
            value = Console.ReadLine();
            Cliente.Edad = Convert.ToInt32(value);

            Console.WriteLine("ingrese Telefono 1: ");
            Cliente.Telefono1 = Console.ReadLine();

            Console.WriteLine("ingrese Telefono 2: ");
            Cliente.Telefono2 = Console.ReadLine();

            Console.WriteLine("ingrese su email: ");
            Cliente.Gmail = Console.ReadLine();

            Console.WriteLine("ingrese Provincia: ");
            Cliente.Direccion.Provincia = Console.ReadLine();

            Console.WriteLine("ingrese Localidad: ");
            Cliente.Direccion.Localidad = Console.ReadLine();

            Console.WriteLine("ingrese su calle: ");
            Cliente.Direccion.Calle = Console.ReadLine();

            Console.Clear();
        }
    }
}

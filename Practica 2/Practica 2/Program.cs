using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            clsClientesFijos Clientes;
            Clientes = new clsClientesFijos();

            Console.WriteLine("ingrese su nombre: ");
            Clientes.Nombre = Console.ReadLine();

            Console.WriteLine("ingrese su apellido: ");
            Clientes.Apellido = Console.ReadLine();

            Clientes.IdCliente = 2;

            Console.WriteLine("ingrese su direccion: ");
            Clientes.Direccion = Console.ReadLine();

            Console.WriteLine("ingrese su numero de telefono: ");
            value = Console.ReadLine();
            Clientes.Telefono = Convert.ToInt64(value);

            Console.Clear();

            Console.WriteLine(Clientes.Nombre + " " + Clientes.Apellido);
            Console.WriteLine(Clientes.Direccion + " " + Clientes.Telefono);
            Console.WriteLine(Clientes.Email);

            Console.ReadKey();
        }
    }
}

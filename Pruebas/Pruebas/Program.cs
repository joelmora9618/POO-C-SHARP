using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            intSalida impresion;
            int opcion;
            char continuar = 's';
            clsContactoCliente Cliente;
            clsConsulta Consulta;
            clsImprimirDatos Imprimir;

            Cliente = new clsContactoCliente();
            Consulta = new clsConsulta();
            Imprimir = new clsImprimirDatos();

            Consulta.ConsultarDatos(Cliente);

            while (continuar == 's')
            {

                Console.WriteLine("Escribir datos");
                Console.WriteLine("\n1 por Consola");
                Console.WriteLine("2 en archivo");
                Console.WriteLine("\ndonde desea escribir los datos: ");

                value = Console.ReadLine();
                opcion = Convert.ToInt32(value);

                switch (opcion)
                {
                    case 1:
                        impresion = new clsImprimirDatos();
                        impresion.imprimirDatos(Cliente);
                        break;
                    case 2:
                        impresion = new clsArchivos();
                        impresion.imprimirDatos(Cliente);
                        Console.WriteLine("Datos escritos en el archivo");
                        break;
                    default:
                        Console.WriteLine("\nOpcion invalida!");
                        Console.Clear();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

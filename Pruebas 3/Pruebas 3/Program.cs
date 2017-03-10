using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_3
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMostrarHashMap Tabla = new clsMostrarHashMap();
            Tabla.CargarValores();
            Tabla.MostrarValor();
            Console.ReadKey();
        }
    }
}

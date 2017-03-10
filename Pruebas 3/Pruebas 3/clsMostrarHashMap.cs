using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_3
{
    class clsMostrarHashMap
    {
        private Hashtable Table;

        public clsMostrarHashMap()
        {
            Table = new Hashtable();
        }

        public void CargarValores()
        {
             Table.Add("C001", "Producto 1");
             Table.Add("C002", "Producto 2");
             Table.Add("C003", "Producto 3");
             Table.Add("C004", "Producto 4");

        }

        public void MostrarValor()
        {
            string value; 
            Console.WriteLine("ingrese la clave del producto: ");
            value = Console.ReadLine();

            Console.WriteLine(Table[value]);
        }

        
    }
}

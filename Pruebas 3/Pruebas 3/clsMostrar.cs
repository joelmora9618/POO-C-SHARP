using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_3
{
    class clsMostrar
    {
        private ArrayList Lista = new ArrayList();

        public clsMostrar()
        {
            Lista = new ArrayList();
        }

        public void cargarLista()
        {
            string value;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese el valor en {0}: ",i+1);
                value = Console.ReadLine();
                Lista.Add(value);
                Console.Clear();
            }
        }

        public void MostrarLista()
        {
            foreach(var item in Lista)
            {
                Console.WriteLine("{0}", item);
            }
        }

    }
}

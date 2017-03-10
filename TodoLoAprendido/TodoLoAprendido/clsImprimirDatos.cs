using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLoAprendido
{
    class clsImprimirDatos : intSalida
    {
        public void ImprimirDatos(List<clsContactoPersona> Cliente)
        {
            foreach(clsContactoPersona item in Cliente)
            {
                Console.WriteLine(item.Nombre + " " + item.Apellido + " " + item.Edad + " " + item.Dni);
                Console.ReadKey();
            }
        }
    }
}

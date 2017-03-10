using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class clsImprimirDatos : intSalida
    {
        public void imprimirDatos(clsContactoCliente Cliente)
        {
            Console.WriteLine(Cliente.Nombre + " " + Cliente.Apellido + " " + Cliente.Edad);
            Console.WriteLine(Cliente.Telefono1 + " " + Cliente.Telefono2 + " " + Cliente.Gmail);
            Console.WriteLine(Cliente.Direccion.Provincia + " " + Cliente.Direccion.Localidad + " " + Cliente.Direccion.Calle);
        }
           
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class clsArchivos : intSalida
    {
        public void imprimirDatos(clsContactoCliente Cliente)
        {
            bool bandera = true;
            int i = 0;

            while(bandera)
            {
                try
                {
                    StreamWriter ar = new StreamWriter(@"C:\De la facu\POO C#\Pruebas\contacto.log", true);
                    ar.WriteLine(Cliente.Nombre + " " + Cliente.Apellido + " " + Cliente.Edad);
                    ar.WriteLine(Cliente.Telefono1 + " " + Cliente.Telefono2 + " " + Cliente.Gmail);
                    ar.WriteLine(Cliente.Direccion.Provincia + " " + Cliente.Direccion.Localidad + " " + Cliente.Direccion.Calle);
                    ar.Close();
                    bandera = false;
                }
                catch (Exception e)
                {
                    i++;
                    if(i==500)
                        throw e;
                }
            }

          

            
        }
    }
}

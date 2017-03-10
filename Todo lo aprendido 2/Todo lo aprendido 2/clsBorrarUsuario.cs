using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_lo_aprendido_2
{
    public class clsBorrarUsuario : intEntrada
    {
        public void BorrarUsuario(Int64 Dni, List<clsContactoPersonas>ListaPersonas)
        {
            bool encontrado = false;
            int i = 0;
            string value;
            int opcion;

            try
            {
                while (encontrado == false && i < ListaPersonas.Count)
                {
                    if (ListaPersonas[i].Dni == Dni)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (encontrado)
                {
                    Console.WriteLine("\nNombre: " + ListaPersonas[i].Nombre + "\n" +
                                      "Apellido: " + ListaPersonas[i].Apellido + "\n" +
                                      "Edad: " + ListaPersonas[i].Edad + "\n" +
                                      "Dni: " + ListaPersonas[i].Dni + "\n");

                    Console.ReadKey();
                    ListaPersonas.Remove(ListaPersonas[i]);
                    Console.WriteLine("\nUsuario Borrado con exito!");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void ConsultarDatos(List<clsContactoPersonas> Lista)
        {
        }
        public void ModificarUsuario(Int64 Dni, List<clsContactoPersonas> Lista)
        {
        }
    }
}

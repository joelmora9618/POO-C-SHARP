using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_lo_aprendido_2
{
    public class clsModificarPersonas : intEntrada 
    {
        public void ModificarUsuario(Int64 Dni, List<clsContactoPersonas> Lista)
        {
            int i = 0,
                atributo;
            string value;
            bool encontrado = false;

            try
            {
                while (encontrado == false && i < Lista.Count)
                {
                    if (Lista[i].Dni == Dni)
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
                    Console.WriteLine("1 Nombre: " + Lista[i].Nombre + "\n" +
                                      "2 Apellido: " + Lista[i].Apellido + "\n" +
                                      "3 Edad: " + Lista[i].Edad + "\n" +
                                      "4 Dni: " + Lista[i].Dni + "\n",
                                      "5 Salir\n\n");

                    Console.WriteLine("Que atributo desea modificar?: ");
                    value = Console.ReadLine();
                    atributo = Convert.ToInt32(value);

                    switch (atributo)
                    {
                        case 1:
                            Console.WriteLine("ingrese su nombre: ");
                            Lista[i].Nombre = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("ingrese su apellido: ");
                            Lista[i].Apellido = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("ingrese su edad: ");
                            value = Console.ReadLine();
                            Lista[i].Edad = Convert.ToInt32(value);
                            break;
                        case 4:
                            Console.WriteLine("ingrese su DNI: ");
                            value = Console.ReadLine();
                            Lista[i].Dni = Convert.ToInt32(value);
                            break;
                        case 5:
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

        }
        public void BorrarUsuario(Int64 Dni, List<clsContactoPersonas> Lista)
        {

        }
        public void ConsultarDatos(List<clsContactoPersonas> Lista)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_lo_aprendido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            clsContactoPersonas Persona = new clsContactoPersonas();
            List<clsContactoPersonas> ListPersonas = new List<clsContactoPersonas>();
            string value;
            int opcion = 0;
            intEntrada Entrada;
            intSalida Salida;
            char continuar = 's';
            Int64 dniAux = 0;

            while(continuar == 's')
            {
                Console.WriteLine("1 ingresar persona");
                Console.WriteLine("2 borrar persona");
                Console.WriteLine("3 modificar persona");
                Console.WriteLine("4 mostrar personas");
                Console.WriteLine("5 Salir");

                Console.WriteLine("\nque opcion desea realizar: ");
                value = Console.ReadLine();
                opcion = Convert.ToInt32(value);
                
                switch(opcion)
                {
                    case 1:
                        try
                        {
                            Entrada = new clsConsultarDatosPersonales();
                            Entrada.ConsultarDatos(ListPersonas);
                            Console.WriteLine("Usuario registrad exitosamente!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error al cargar los datos" + "\n" + e.Message);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el dni del usuario a borrar: ");
                        value = Console.ReadLine();
                        dniAux = Convert.ToInt64(value);

                        try
                        {
                            Entrada = new clsBorrarUsuario();
                            Entrada.BorrarUsuario(dniAux, ListPersonas);                            
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Error al borrar el usuario!\n" + e.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Ingrese el DNI de el usuario a modificar: ");
                            value = Console.ReadLine();
                            dniAux = Convert.ToInt64(value);
                            Entrada = new clsModificarPersonas();
                            Entrada.ModificarUsuario(dniAux, ListPersonas);
                            Console.WriteLine("Usuario modificado con exito");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Error al modificar el usuario\n" + e.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Salida = new clsImprimirDatosPersonales();
                            Salida.ImprimirDatos(ListPersonas);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Error al imprimir los datos" + "\n" + e.Message);
                        }
                        
                        break;
                    case 5:
                        Console.WriteLine("\nGracias vuelva prontos!");
                        Console.ReadKey();
                        continuar = 'n';
                        break;
                    default:
                        Console.WriteLine("\nError, opcion invalida!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                } 

            }
           
        }
    }
}

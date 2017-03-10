using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLoAprendido
{
    public class clsAltaPersona
    {
        public void ConsultarDatos(clsContactoPersona Persona, List<clsContactoPersona>Personas)
        {
            string value;
            
            try
            {
                Console.WriteLine("Ingrese su nombre: ");
                Persona.Nombre = Console.ReadLine();

                Console.WriteLine("ingrese su apellido: ");
                Persona.Apellido = Console.ReadLine();

                Console.WriteLine("ingrese su edad: ");
                value = Console.ReadLine();
                Persona.Edad = Convert.ToInt32(value);

                Console.WriteLine("ingrese su dni: ");
                value = Console.ReadLine();
                Persona.Dni = Convert.ToInt64(value);

                Personas.Add(Persona);
                Console.Clear();
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
    }
}

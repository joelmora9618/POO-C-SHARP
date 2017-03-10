using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_lo_aprendido_2
{
    public class clsConsultarDatosPersonales : intEntrada
    {
        private clsContactoPersonas Persona;

        public clsConsultarDatosPersonales()
        {
            Persona = new clsContactoPersonas();
        }

        public void ConsultarDatos(List<clsContactoPersonas>Personas)
        {
            string value;
            
            try
            {
                Console.WriteLine("ingrese su nombre: ");
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
            }
            catch(Exception e)
            {
                throw e;
            }     
        }

        public void BorrarUsuario(Int64 Dni, List<clsContactoPersonas> Lista)
        {
        }
        public void ModificarUsuario(Int64 Dni, List<clsContactoPersonas> Lista)
        {
        }
    }
}

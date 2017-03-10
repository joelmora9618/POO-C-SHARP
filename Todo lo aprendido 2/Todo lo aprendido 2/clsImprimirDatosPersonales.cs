using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_lo_aprendido_2
{
    public class clsImprimirDatosPersonales : intSalida
    {
        public void ImprimirDatos(List<clsContactoPersonas>Personas)
        {
            try
            {
                Console.WriteLine("NOMBRE\tAPELLIDO\tEDAD\tDNI\n");

                foreach (clsContactoPersonas Persona in Personas)
                {
                    Console.WriteLine(Persona.Nombre +"\t"+ Persona.Apellido +"\t\t"+ Persona.Edad +"\t"+ Persona.Dni);
                }
            }
            catch(Exception e)
            {
                throw e;
            }          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLoAprendido
{
    class Program
    {
        static void Main(string[] args)
        {
            intSalida Salida;
            List<clsContactoPersona> Personas = new List<clsContactoPersona>();
            clsContactoPersona Persona = new clsContactoPersona();
            clsAltaPersona Alta = new clsAltaPersona();
            intSalida salida;

            try
            {
                Alta.ConsultarDatos(Persona, Personas);
                salida = new clsImprimirDatos();
                salida.ImprimirDatos(Personas);
                Console.ReadKey();           
            }catch(Exception e)
            {
                Console.WriteLine("Error al cargar los datos" + "\n" + e.Message);
            }

        }
    }
}

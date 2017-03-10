using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {


            string S1 = "23123";
            string S2 = "a";

            string valor = validateText(S1);

            Console.WriteLine(valor);
            Console.ReadKey();



            /*
            string value;
            int diasLaborales;
            decimal salarioMensual;
            clsEmpleados empleados;
            empleados = new clsEmpleados();
            
            Console.WriteLine("ingrese su nombre: ");
            empleados.Nombre = Console.ReadLine();

            Console.WriteLine("ingrese su edad: ");
            value = Console.ReadLine();
            empleados.Edad = Convert.ToInt32(value);

            Console.WriteLine("ingrese su salario diario: ");
            value = Console.ReadLine();
            empleados.SalarioDiario = Convert.ToDecimal(value);

            Console.WriteLine("ingrese cantidad de dias laborales: ");
            value = Console.ReadLine();
            diasLaborales = Convert.ToInt32(value);

            salarioMensual = empleados.CalcularSalario(diasLaborales);

            Console.Clear();

            Console.WriteLine("su salario mensual es de {0:C2}", salarioMensual);
            Console.ReadKey();
            */

        }
        public static String validateText(String str)
        {
            string number = @"[0-9]";

            return validate(str, number);
        
        }

        public static String validate(string inputNumber, string rExpression)
        {
            String RegularExpression = rExpression;
            Regex re = new Regex(RegularExpression);
            Match match = re.Match(inputNumber);
            return match.Value;
        }
    }
}

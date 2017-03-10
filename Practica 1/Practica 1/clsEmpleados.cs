using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class clsEmpleados
    {
        private String nombre;
        private int edad;
        private decimal salarioDiario;

        public clsEmpleados()
        {
            Nombre = "";
            Edad = 0;
            SalarioDiario = 0.0m;
        }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public decimal SalarioDiario { get; set; }

        public decimal CalcularSalario(int diasLaborales)
        {
            return SalarioDiario*diasLaborales;
        }
    }
}

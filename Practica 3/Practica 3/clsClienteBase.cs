using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class clsClienteBase : clsAbsCliente
    {
        private string _Nombre;
        private string _Apellido;
        private int _Edad;

        public clsClienteBase()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Edad = 0;
        }

        public clsClienteBase(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public override string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public override string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public override int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLoAprendido
{
    public class clsBasePersona : clsAbsPersonas
    {
        private string _Nombre;
        private string _Apellido;
        private int _Edad;
        private Int64 _Dni;

        public clsBasePersona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Edad = 0;
            Dni = 0;           
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
        public override Int64 Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class clsBaseCliente : clsAbsCliente
    {
        private string _Nombre;
        private string _Apellido;
        private int _Edad;

        public clsBaseCliente()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Edad = 0;
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

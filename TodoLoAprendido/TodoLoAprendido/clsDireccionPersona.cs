using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLoAprendido
{
    public class clsDireccionPersona
    {
        private string _Localidad;
        private string _Calle;

        public clsDireccionPersona()
        {
            Localidad = string.Empty;
            Calle = string.Empty;
        }

        public string Localidad
        {
            get { return _Localidad; }
            set { _Localidad = value; }
        }
        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; }
        }
    }
}

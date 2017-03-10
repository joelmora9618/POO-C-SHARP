using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class clsDirecciones
    {
        private string _Provincia;
        private string _Localidad;
        private string _Calle;

        public clsDirecciones()
        {
            Provincia = string.Empty;
            Localidad = string.Empty;
            Calle = string.Empty;
        }

        public string Provincia
        {
            get{ return _Provincia; }
            set { _Provincia = value; }
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

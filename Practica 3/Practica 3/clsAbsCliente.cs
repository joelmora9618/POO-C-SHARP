using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public abstract class clsAbsCliente
    {
        public abstract string Nombre { get; set; }
        public abstract string Apellido { get; set; }
        public abstract int Edad { get; set; }
    }
}

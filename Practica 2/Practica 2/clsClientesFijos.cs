using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class clsClientesFijos : clsClientes
    {
        private string direccion;
        private Int64 telefono;
        private string email;

        public clsClientesFijos()
        {
            direccion = null;
            telefono = 0;
            email = null;
        }

        public string Direccion { get; set; }
        public Int64 Telefono { get; set; }
        public string Email { get; set; }

    }
}

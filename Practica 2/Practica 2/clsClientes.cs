using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class clsClientes
    {
        private string nombre;
        private string apellido;
        private int idCliente;

        public clsClientes()
        {
            nombre = null;
            apellido = null;
            idCliente = 0;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdCliente { get; set; }

    }
}

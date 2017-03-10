using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_lo_aprendido_2
{
    public interface intEntrada
    {
        void ConsultarDatos(List<clsContactoPersonas>Lista);
        void BorrarUsuario(Int64 Dni, List<clsContactoPersonas>Lista);
        void ModificarUsuario(Int64 Dni, List<clsContactoPersonas> Lista);
    }
}

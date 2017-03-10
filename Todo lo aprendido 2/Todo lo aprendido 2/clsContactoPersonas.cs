using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_lo_aprendido_2
{
    public class clsContactoPersonas : clsBasePersonas
    {
        private string _Telefono1;
        private string _Telefono2;
        private string _Email;
        private clsDireccionesPersonas _Direcciones;
        private int _Estado;

        public clsContactoPersonas()
        {
            Telefono1 = string.Empty;
            Telefono2 = string.Empty;
            Email = string.Empty;
            _Direcciones = new clsDireccionesPersonas();
            Estado = 0;
        }

        public clsContactoPersonas(string pNombre, string pApellido, int pEdad, Int64 pDni,
                                   string pTelefono1, string pTelefono2, string pEmail,
                                   string pLocalidad, string pCalle, int pEstado)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Edad = pEdad;
            Dni = pDni;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Email = pEmail;
            _Direcciones = new clsDireccionesPersonas();
            Direcciones.Localidad = pLocalidad;
            Direcciones.Calle = pCalle;
            Estado = pEstado;
        }

        public string Telefono1
        {
            get { return _Telefono1; }
            set { _Telefono1 = value; }
        }
        public string Telefono2
        {
            get { return _Telefono2; }
            set { _Telefono2 = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public clsDireccionesPersonas Direcciones
        {
            get { return _Direcciones; }
            set { _Direcciones = value; }
        }
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

    }
}

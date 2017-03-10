using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class clsContactoCliente : clsBaseCliente
    {
        private string _Telefono1;
        private string _Telefono2;
        private string _Gmail;
        private clsDireccionesCliente _Direccion;

        public clsContactoCliente()
        {
            _Direccion = new clsDireccionesCliente();
            Telefono1 = string.Empty;
            Telefono2 = string.Empty;
            Gmail = string.Empty;
        }

        public clsContactoCliente(string pNombre, string pApellido, int pEdad,
                                     string pTelefono1, string pTelefono2, string pGmail,
                                     string pProvincia, string pLocalidad, string pCalle)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Edad = pEdad;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Gmail = pGmail;
            _Direccion = new clsDireccionesCliente();
            Direccion.Provincia = pProvincia;
            Direccion.Localidad = pLocalidad;
            Direccion.Calle = pCalle;
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
        public string Gmail
        {
            get { return _Gmail; }
            set { _Gmail = value; }
        }
        public clsDireccionesCliente Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
    }
}

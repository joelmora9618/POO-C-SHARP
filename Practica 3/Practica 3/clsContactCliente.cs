using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class clsContactCliente : clsClienteBase
    {
        private Int64 _Telefono1;
        private Int64 _Telefono2;
        private string _Gmail;
        private clsDirecciones _Direcciones;

        public clsContactCliente()
        {
            _Direcciones = new clsDirecciones();
        }

        public clsContactCliente(string pNombre, string pApellido, int pEdad,
                                 Int64 pTelefono1, Int64 pTelefono2, string pGmail,
                                 string pProvincia, string pLocalidad, string pCalle)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Edad = pEdad;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Gmail = pGmail;
            _Direcciones = new clsDirecciones();
            Direcciones.Provincia = pProvincia;
            Direcciones.Localidad = pLocalidad;
            Direcciones.Calle = pCalle;
        }

        public Int64 Telefono1
        {
            get { return _Telefono1; }
            set { _Telefono1 = value; }
        }
        public Int64 Telefono2
        {
            get { return _Telefono2; }
            set { _Telefono2 = value; }
        }
        public string Gmail
        {
            get { return _Gmail; }
            set { _Gmail = value; }
        }

        public clsDirecciones Direcciones
        {
            get{ return _Direcciones;}
            set{ _Direcciones = value;}
        }

    }
}

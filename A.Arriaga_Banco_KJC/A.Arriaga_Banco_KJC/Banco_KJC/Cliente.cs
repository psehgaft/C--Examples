using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_KJC
{
    class Cliente
    {
        private string nombre;
        private string apPaterno;
        private string apMaterno;
        private string CURP;
        private Direccion direccion;
        private string telefono;
        private string email;

        #region "Propiedades"
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string ApPaterno
        {
            get { return apPaterno; }
            set { apPaterno = value; }
        }

        public string ApMaterno
        {
            get { return apMaterno; }
            set { apMaterno = value; }
        }

        internal Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        public Cliente(string _nombre, string _apPat, string _apMat, string _curp, 
            Direccion _dir, string _tel, string _email) 
        {
            this.nombre = _nombre;
            this.apPaterno = _apPat;
            this.apMaterno = _apMat;
            this.CURP = _curp;
            this.direccion = _dir;
            this.telefono = _tel;
            this.email = _email;
        }
        
        // Constructor vacio
        public Cliente() 
        {

        }
    }
}

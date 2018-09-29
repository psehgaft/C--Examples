using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MiLibreria;
using System.Windows.Forms;

namespace WindowsPersona
{
    public class Persona
    {
        private string nombre;
        private string apPaterno;
        private string apMaterno;
        private int edad;
        private string telefono;
        private string direccion;

        #region "Propiedades para cada variable"
        //Propiedades de cada variable
        public string PropiedadNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string propiedadApPaterno
        {
            get { return apPaterno; }
            set { apPaterno = value; }
        }
        public string propiedadApMaterno
        {
            get { return apMaterno; }
            set { apMaterno = value; }
        }
        public int propiedadEdad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string propiedadTelefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string propiedadDireccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        #endregion

        #region "Metodos Contructores"
        public Persona(string _nombre, string _apPat, string _apMat, int _edad)
        {
            this.nombre = _nombre;
            this.apPaterno = _apPat;
            this.apMaterno = _apMat;
            this.edad = _edad;

        }

        public Persona(string _nombre, string _apPat, string _apMat, string _direcc, string _tel)
        {
            this.nombre = _nombre;
            this.apPaterno = _apPat;
            this.apMaterno = _apMat;
            //this.edad = _edad;
            this.direccion = _direcc;
            this.telefono = _tel;

        }
        #endregion

        #region "Metodos Pulicos (Comportamiento de la clase)"
        public void Camina()
        {
            MessageBox.Show(nombre + "esta caminando...");
        }

        public void Come()
        {
            MessageBox.Show(nombre + "esta comiendo...");
        }

        public void Duerme()
        {
            MessageBox.Show(nombre + "esta durmiendo...");
        }

        public void Baila()
        {
            MessageBox.Show(nombre + "esta bailando...");
        }

        #endregion
    }
}


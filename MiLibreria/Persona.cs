using System;
using System.Collections.Generic;
using System.Text;

namespace MiLibreria
{
    public class Persona
    {
        private string nombre;

        public string PropiedadNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string apPaterno;
        public string apMaterno;
        public int edad;

        public Persona(string _nombre, string _apPat,
            string _apMat, int _edad)
        {
            this.nombre = _nombre;
            this.apPaterno = _apPat;
            this.apMaterno = _apMat;
            this.edad = _edad;
        }
        

    }
}

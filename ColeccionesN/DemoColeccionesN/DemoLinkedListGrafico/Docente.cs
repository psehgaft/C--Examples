using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinkedListGrafico
{
    public class Docente
    {
        private String nombre;
        private String clave;

        public String propiedadNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public String propiedadClave
        {
            get { return clave; }
            set { clave = value; }
        }

        public Docente(string n, string c)
        {
            this.nombre = n;
            this.clave = c;
        }

        public string mostrarNombre()
        {
            return nombre;
        }
        

        
    }
}

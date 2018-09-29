using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_KJC
{
    class Direccion
    {
        // Estas son las variables de la clase
        private string calle;
        private int num_interior;
        private int num_exterior;
        private string colonia;
        private string ciudad;
        private int codigo_postal;

        #region "Propiedades"
        // Definimos las propiedades (lectura y escritura, -set, get-) para cada variable
        public string Calle
        {
          get { return calle; }
          set { calle = value; }
        }
                
        public int Num_interior
        {
          get { return num_interior; }
          set { num_interior = value; }
        }              

        public int Num_exterior
        {
          get { return num_exterior; }
          set { num_exterior = value; }
        }

        public string Colonia
        {
          get { return colonia; }
          set { colonia = value; }
        }
                
        public int Codigo_postal
        {
          get { return codigo_postal; }
          set { codigo_postal = value; }
        }
        #endregion

        #region "Constructores"
        // Constructor para cuando se dan todos los datos
        public Direccion(string _calle, int _num_int, int _num_ext, string _col, 
            string _ciudad, int _cp) 
        {
            this.calle = _calle;
            this.num_interior = _num_int;
            this.num_exterior = _num_ext;
            this.colonia = _col;
            this.ciudad = _ciudad;
            this.codigo_postal = _cp;
        }
        // Constructor para cuando hay solo numero exterior
        public Direccion(string _calle, int _num_ext, string _col, string _ciudad, int _cp)
        {
            this.calle = _calle;
            this.num_exterior = _num_ext;
            this.colonia = _col;
            this.ciudad = _ciudad;
            this.codigo_postal = _cp;
        }
    #endregion;
    }
}

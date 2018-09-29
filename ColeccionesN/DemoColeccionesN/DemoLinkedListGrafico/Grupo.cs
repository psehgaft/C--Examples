using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinkedListGrafico
{
    public class Grupo
    {
        private LinkedList<Docente> docentes;

        public LinkedList<Docente> propiedadDocentes
        {
            get { return docentes; }
            set { docentes = value; }
        }
        
        
        public Grupo()
        {
            docentes = new LinkedList<Docente>(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoLinkedListGrafico
{
    public partial class Form1 : Form
    {
        private Grupo grupo1;
        private LinkedList<Docente> docentesAux;
        public Form1()
        {
            InitializeComponent();
            grupo1 = new Grupo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //docenteAux nunca se crea, solo se usa para obtener 
            //una referencia al LinkedList que se encuentra en la clase Grupo
            docentesAux = grupo1.propiedadDocentes;

            string nombre = txtNombre.Text.Trim();
            string clave = txtClave.Text.Trim();

            Docente doc = new Docente(nombre, clave);

            //Utilizacion de la coleccion generica LinkedList<>

            docentesAux.AddFirst(doc);
            MessageBox.Show("Docente: " + doc.mostrarNombre());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            docentesAux = grupo1.propiedadDocentes;
            StringBuilder sb = new StringBuilder();
            foreach (Docente d in docentesAux)
            {
                sb.Append("Nombre: " + d.mostrarNombre() + "\t"
                          + "Clave: " + d.propiedadClave + "\n"
                          + "*********************************\n");
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
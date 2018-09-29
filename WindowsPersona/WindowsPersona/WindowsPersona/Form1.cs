using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsPersona
{
    public partial class Form1 : Form
    {
        ArrayList personas = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void muestra_Personas()
        {
            string mjs_personas = "";
            foreach (Persona p in personas)
            {
                mjs_personas += p.PropiedadNombre + " " + p.propiedadApPaterno + "\n";
            }

            MessageBox.Show(mjs_personas);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string apPat = txtapPat.Text;
            string apMat = txtapMat.Text;
            //int edad = txtEdad.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            Persona p = new Persona(nom, apPat, apMat, direccion, telefono);
            personas.Add(p);

            txtNombre.Text = "";
            txtapPat.Text = "";
            txtapMat.Text = "";
            //txtedad.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            muestra_Personas();
            picCarita.Visible = true;
        }
    }
}
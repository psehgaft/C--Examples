using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Banco_KJC
{
    
    public partial class Form1 : Form
    {
        List<Cliente> lista = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string app = txtApPaterno.Text;
            string apm = txtApMaterno.Text;
            string curp = txtCURP.Text;
            string tel = txtTelefono.Text;
            string mail = txtCorreoElec.Text;
            string calle = txtCalle.Text;
            string nex = txtNumExt.Text;
            string nin = txtNumInt.Text;
            string col = txtColonia.Text;
            string cp = txtCP.Text;
            string cd = txtCiudad.Text;

            Direccion dir = new Direccion(calle,Convert.ToInt32(nin),
                Convert.ToInt32(nex),col,cd,Convert.ToInt32(cp));
            Cliente cliente1 = new Cliente(nom, app, apm, curp, dir, tel, mail);

            // Guardar el objeto cliente en una lista dinamica
            lista.Add(cliente1);
            MessageBox.Show("Guardado..");
         }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string entrada = e.KeyChar.ToString().ToUpper();
            e.KeyChar = Convert.ToChar(entrada);
            if (Regex.IsMatch(entrada, @"[A-Z]|Ñ|\s") == false
                && entrada.Equals("\b") == false)
            {
                Console.WriteLine("Char : " + entrada);
                e.KeyChar = Convert.ToChar("\x0");
            }
        }

        private void txtApPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            string entrada = e.KeyChar.ToString().ToUpper();
            e.KeyChar = Convert.ToChar(entrada);
            if (Regex.IsMatch(entrada, @"[A-Z]|Ñ|\s") == false
                && entrada.Equals("\b") == false)
            {
                Console.WriteLine("Char : " + entrada);
                e.KeyChar = Convert.ToChar("\x0");
            }
        }

        private void txtApMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            string entrada = e.KeyChar.ToString().ToUpper();
            e.KeyChar = Convert.ToChar(entrada);
            if (Regex.IsMatch(entrada, @"[A-Z]|Ñ|\s") == false
                && entrada.Equals("\b") == false)
            {
                Console.WriteLine("Char : " + entrada);
                e.KeyChar = Convert.ToChar("\x0");
            }
        }

        private void txtCURP_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            string entrada = e.KeyChar.ToString().ToUpper();
            e.KeyChar = Convert.ToChar(entrada);
            if (Regex.IsMatch(entrada, @"[0-9]") == false
                && entrada.Equals("\b") == false)
            {
                Console.WriteLine("Num : " + entrada);
                e.KeyChar = Convert.ToChar("\x0");
            }
        }
    }
}
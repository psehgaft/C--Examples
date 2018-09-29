using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;



namespace DemoColeccionesN
{
    public partial class Form1 : Form
    {
        private Stack pila;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pila = new Stack();

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            string s = txtNumero.Text;
            if (s != "")
            {
                pila.Push(int.Parse(s));
                rtbInfo.Text = this.mostrarElementos();
                txtNumero.Text = "";
            }

        }

        private void btnPOP_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                int x = (int)pila.Pop();
                rtbInfo.Text = this.mostrarElementos();
                MessageBox.Show("Elemento despilado: " + x.ToString());
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            int x = (int)pila.Peek();
            MessageBox.Show("El elemento en TOP: " + x.ToString());
        }

        private string mostrarElementos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int x in pila)
            {
                sb.Append(x.ToString() + " ");
            }
            return sb.ToString();
        }
    }
}
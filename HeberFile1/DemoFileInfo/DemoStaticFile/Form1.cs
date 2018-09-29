using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DemoStaticFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Open(@"C:\Documents and Settings\Continua_2\Mis documentos\Visual Studio 2005\Projects\Heber\HeberFile1\hola.doc", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadToEnd();
            rtbInfo.Text = s;
            lblNombre.Text = fs.Name + " -> Tamaño: " + fs.Length.ToString();
        }
    }
}
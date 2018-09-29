using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DemoFileIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\Documents and Settings\Continua_2\Mis documentos\Visual Studio 2005\Projects\Heber\HeberFile1\Hola.doc");
            string nombreComp = fi.FullName;
            long tam = fi.Length;
            string ext = fi.Extension;

            rtbInfo.AppendText("Nombre completo: " + nombreComp + "\nTamaño:" + tam.ToString() + "\nExt: " + ext);
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Documents and Settings\Continua_2\Mis documentos\Visual Studio 2005\Projects\Heber");
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                rtbInfo.AppendText("+" + d.Name + "\n");
                foreach (FileInfo fi in d.GetFiles())
                {
                    rtbInfo.AppendText("\t- " + fi.Name + "\n");
                }
            }
        }
    }
}
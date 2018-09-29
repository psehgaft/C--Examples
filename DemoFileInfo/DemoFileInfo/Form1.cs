using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace DemoFileInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {FileInfo fi  = new FileInfo(@"C:\hola.txt");
        string nombreComp = fi.FullName;
        long tam = fi.Length;
        string ext = fi.Extension;
           
            
            
            richTextBox1.AppendText("Nombre: " + nombreComp + "\nTamaño: " + tam.ToString()
                                   + "\nExt: " +ext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\temp");
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                richTextBox1.AppendText("+" + d.Name + "\n");
                foreach (FileInfo fi in d.GetFiles())
                {
                    richTextBox1.AppendText("\t- " + fi.Name+"\n");
                }

            }

        }
   
    }
}
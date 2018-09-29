using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DemoFileStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.SelectedIndex = 0;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            switch (cmbOperacion.SelectedIndex)

            {
                
                case 0:
                    MessageBox.Show("Elija operacion");
                    break;
                case 1: //caso leer archivo
                    //leia una ruta absolua (previamente establecida
                    
                    
                    //FileStream fs = new FileStream(@"c:\hola.txt", FileMode.Open);

                    DialogResult res = ofdAbrir.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        FileStream fs = (FileStream)ofdAbrir.OpenFile();
                        //FileStream fs = new FileStream(@"c:\hola.txt", FileMode.Open);
                        StreamReader sr = new StreamReader(fs);
                        string s = sr.ReadToEnd();
                        rtbbox.AppendText(s);
                    }
                    else MessageBox.Show("no se pudo abrir archivo");
                    break;
                    
                case 2://caso escribir archivo

                    if (rtbbox.Text != "")
                    {
                        // FileStream fsEsc = new FileStream(@"c:\nuevo.txt", FileMode.Create);
                        DialogResult resEsc = sfdGuardar.ShowDialog();
                        if (resEsc == DialogResult.OK && sfdGuardar.FileName != "")
                        {
                            FileStream fsEsc = new FileStream(sfdGuardar.FileName, FileMode.Create);
                            StreamWriter sw = new StreamWriter(fsEsc);

                            string cad = "hola amigos!!!!!";
                            sw.WriteLine(cad);
                            sw.Close();
                            MessageBox.Show("Archivo escrito");
                        }
                        else MessageBox.Show("No se ha podido guardar");
                    }
                    else MessageBox.Show("Escriba un mensaje");
                    break;
            
            }
        }
    }
}
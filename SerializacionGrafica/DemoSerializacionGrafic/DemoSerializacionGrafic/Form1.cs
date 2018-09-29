using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DemoSerializacionGrafic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSerializar_Click(object sender, EventArgs e)
        {
            string s = rtbInfo.Text;
            if (s != "")
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("../../Cadena.txt", FileMode.Create);
                bf.Serialize(fs, s);
                fs.Close();
                MessageBox.Show("Serializacion completa..");
            }
            else MessageBox.Show("Introdusca Cadena");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CadastroUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            double x = aleatorio.Next(0, 9999);
            textNovo.Text = x.ToString();

        }

        private void textNovo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtCelular.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {



            string path = @"C:\Users\Eduardo.M\Documents\Estudos\CURSO C#\teste.ini";

            if (!File.Exists(path))
            {
                using (var sw = File.CreateText(path))
                {
                    sw.WriteLine(textNovo.Text + '\t' + textBox3.Text + 't' + txtEndereco.Text + '\t' + txtCelular.Text.ToString());

                }
            }
            else
            {
                using (var sw = File.AppendText(path))
                {
                    sw.WriteLine(textNovo.Text + '\t' + textBox3.Text + '\t' + txtEndereco.Text + '\t' + txtCelular.Text.ToString());

                }
            }

            textNovo.Text = string.Empty;
            textBox3.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtCelular.Text = string.Empty;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
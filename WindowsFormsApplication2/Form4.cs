using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        string file_users = "acessos.txt";
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utilizador user = new utilizador();
            

            if ((textBox2.Text != textBox3.Text) || (textBox2.Text == ""))
            {
                MessageBox.Show("A password não é igual à confirmação!");
                return;
            }
            user.nome = textBox1.Text;
            user.password = textBox2.Text;
            user.perfil = "D";
            StreamWriter sw;
            if (File.Exists(file_users))
            {
                sw = File.AppendText(file_users);

            }
            else
            {
                sw = File.CreateText(file_users);
            }
            sw.WriteLine(user.nome + ";" + user.password + ";" + user.perfil);
            sw.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

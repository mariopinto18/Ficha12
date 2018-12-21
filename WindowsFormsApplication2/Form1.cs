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
    public partial class Form1 : Form
    {
        string file_users = "acessos.txt";
        utilizador user = new utilizador();
        public Form1()
        {
            InitializeComponent();
        }

        private void opção1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public bool user_valido()
        {
            if (File.Exists(file_users))
            {
                StreamReader sr = File.OpenText(file_users);
                string linha = "";
                while ((linha = sr.ReadLine()) != null)
                {
                    string [] campos= linha.Split(';');
                    if ((campos[0] == textBox1.Text) && (campos[1] == textBox2.Text))
                    {
                        // --- com método set
                        user.setNome(textBox1.Text);
                        user.setPassword(textBox2.Text);
                        //-------Sem métodos set (ou get)
                        user.nome = textBox1.Text;
                        user.password = textBox2.Text;
                        user.perfil = campos[2];
                        return true;
                    }
                }
                sr.Close();
                return false;
            }
            else
                return false;

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
                     
            if (user_valido())
            {
              
                status2.Text = "Bem-vindo " + user.nome;
                panel1.Visible = false;   // painel de autenticação
               
                panel2.Location = new Point(459, 47);
                panel2.Visible = true;     // painel de logout
             
                label3.Text = user.nome;

                // tornar as opções de menu visíveis
                opcao1.Visible = true;
                opcao2.Visible = true;
                opAdicionarFotos.Visible = true;
                opConsultarFotos.Visible = true;
                opAdicionarVideos.Visible = true;
                opConsultarVideos.Visible = true;

            }
            else
            {
                status2.Text = "User ou password incorretos!";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            opcao1.Visible = false;
            opcao2.Visible = false;
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            button2.Visible = false;

            panel1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
           
            opcao1.Visible = false;
            opcao2.Visible = false;
        }

        private void opAdicionarVideos_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = Form.ActiveForm;
            this.Hide();
            
            Form f2 = new Form2();
            f2.Show();
            
        }

        private void opAdicionarFotos_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = Form.ActiveForm;
            this.Hide();
            Form f3 = new Form3();
            f3.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            button2.Visible = false;
            opcao1.Visible = false;
            opcao2.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Location = new Point(859, 547);
            f4.Show();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(listBox1.SelectedItem.ToString());
            /*
            webBrowser1.GoHome();     // Navigates webBrowser1 to the home page of the current user
            webBrowser1.GoSearch();   // Navigates webBrowser1 to the search page of the current user.
            webBrowser1.Stop();       // para execussão do objeto no webBrowser
            webBrowser1.Dispose();    // remove a instância do objeto
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            this.Close();
            variaveis.CurrentForm.Show();

        }

      /*  private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost=true;
         
        }
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}

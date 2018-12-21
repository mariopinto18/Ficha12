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
    public partial class Form3 : Form
    {
        static int i = 0;
        static string foto_nome ="foto ";
        static Bitmap foto;
        static int foto_numero=1;
        public Form3()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            variaveis.CurrentForm.Show();
        }

        // SELECIONAR E ADICIONAR IMAGENS À LISTBOX E IMAGELIST
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
           
            openFileDialog1.Filter =
"Images (*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
            openFileDialog1.Title = "Selecione Imagem";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
               // adiciona à imagelist
                imageList1.Images.Add(foto_nome + foto_numero.ToString("##"), Image.FromFile(openFileDialog1.FileName));
                // adiciona á listbox
                listBox1.Items.Add(foto_nome + foto_numero.ToString("##") + "   "+ openFileDialog1.FileName);




                // coloca imagem selecionada na picturebox
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                // OU:
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);


                // adiciona 1 ao número da imagem
                foto_numero++;
            }
            openFileDialog1.Dispose();
           
        }

        // IMAGEM SEGUINTE
        private void button3_Click(object sender, EventArgs e)
        {
            if (i<imageList1.Images.Count-1)   // o array começa em 0...
            {
                i++;
            }
          
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = imageList1.Images[i];
           
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i >0)
            {
                i--;
            }
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = imageList1.Images[i];
       
          

        }

        // GUARDAR IMAGENS
        private void button6_Click(object sender, EventArgs e)
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory() + "\\imagens\\";
            
            int num = imageList1.Images.Count;
            for (int i=0; i<num; i++)
            {
                Bitmap foto = new Bitmap(imageList1.Images[i]);
               
                foto.Save(currentDirectory+"foto"+i.ToString("00")+".jpg");
            }

       }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //REMOVE
        private void button2_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            imageList1.Images.RemoveAt(k);  // remove da ImageList
            listBox1.Items.RemoveAt(k);     // remove da listBox
        }
    }
}

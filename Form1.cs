using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herramientas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/Ivanesa/Desktop/mercadoibre/Nueva carpeta" + listBox1.Text + ".jpeg";
            pictureBox2.ImageLocation = "C:/Users/Ivanesa/Desktop/mercadoibre/Nueva carpeta" + comboBox1.Text + ".jpeg";


        }
    }
}

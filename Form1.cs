using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public string usuariorecived;
        public Form1()
        {
            InitializeComponent();
            usuariorecived = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 iniciar = new Form3(usuariorecived);
            this.Hide();
            iniciar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 registro = new Form2(usuariorecived);
            this.Hide();
            registro.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
       
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form3 iniciar = new Form3(usuariorecived);
            this.Hide();
            iniciar.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 registro = new Form2(usuariorecived);
            this.Hide();
            registro.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            acercadelbl.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            acercadelbl.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }
    }
}

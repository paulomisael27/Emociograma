using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emociograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema desenvolvido para medir o seu emocional", "Sobre");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 OutroForm = new Form3();
            OutroForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 OutroForm = new Form4();
            OutroForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 1000;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.gle/QbimzVZ7s89ETwyx5");
        }
    }
}

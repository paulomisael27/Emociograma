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
    public partial class Form2 : Form
    {
        private object comm;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;            

            if (textBox2.Text == "")
            {
                MessageBox.Show("Nome Obrigatório!", "Alerta");
                textBox2.Focus();
                return;
            }

            string strCon = "CONEXÃO NO SQL/DATABASE"
            MySqlConnection cn = new MySqlConnection(strCon);
            cn.Open(); //abre a conexão
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into usuario values (0, '" + textBox2.Text);
            comm.ExecuteNonQuery();
            comm.Connection.Close();//fecha a conexão
            MessageBox.Show("REGISTRO REALIZADO COM SUCESSO!");

            MessageBox.Show(textBox2.Text + ", registro realizado com sucesso!", "Emociograma");
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.ForeColor = label2.ForeColor == Color.Red ? Color.Black : Color.Red;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}
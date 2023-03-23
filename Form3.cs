using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Emociograma
{
    public partial class Form3 : Form
    {
        private object label3;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (textBox3.Text == "")
            {
                MessageBox.Show("Nome Obrigatório!", "Alerta");
                textBox3.Focus();
                return;
            }

            using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("emociogramatv@gmail.com", "senha");

                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new System.Net.Mail.MailAddress("emociogramatv@gmail.com");

                    mail.To.Add(new System.Net.Mail.MailAddress("e-mail corporativo"));
                    mail.Subject = ("Emociograma - Avaliação de Estado do Colaborador");
                    mail.IsBodyHtml = true;
                    mail.Body = textBox3.Text
                        + (" optou pela carinha amarela, acho que o usuário não está muito bem hoje.")
                        + DateTime.Now.ToString(" dd/MM/yyyy")
                        + DateTime.Now.ToString(" HH:mm:ss");
                    MessageBox.Show(textBox3.Text + ", registro realizado com sucesso!", "Emociograma");
                    this.Close();

                    smtp.Send(mail);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.ForeColor = label2.ForeColor == Color.Red ? Color.Black : Color.Red;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace _03_SmtpHttpHelpers
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            string Email = EmailBox.Text.ToString();
            string Name = NameBox.Text.ToString();
            string subj = TopicBox.Text.ToString();
            string msg = Main_textBox.Text.ToString();
            string att = attached_label.Text.ToString();


            Helpers.Notification.EmailControler.SendEmail(Email, Name, subj, msg, att);
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            attached_label.Text = Attache_textBox.Text.ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "\nAdress: "+EmailBox.Text.ToString()+
                "\nFor: " + NameBox.Text.ToString()+
                "\nSubject: " + TopicBox.Text.ToString()+
                "\nMessege:\n" + Main_textBox.Text.ToString()+
                "\nAttached files: " + Attache_textBox.Text.ToString()

                );
        }
    }
}

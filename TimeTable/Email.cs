using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TimeTable
{
    public partial class Email : Form
    {
        static Email e;

        public Email()
        {
            InitializeComponent();
            e = this;
        }
        private void btnCloseEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnSendEmail_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MailMessage msg = new MailMessage();
        //        msg.From = new MailAddress(txtEmail.Text, "gethealthtip");
        //        msg.To.Add(new MailAddress(txtReceiver.Text));
        //        msg.Subject = txtSubject.Text;
        //        msg.Body = rtbMessage.Text;
        //        msg.IsBodyHtml = true;

        //        SmtpClient smtp = new SmtpClient();
        //        smtp.Host = "smtp.gmail.com";
        //        smtp.Credentials = new NetworkCredential(txtEmail.Text, txtPassword.Text);
        //        smtp.EnableSsl = true;
        //        smtp.Send(msg);
        //        MessageBox.Show("Mail was Send!");
        //    } catch { }


        //}


        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            var message = new MailMessage(txtEmail.Text.Trim(), txtReceiver.Text.Trim());
            message.Subject = txtSubject.Text;
            message.Body = rtbMessage.Text;

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential(txtEmail.Text, txtPassword.Text);
                mailer.EnableSsl = true;
                mailer.Send(message);
            }

            txtReceiver.Text = null;
            txtSubject.Text = null;
            rtbMessage.Text = null;
        }
    }
}

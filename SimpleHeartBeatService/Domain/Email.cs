using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SimpleHeartBeatService
{
    class Email
    {
        public Mensagem Mensagem { get; set; }

        public SmtpClient smtp { get; set; }

        public MailMessage mail { get; set; }        

        public Email(Mensagem Mensagem)
        {
            this.Mensagem = Mensagem;
        }

        public void enviarEmail()
        {
            CarregarProtocoloSmtp();

            CarregarDadosEmail();

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }                 
        
        public void CarregarProtocoloSmtp()
        {

            this.smtp = new System.Net.Mail.SmtpClient();

            smtp.Host = "smtp.gmail.com";

            smtp.Port = 587;

            smtp.EnableSsl = true;

            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new System.Net.NetworkCredential(Mensagem.EmailRemetente, Mensagem.PasswordRemetente);
        }

        public void CarregarDadosEmail()
        {
            mail = new System.Net.Mail.MailMessage();

            mail.From = new System.Net.Mail.MailAddress(this.Mensagem.EmailRemetente);

            mail.To.Add(new System.Net.Mail.MailAddress(this.Mensagem.EmailDestinatario));

            mail.CC.Add(new System.Net.Mail.MailAddress(this.Mensagem.EmailDestinatario));

            mail.Bcc.Add(new System.Net.Mail.MailAddress(this.Mensagem.EmailDestinatario));

            mail.Subject = this.Mensagem.Titulo;

            mail.Body = this.Mensagem.Texto;

            mail.BodyEncoding = System.Text.Encoding.UTF8;
            
            mail.IsBodyHtml = true;
        }
        
    }
}

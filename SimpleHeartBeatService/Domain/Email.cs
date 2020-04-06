using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleHeartBeatService
{
    class Email
    {
        public Mensagem Mensagem { get; set; }
        
        public Email(Mensagem Mensagem)
        {
            this.Mensagem = Mensagem;
        }

        public void enviarEmail()
        {           

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();            
            
            smtp.Host = "smtp.gmail.com";
            
            smtp.Port = 587;
            
            smtp.EnableSsl = true;
            
            smtp.UseDefaultCredentials = false;
            
            smtp.Credentials = new System.Net.NetworkCredential("", "");                
            

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();            
            
            mail.From = new System.Net.Mail.MailAddress("anonimo@gmail.com");

            mail.To.Add(new System.Net.Mail.MailAddress(this.Mensagem.Destinatario));

            mail.CC.Add(new System.Net.Mail.MailAddress(this.Mensagem.Destinatario));

            mail.Bcc.Add(new System.Net.Mail.MailAddress(this.Mensagem.Destinatario));

            mail.Subject = this.Mensagem.Titulo;

            mail.Body = this.Mensagem.Texto;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }                        
        
    }
}

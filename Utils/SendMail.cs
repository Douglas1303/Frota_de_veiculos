using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Utils
{
    public static class SendMail
    {

        public static void SendMailUsuario()
        {
            //cria uma mensagem
            MailMessage mail = new MailMessage();

            //define os endereços
            mail.From = new MailAddress("macoratti@yahoo.com");
            mail.To.Add("macoratti@ig.com.br");

            //define o conteúdo
            mail.Subject = "Este é um simples ,muito simples email";
            mail.Body = "Este é o corpo do email";

            //envia a mensagem
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Send(mail);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Clínica_Goncalo_Silva_CET68
{
    internal class Menssagens
    {
        /// <summary>
        /// esta classe é um servico de mensagens envia as mensagens automaticas de cancelamento,
        /// marcação, lembrete de consulta de dia segunte e os emails de comunicação geral que seguem
        /// para todos os clientes
        /// Consuante o tipo de mensagem ele recebe os paramtros que necessita como: data e hora da consulta,
        /// nome do dono, motivo, etc
        /// Se o envio falhar ele solta uma message box de erro (pode acontecer por exemplo se o email que o cliente 
        /// forneceo estiver errado ou não existir)
        /// </summary>



        SmtpClient smtp = new SmtpClient();

        MailMessage mail = new MailMessage();   

        /// <summary>
        /// Envia email de cancelamento
        /// </summary>
        public void Cancelamento(string email, string nome, string consulta, string funcao, string animal, string motivo)
        {   try
            {

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("dalton.fury120@gmail.com", "evfsczhomlyzjkoa");

                mail.From = new MailAddress("dalton.fury120@gmail.com");

                if (!string.IsNullOrWhiteSpace(email))
                {
                    mail.To.Add(new MailAddress(email));
                }


                mail.Subject = "Cancelamento da consulta de: " + consulta;
                mail.Body = $"Caro {nome} vimos por este meio informar que a consulta de {funcao} do {animal} de dia {consulta} foi canceladada pelo motivo: {motivo}";

                smtp.Send(mail);
            }
            catch (Exception )
            {

                MessageBox.Show("Erro ao enviar email!!");
            }
            


        }

        /// <summary>
        /// Envia email de confimação de marcação de consulta
        /// </summary>
        public void Marcacao(string email, string nome, string consulta, string animal, string tipo)
        {
            try
            {

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("dalton.fury120@gmail.com", "evfsczhomlyzjkoa");

                mail.From = new MailAddress("dalton.fury120@gmail.com");

                if (!string.IsNullOrWhiteSpace(email))
                {
                    mail.To.Add(new MailAddress(email));
                }


                mail.Subject = "Aviso de marcação de consulta dia: " + consulta;
                mail.Body = $"Caro {nome} vimos por este meio informar que tem consulta de {tipo} marcada no dia {consulta} para o: {animal}";

                smtp.Send(mail);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao enviar email!!");
            }



        }

        /// <summary>
        /// Envia email a avisar que tem consulta no dia seguinte
        /// </summary>
        public void DiaSeguinte(string email, string nome, string consulta, string animal, string tipo)
        {
            try
            {

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("dalton.fury120@gmail.com", "evfsczhomlyzjkoa");

                mail.From = new MailAddress("dalton.fury120@gmail.com");

                if (!string.IsNullOrWhiteSpace(email))
                {
                    mail.To.Add(new MailAddress(email));
                }


                mail.Subject = "Aviso de consulta marcada amanhã dia: " + consulta;
                mail.Body = $"Caro {nome} vimos por este meio informar que tem consulta de {tipo} marcada amanhã dia {consulta} para o: {animal}";

                smtp.Send(mail);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao enviar email!!");
            }



        }

        /// <summary>
        /// Envia email com  uma mensagem escrita para todos os clientes
        /// </summary>
        public void MensagemGeral(string email, string msg, string titulo)
        {
            try
            {

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("dalton.fury120@gmail.com", "evfsczhomlyzjkoa");

                mail.From = new MailAddress("dalton.fury120@gmail.com");

                if (!string.IsNullOrWhiteSpace(email))
                {
                    mail.To.Add(new MailAddress(email));
                }


                mail.Subject = titulo;
                mail.Body = msg;

                smtp.Send(mail);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao enviar email!!");
            }



        }
    }
}

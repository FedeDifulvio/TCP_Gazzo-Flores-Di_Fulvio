using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Dominio;
namespace Negocio
{
    public class EnvioMail
    {
        private MailMessage email;
        private SmtpClient server;

        public EnvioMail()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("centromedicoflores@gmail.com", "centromedicoflores1234");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void armarCorreo( Turno Turno)
        {
            email = new MailMessage();
            email.From = new MailAddress("noreply@centromedicoflores.com");
            email.To.Add(Turno.Paciente.Mail);
            email.Subject ="Turno asignado-Clinica San Flores";
            email.IsBodyHtml = true;
            email.Body = "<p>Estimado "+ Turno.Paciente.Nombre +" "+Turno.Paciente.Apellido + ",<br/> Se le ha asignado un turno el dia "+ Turno.Fecha.ToShortDateString()+" a las "+Turno.Hora+ " horas. <br/>En el caso de no presentarse al turno avisar con antelacion. <br/> Saludos cordiales.   </p> ";
            //email.Body = cuerpo;

        }

        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

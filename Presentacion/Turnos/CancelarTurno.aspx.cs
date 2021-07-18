using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion.Turnos
{
    public partial class CancelarTurno : System.Web.UI.Page
    {
        public Turno turno;
        public List <Turno> lista;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                

                    id = int.Parse(Request.QueryString["id"]);
                    lista = (List<Turno>)Session["ListaTurnos"];
                    turno = lista.Find(x => x.ID == id);

                    TextBoxNumero.Text = turno.ID.ToString();
                    TextBoxMedico.Text = turno.Medico.Nombre + " " + turno.Medico.Apellido;
                    TextBoxPaciente.Text = turno.Paciente.Nombre + " " + turno.Paciente.Apellido;
                    TextBoxFecha.Text = turno.Fecha.ToShortDateString();
                    TextBoxHora.Text = turno.Hora;
                    TextBoxEstado.Text = turno.Estado;
                
                

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                TurnoNegocio negocio = new TurnoNegocio();
                negocio.CancelarTurno(turno.ID);
                string script = "confirmarAccion( 5, 'RegistroTurnos.aspx')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeOk", script, true);

            }
            catch (Exception)
            {

                throw;
            }
            

           

        }
    }
}
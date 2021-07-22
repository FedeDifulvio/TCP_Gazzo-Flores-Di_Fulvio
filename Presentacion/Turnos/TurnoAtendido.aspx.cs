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
    public partial class TurnoAtendido : System.Web.UI.Page
    {
        public TurnoNegocio turnoNegocio = new TurnoNegocio();
        public Turno turno = new Turno();
        public int idTurno;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                
                
                    idTurno = int.Parse(Request.QueryString["id"]);
                    turno = turnoNegocio.Listar().Find(x => x.ID == idTurno);

                    NombreTxt.Text = turno.Paciente.Nombre + " " + turno.Paciente.Apellido;
                    EspecialidadTxt.Text = turno.Especialidad.Nombre;
                    FechaTextBox.Text = turno.Fecha.ToShortDateString();
                    HoraTxt.Text = turno.Hora + " hs";
                   
                if(!IsPostBack) txtObservaciones.Text = turno.Observacion;



            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
            
        }

        protected void btnFinalizarTurno_Click(object sender, EventArgs e)
        {
            Turno aux = new Turno();
            aux = turno;
            aux.Observacion = txtObservaciones.Text;
            aux.Estado = "Atendido";


            try
            {
                turnoNegocio.ModificarTurno(aux.ID, aux.Fecha, aux.Hora, aux.Observacion, aux.Estado);
                string script = "confirmarAccion( 6, 'TurnosMedico.aspx')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeOk", script, true);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }


            
        }
    }
}
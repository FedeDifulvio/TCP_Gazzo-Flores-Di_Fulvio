using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class EliminarPaciente : System.Web.UI.Page
    {
        public Paciente pacienteEliminar = new Paciente();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                List<Paciente> Lista = (List<Paciente>)Session["ListaPacientes"];

                id = int.Parse(Request.QueryString["id"]);

                pacienteEliminar = Lista.Find(x => x.ID == id);

                CargarDdl();

                TextBoxNombre.Text = pacienteEliminar.Nombre;
                TextBoxApellido.Text = pacienteEliminar.Apellido;
                TextBoxDireccion.Text = pacienteEliminar.Direccion;
                TextBoxDni.Text = pacienteEliminar.DNI;
                TextBoxMail.Text = pacienteEliminar.Mail;
                TextBoxTelefono.Text = pacienteEliminar.Telefono;
                from_date.Text = pacienteEliminar.FechaNacimiento.ToString("yyyy-MM-dd");
                DdlObraSocial.SelectedValue = pacienteEliminar.ObraSocial.ID.ToString();

            }
        }
        public void CargarDdl()
        {
            try
            {
                ObraSocialNegocio negocio = new ObraSocialNegocio();

                DdlObraSocial.DataSource = negocio.listar();
                DdlObraSocial.DataValueField = "ID";
                DdlObraSocial.DataTextField = "Nombre";

                DdlObraSocial.DataBind();

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }

        }
        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            PacienteNegocio negocio = new PacienteNegocio();

            Paciente aux = new Paciente();

            try
            {

                negocio.bajaLogica(int.Parse(Request.QueryString["id"]));
                string script = "confirmarAccion( 3 , 'RegistrosPaciente.aspx')";
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
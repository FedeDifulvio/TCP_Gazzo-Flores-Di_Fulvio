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
    public partial class ModificarPaciente : System.Web.UI.Page
    {
        public Paciente pacienteModificar= new Paciente();
        public Usuario usuario = new Usuario();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            usuario = (Usuario)Session["Usuario"];
            if (usuario.TipoUsuario.Id != 1 && usuario.TipoUsuario.Id != 2)
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");
            }


            if (!IsPostBack)
            {

           
                List<Paciente> Lista = (List<Paciente>)Session["ListaPacientes"];

                id = int.Parse( Request.QueryString["id"]);

                pacienteModificar = Lista.Find(x => x.ID == id);

                CargarDdl();
            
                TextBoxNombre.Text = pacienteModificar.Nombre;
                TextBoxApellido.Text = pacienteModificar.Apellido;
                TextBoxDireccion.Text = pacienteModificar.Direccion;
                TextBoxDni.Text = pacienteModificar.DNI;
                TextBoxMail.Text = pacienteModificar.Mail;
                TextBoxTelefono.Text = pacienteModificar.Telefono;
                txtDate.Text = pacienteModificar.FechaNacimiento.ToString("yyyy-MM-dd");
                DdlObraSocial.SelectedValue = pacienteModificar.ObraSocial.ID.ToString();

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
            catch (Exception ex )
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            PacienteNegocio negocio = new PacienteNegocio();

            Paciente aux = new Paciente();

            try
            {
                aux.ID = int.Parse(Request.QueryString["id"]);
                aux.Nombre = TextBoxNombre.Text;
                aux.Apellido = TextBoxApellido.Text;
                aux.Direccion = TextBoxDireccion.Text;
                aux.DNI = TextBoxDni.Text;
                aux.Mail = TextBoxMail.Text;
                aux.Telefono = TextBoxTelefono.Text;
                aux.FechaNacimiento = DateTime.Parse(txtDate.Text);
                aux.ObraSocial = new ObraSocial(int.Parse(DdlObraSocial.SelectedValue));



                negocio.Modificar(aux);
                string script = "confirmarAccion( 2 , 'RegistrosPaciente.aspx')";
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

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

         int id;
        protected void Page_Load(object sender, EventArgs e)
        {
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
                from_date.Text = pacienteModificar.FechaNacimiento.ToString("yyyy-MM-dd");
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
            catch (Exception)
            {

                throw;
            }

        }

        protected void BtnModificar_Click(object sender, EventArgs e)
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
                aux.FechaNacimiento = DateTime.Parse(from_date.Text);
                aux.ObraSocial = new ObraSocial(int.Parse(DdlObraSocial.SelectedValue));

                
              
                negocio.Modificar(aux);
                Response.Redirect("RegistrosPaciente.aspx");

            }
            catch (Exception)
            {

                throw;
            }

           


        }
    }
}
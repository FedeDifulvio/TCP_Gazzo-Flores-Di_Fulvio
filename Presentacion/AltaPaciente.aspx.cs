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
    public partial class AltaPaciente : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDdl();

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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {  
            
            
            PacienteNegocio negocio = new PacienteNegocio();
            Paciente aux = new Paciente();

            aux.Nombre = TextBoxNombre.Text;
            aux.Apellido = TextBoxApellido.Text;
            aux.DNI = TextBoxDni.Text;
            aux.Direccion = TextBoxDireccion.Text;
            aux.Mail = TextBoxMail.Text;
            aux.Telefono = TextBoxTelefono.Text;
            aux.FechaNacimiento = DateTime.Parse(txtDate.Text);
            aux.ObraSocial = new ObraSocial(int.Parse(DdlObraSocial.SelectedValue));
            negocio.Agregar(aux);
            Response.Redirect("RegistrosPaciente.aspx");
            
        }
    }
}


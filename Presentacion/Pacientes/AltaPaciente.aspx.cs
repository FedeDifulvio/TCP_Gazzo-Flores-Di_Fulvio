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
            lblDNI.Style["Visibility"] = "hidden";
            btnOK.Style["Visibility"] = "hidden";

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

            List<Paciente> DNIEnSesion = new List<Paciente>();
            PacienteNegocio negocio = new PacienteNegocio();
            Paciente aux = new Paciente();
            try
            {
                aux.Nombre = TextBoxNombre.Text;
                aux.Apellido = TextBoxApellido.Text;
                aux.DNI = TextBoxDni.Text;
                aux.Direccion = TextBoxDireccion.Text;
                aux.Mail = TextBoxMail.Text;
                aux.Telefono = TextBoxTelefono.Text;
                aux.FechaNacimiento = DateTime.Parse(txtDate.Text);
                aux.ObraSocial = new ObraSocial(int.Parse(DdlObraSocial.SelectedValue));

                DNIEnSesion = (List<Paciente>)Session["ListaPacientes"];

                if (DNIEnSesion.Find(x => x.DNI == aux.DNI) == null)
                { 
                     
                    negocio.Agregar(aux);
                    string script = "confirmarAccion( 1 , 'RegistrosPaciente.aspx')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeOk", script, true); 
                    
                }
                else
                {
                    lblDNI.Style["Visibility"] = "visible";
                    btnOK.Style["Visibility"] = "visible";
                    return; 
                }


            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
            
            
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            lblDNI.Style["Visibility"] = "hidden";
            btnOK.Style["Visibility"] = "hidden";
            TextBoxDni.Text = ""; 
        }
    }
}


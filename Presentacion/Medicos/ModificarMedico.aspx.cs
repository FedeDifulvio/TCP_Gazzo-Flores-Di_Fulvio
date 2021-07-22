using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;


namespace Presentacion.Medicos
{
    public partial class ModificarMedico : System.Web.UI.Page
    {
        int id;
        Medico MedicoModificar = new Medico();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLegajo.Style["Visibility"] = "hidden";
            btnOkLegajo.Style["Visibility"] = "hidden";

            if (!IsPostBack)
            {


                List<Medico> Lista = (List<Medico>)Session["ListaMedicos"];


                id = int.Parse(Request.QueryString["id"]);

                MedicoModificar = Lista.Find(x => x.ID == id);

                TextBoxNombre.Text = MedicoModificar.Nombre;
                TextBoxApellido.Text = MedicoModificar.Apellido;
                TextBoxLegajo.Text = MedicoModificar.Legajo;
           

            }

        }

        

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            MedicoNegocio negocio = new MedicoNegocio();
            Medico aux = new Medico();
            List<Medico> lista = new List<Medico>();            
            aux.Nombre = TextBoxNombre.Text;
            aux.Apellido = TextBoxApellido.Text;
            aux.ID =  int.Parse(Request.QueryString["id"]) ; 
            

            try
            {
                negocio.Modificar(aux);
                lista = negocio.Listar();
                Session.Add("ListaMedicos", lista);
                string script = "confirmarAccion( 2 , 'RegistroMedicos.aspx')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeOk", script, true);
            }
            catch (Exception ex )
            {
                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");

            }
            


        }
    }
}
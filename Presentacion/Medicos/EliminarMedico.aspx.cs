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
    public partial class EliminarMedico : System.Web.UI.Page
    {
        int id;
        Medico MedicoEliminar = new Medico();

        public Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if (usuario.TipoUsuario.Id != 1)
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");
            }

            List<Medico> Lista = (List<Medico>)Session["ListaMedicos"];


                id = int.Parse(Request.QueryString["id"]);

                MedicoEliminar = Lista.Find(x => x.ID == id);

                TextBoxNombre.Text = MedicoEliminar.Nombre;
                TextBoxApellido.Text = MedicoEliminar.Apellido;
                TextBoxLegajo.Text = MedicoEliminar.Legajo;


            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
             MedicoNegocio negocio = new MedicoNegocio();

            try
            {

                negocio.Eliminar(int.Parse(Request.QueryString["id"]));

                string script = "confirmarAccion( 3 , 'RegistroMedicos.aspx')";
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
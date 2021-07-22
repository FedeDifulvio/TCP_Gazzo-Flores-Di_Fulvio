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
    public partial class ObrasSociales : System.Web.UI.Page
    {
        public List<ObraSocial> ListaObrasSociales;
        public Usuario usuario = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if (usuario.TipoUsuario.Id != 1)
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");
            }


            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    cargarObrasSociales();

                }

                else if (Request.QueryString["action"].ToString() == "elim")
                {
                    bajaObraSocial();
                }

                else if (Request.QueryString["action"].ToString() == "mod")
                {
                    modificacionObraSocial();
                }

            }
            else
            {
                ListaObrasSociales = (List<ObraSocial>)Session["ListaObrasSociales"];
            }




        }
        public void cargarObrasSociales()
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();

            BtnModificar.Style["Visibility"] = "hidden";
            cancelarMod.Style["Visibility"] = "hidden";
            LabelTitulo.Text = "Alta Obra Social";  

            try
            {

                Session.Add("ListaObrasSociales", negocio.listar());
                ListaObrasSociales = (List<ObraSocial>)Session["ListaObrasSociales"];
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        } 

        public void bajaObraSocial()
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();
            int id = int.Parse(Request.QueryString["id"]);
            try
            {
                negocio.eliminarObraSocial(id);
                
            }
            catch (Exception ex)
            {
                
                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
            Response.Redirect("../ObrasSociales/ObrasSociales.aspx");
        }

        public void modificacionObraSocial()
        {           

            int id = int.Parse(Request.QueryString["id"]);
            BtnAgregar.Style["Visibility"] = "hidden";
            BtnModificar.Style["Visibility"] = "visible";
            cancelarMod.Style["Visibility"] = "visible";
            LabelTitulo.Text = "Modificar Obra Social"; 
            ListaObrasSociales = (List<ObraSocial>)Session["ListaObrasSociales"];
            ObraSocial aModificar = ListaObrasSociales.Find(x => x.ID == id);
            TextBoxNombre.Text = aModificar.Nombre;
            Session.Add("idModificar", id);
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();
            ObraSocial aux = new ObraSocial();

            try
            {
                aux.Nombre=TextBoxNombre.Text;
                negocio.Agregar(aux);
                lblExito.Visible = true;
                lblExito.Text = "Dado de alta correctamente";
                string script = "Redireccionar('../ObrasSociales/ObrasSociales.aspx')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ok", script, true);

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }

        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();
            ObraSocial aux = new ObraSocial((int)Session["idModificar"], TextBoxNombre.Text); 
          
            try
            {
                negocio.modificar(aux);
                lblExito.Visible = true;
                lblExito.Text = "Modificado correctamente";
                string script = "Redireccionar('../ObrasSociales/ObrasSociales.aspx')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ok", script, true);


            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }

        protected void cancelarMod_Click(object sender, EventArgs e)
        {
            Response.Redirect("ObrasSociales.aspx");
        }
    }
}
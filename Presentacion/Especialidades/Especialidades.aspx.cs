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
    public partial class Especialidades : System.Web.UI.Page
    {
        public List<Especialidad> ListaEspecialidades;
        public Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

            usuario = (Usuario)Session["Usuario"];
            if (usuario.TipoUsuario.Id != 3)
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");
            }

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    cargarEspecialidades();

                }

                else if (Request.QueryString["action"].ToString() == "elim")
                {
                   bajaEspecialidad();
                }

                else if (Request.QueryString["action"].ToString() == "mod")
                {
                    modificarEspecialidad();
                } 

            }
            else
            {
               ListaEspecialidades = (List<Especialidad>)Session["ListaEspecialidades"];
            }
        }

        public void cargarEspecialidades()
        {
            EspecialidadesNegocio negocio = new EspecialidadesNegocio();
            try
            {
                labelTitulo.Text = "Alta Especialidad"; 
                BtnModificar.Style["Visibility"] = "hidden";
                BtnCancelar.Style["Visibility"] = "hidden";
                ListaEspecialidades = negocio.Listar();
               
                Session.Add("ListaEspecialidades", ListaEspecialidades);

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        } 


        public void bajaEspecialidad()
        {
            EspecialidadesNegocio negocio = new EspecialidadesNegocio();
            int id = int.Parse(Request.QueryString["id"]);
            try
            {
                negocio.eliminarEspecialidad(id);
                
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
            Response.Redirect("../Especialidades/Especialidades.aspx");
        } 

        public void modificarEspecialidad()
        {
            int id = int.Parse(Request.QueryString["id"]);
            BtnAgregar.Style["Visibility"] = "hidden";
            BtnModificar.Style["Visibility"] = "visible";
            BtnCancelar.Style["Visibility"] = "visible";
            labelTitulo.Text = "Modificar Especialidad";
            ListaEspecialidades = (List<Especialidad>)Session["ListaEspecialidades"];
            Especialidad aModificar = ListaEspecialidades.Find(x => x.ID == id);
            TextBoxNombre.Text = aModificar.Nombre;
            Session.Add("idModificar", id); 
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            EspecialidadesNegocio negocio = new EspecialidadesNegocio();
            Especialidad aux = new Especialidad();

            try
            {
                aux.Nombre = TextBoxNombre.Text;
      
                negocio.Agregar(aux);

                lblExito.Text = "Agregado correctamente";
                lblExito.Visible = true;
                string script = "Redireccionar('../Especialidades/Especialidades.aspx')";
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
            EspecialidadesNegocio negocio = new EspecialidadesNegocio();
            Especialidad aux = new Especialidad((int)Session["idModificar"], TextBoxNombre.Text);

            try
            {
                negocio.modificar(aux);
                lblExito.Visible = true;
                lblExito.Text = "Modificado correctamente"; 
                string script = "Redireccionar('../Especialidades/Especialidades.aspx')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ok", script, true);

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Especialidades/Especialidades.aspx"); 
        }
    }
}
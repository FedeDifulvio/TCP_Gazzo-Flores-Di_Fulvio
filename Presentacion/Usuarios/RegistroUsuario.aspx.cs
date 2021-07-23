using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion.Usuarios
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {



        public List<Usuario> Lista;
        public Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if (usuario.TipoUsuario.Id != 1)
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");
            }

            if (Request.QueryString["id"] != null)
            {
                bajaUsuario();
            }
            else
            {
                cargarUsuarios();
            }
            
        }

        public void cargarUsuarios()
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {

                Lista = negocio.Listar();
               


                Session.Add("ListaUsuarios", Lista);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }


        public void bajaUsuario()
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            int id = int.Parse(Request.QueryString["id"]);
            try
            {
                negocio.EliminarUsuario(id);

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
            Response.Redirect("../Usuarios/RegistroUsuario.aspx");
        }



    }
}
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
    public partial class Login : System.Web.UI.Page
    {
        public Usuario usuario = new Usuario();
        public UsuarioNegocio negocio = new UsuarioNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           usuario.User = txtUserName.Text;
           usuario.Pass= txtPassword.Text;

            if (negocio.Loguear(usuario))
            {
                Session.Add("Usuario", usuario);
                Response.Redirect("../Info/Home.aspx");

            }
            else
            {
                Session.Add("error", "Usuario Incorrecto, intente nuevamente");
                Response.Redirect("../Info/PagError.aspx");
            }

            
        }
   
    }
}
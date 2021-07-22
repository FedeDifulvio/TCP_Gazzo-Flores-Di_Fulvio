using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Presentacion
{
    public partial class Home : System.Web.UI.Page
    {
        public Usuario usuario = new Usuario();
        public string nombre;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if (usuario == null)
            {
                Response.Redirect("../Login/Login.aspx");
            }
            nombre = usuario.User;
        }
  
    }
}
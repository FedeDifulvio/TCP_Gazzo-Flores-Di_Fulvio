using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion.Turnos
{
    public partial class RegistroTurnos : System.Web.UI.Page
    {
        public List<Turno> lista;
        public TurnoNegocio negocio = new TurnoNegocio();

        public Usuario usuario = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {

            usuario = (Usuario)Session["Usuario"];
            if (usuario.TipoUsuario.Id != 1 && usuario.TipoUsuario.Id != 2)
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");
            }

            try
            {
                lista = negocio.Listar();
                Session.Add("ListaTurnos", lista);

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../PagError.aspx");
            }
           
        }
    }
}
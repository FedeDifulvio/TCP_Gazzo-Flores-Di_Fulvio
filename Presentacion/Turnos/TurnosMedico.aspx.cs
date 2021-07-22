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
    public partial class TurnosMedico : System.Web.UI.Page
    {

        public string legajoMedico;
        public TurnoNegocio turnoNegocio = new TurnoNegocio();
        public List<Turno> lista = new List<Turno>();
        public Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {



            
            usuario = (Usuario)Session["Usuario"];

            if (usuario.TipoUsuario.Id != 3 )
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");

            }


              legajoMedico = usuario.Token;

            try
            {
                
                lista = turnoNegocio.Listar().FindAll(x => x.Medico.Legajo == legajoMedico && x.Estado != "Cancelado" && x.Fecha >= DateTime.Today);

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../PagError.aspx");
            }

        }
    }
}
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
       
        public string legajoMedico = "D1111";
        public TurnoNegocio turnoNegocio = new TurnoNegocio();
        public List<Turno> lista = new List<Turno>();
        protected void Page_Load(object sender, EventArgs e)
        {
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
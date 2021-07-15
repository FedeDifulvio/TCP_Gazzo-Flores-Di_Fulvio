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
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lista = negocio.Listar();
                Session.Add("ListaTurnos", lista);

            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
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
    public partial class AltaPaciente : System.Web.UI.Page
    {
        public List<Paciente> Lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            PacienteNegocio negocio = new PacienteNegocio();

            try
            {
                Lista= negocio.Listar();
                GridView1.DataSource = Lista;
                GridView1.DataBind();
             
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
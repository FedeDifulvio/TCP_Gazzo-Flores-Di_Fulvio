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
    public partial class RegistroMedicos : System.Web.UI.Page
    {
        public List<Medico> Lista;
        public List<Medico> listaNoFiltrada;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarMedicos();
        }
        public void cargarMedicos()
        {
            MedicoNegocio negocio = new MedicoNegocio();
            try
            {

                listaNoFiltrada = negocio.Listar();
                Lista = listaNoFiltrada.FindAll(x => x.Estado == true);

               
                Session.Add("ListaMedicos", Lista); 

            }
            catch (Exception ex )
            {
                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../PagError.aspx");
            }
        }

    }
}
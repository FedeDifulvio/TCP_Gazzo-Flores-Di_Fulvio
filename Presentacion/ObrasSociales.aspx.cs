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
    public partial class ObrasSociales : System.Web.UI.Page
    {
        public List<ObraSocial> ListaObrasSociales;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarObrasSociales();
        }
        public void cargarObrasSociales()
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();
            try
            {

                ListaObrasSociales = negocio.listar();

                Session.Add("ListaEspecialidades", ListaObrasSociales);

            }
            catch (Exception)
            {

                throw;
            }
        }
        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();
            ObraSocial aux = new ObraSocial();

            try
            {
                aux.Nombre=TextBoxNombre.Text;
                negocio.Agregar(aux);
                Response.Redirect("ObrasSociales.aspx");

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
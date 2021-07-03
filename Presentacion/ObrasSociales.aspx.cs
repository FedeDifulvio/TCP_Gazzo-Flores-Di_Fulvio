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
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    cargarObrasSociales();

                }

                else if (Request.QueryString["action"].ToString() == "elim")
                {
                    bajaObraSocial();
                }

                else if (Request.QueryString["action"].ToString() == "mod")
                {
                    modificacionObraSocial();
                }

            }
            else
            {
                ListaObrasSociales = (List<ObraSocial>)Session["ListaObrasSociales"];
            }




        }
        public void cargarObrasSociales()
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();

            BtnModificar.Style["Visibility"] = "hidden";

            try
            {

                Session.Add("ListaObrasSociales", negocio.listar());
                ListaObrasSociales = (List<ObraSocial>)Session["ListaObrasSociales"];
            }
            catch (Exception)
            {

                throw;
            }
        } 

        public void bajaObraSocial()
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();
            int id = int.Parse(Request.QueryString["id"]);
            try
            {
                negocio.eliminarObraSocial(id);
                Response.Redirect("ObrasSociales.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificacionObraSocial()
        {
            int id = int.Parse(Request.QueryString["id"]);
            BtnAgregar.Style["Visibility"] = "hidden";
            BtnModificar.Style["Visibility"] = "visible";
            ListaObrasSociales = (List<ObraSocial>)Session["ListaObrasSociales"];
            ObraSocial aModificar = ListaObrasSociales.Find(x => x.ID == id);
            TextBoxNombre.Text = aModificar.Nombre;
            Session.Add("idModificar", id);
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

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            ObraSocialNegocio negocio = new ObraSocialNegocio();
            ObraSocial aux = new ObraSocial((int)Session["idModificar"], TextBoxNombre.Text); 
          
            try
            {
                negocio.modificar(aux); 
                Response.Redirect("ObrasSociales.aspx");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
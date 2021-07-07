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
    public partial class AltaMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLegajo.Style["Visibility"] = "hidden";
            btnOkLegajo.Style["Visibility"] = "hidden";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            MedicoNegocio negocio = new MedicoNegocio();
            Medico aux = new Medico();
            List<Medico> lista = new List<Medico>();
            List<Medico> LegajosEnSesion = new List<Medico>();
            aux.Nombre = TextBoxNombre.Text;
            aux.Apellido = TextBoxApellido.Text;
            aux.Legajo = TextBoxLegajo.Text;
            LegajosEnSesion = (List<Medico>)Session["ListaMedicos"];

            if (LegajosEnSesion.Find(x => x.Legajo == aux.Legajo)==null) {
                negocio.Agregar(aux);
                lista = negocio.Listar();
                Session.Add("ListaMedicos", lista);
                int id = lista.Find(x => x.Legajo == aux.Legajo).ID;
                Response.Redirect("DetalleMedico.aspx?idMedico=" + id);
            }
            else 
            {
                lblLegajo.Style["Visibility"] = "visible";
                btnOkLegajo.Style["Visibility"] = "visible";
                return;
            }
        }

        protected void btnOkLegajo_Click(object sender, EventArgs e)
        {
            lblLegajo.Style["Visibility"] = "hidden";
            TextBoxLegajo.Text = "";
        }
    }
}
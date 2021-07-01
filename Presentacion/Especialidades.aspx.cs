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
    public partial class Especialidades : System.Web.UI.Page
    {
        public List<Especialidad> ListaEspecialidades;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarEspecialidades();
        }

        public void cargarEspecialidades()
        {
            EspecialidadesNegocio negocio = new EspecialidadesNegocio();
            try
            {

                ListaEspecialidades = negocio.Listar();
               
                Session.Add("ListaEspecialidades", ListaEspecialidades);

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            EspecialidadesNegocio negocio = new EspecialidadesNegocio();
            Especialidad aux = new Especialidad();

            aux.Nombre=TextBoxNombre.Text;
            negocio.Agregar(aux);
            Response.Redirect("Especialidades.aspx");
        }
    }
}
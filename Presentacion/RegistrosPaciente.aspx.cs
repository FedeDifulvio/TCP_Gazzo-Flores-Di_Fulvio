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
    public partial class RegistrosPaciente : System.Web.UI.Page
    {
        public List<Paciente> Lista;
        protected void Page_Load(object sender, EventArgs e)
        {
           cargarPacientes();
        }

        public void cargarPacientes()
        {
            PacienteNegocio negocio = new PacienteNegocio();
            try
            {
                Lista = negocio.Listar();
                Session.Add("ListaPacientes", Lista);
                
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
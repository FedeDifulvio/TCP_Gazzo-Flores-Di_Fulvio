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
        public List<Paciente> listaNoFiltrada;

        public Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if (usuario.TipoUsuario.Id != 1 && usuario.TipoUsuario.Id != 2)
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");
            }


            cargarPacientes();
        }

        public void cargarPacientes()
        {
            PacienteNegocio negocio = new PacienteNegocio();
            try
            {
                
                listaNoFiltrada = negocio.Listar();
                Lista = listaNoFiltrada.FindAll(x => x.Estado == true);
                Session.Add("ListaPacientes", Lista);
                
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }


    }
}
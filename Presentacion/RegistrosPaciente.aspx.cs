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
                GridPacientes.DataSource = Lista;
                GridPacientes.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GridPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridPacientes.PageIndex = e.NewPageIndex;
            cargarPacientes();
        }

        protected void GridPacientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Visible = false;
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Visible = false;
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = Buscador.Text;
            List<Paciente> listaFiltrada = Lista.FindAll(x => chequearFiltros(x,filtro));
            GridPacientes.DataSource = listaFiltrada;
            GridPacientes.DataBind();
        }

        public bool chequearFiltros( Paciente paciente, string filtro) {

            if (paciente.Nombre.ToLower().Contains(filtro.ToLower()))
            {
                return true;
            }
            if (paciente.Apellido.ToLower().Contains(filtro.ToLower()))
            {
                return true;
            }
            if (paciente.DNI.ToLower().Contains(filtro.ToLower()))
            {
                return true;
            }
           
            return false;

        }

     

   

       
    }
}
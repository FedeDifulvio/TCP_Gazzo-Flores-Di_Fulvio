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
    public partial class DetalleMedico : System.Web.UI.Page
    {
        public List<Especialidad> Especialidades = new List<Especialidad>();
        public List<ObraSocialDeMedico> ObraSocial = new List<ObraSocialDeMedico>();
        public List<DiaHorarioTrabajo> DiaHorario = new List<DiaHorarioTrabajo>();
        public MedicoNegocio Negocio = new MedicoNegocio();
        public int IdMedico; 
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
                if (Request.QueryString["table"] == "obra")
                {

                    Negocio.ElimObraSocialMedico(int.Parse(Request.QueryString["idObra"]));

                }

                ocultarDll();

                cargarDetalle();
               
            
        }

        protected void btnAgregarObra_Click(object sender, EventArgs e)
        {
            
            ddlObraSocial.Style["Visibility"] = "visible";
            btnAltaObra.Style["Visibility"] = "visible";
            btnCancelarObra.Style["Visibility"] = "visible";
            btnVerMas.Style["Visibility"] = "hidden";
            CargarDdl();

        }

        protected void btnCancelarObra_Click(object sender, EventArgs e)
        {
            ocultarDll(); 
           
        }

        protected void btnAltaObra_Click(object sender, EventArgs e)
        {

            try
            {
             
                  Negocio.AgregarObraSocialMedico(int.Parse(ddlObraSocial.SelectedValue), IdMedico);
                  ObraSocial = Negocio.ListarObrasSocialesMedico(IdMedico);
                  ocultarDll(); 
                 IdMedico = int.Parse(Request.QueryString["idMedico"]);
                Response.Redirect("DetalleMedico.aspx?idMedico=" + IdMedico);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void CargarDdl()
        {
            try
            {
                ObraSocialNegocio negocio = new ObraSocialNegocio();

                ddlObraSocial.DataSource = negocio.listar();
                ddlObraSocial.DataValueField = "ID";
                ddlObraSocial.DataTextField = "Nombre";

                ddlObraSocial.DataBind();

            }
            catch (Exception)
            {

                throw;
            }

        } 

        public void ocultarDll()
        {
            ddlObraSocial.Style["Visibility"] = "hidden";
            btnAltaObra.Style["Visibility"] = "hidden";
            btnCancelarObra.Style["Visibility"] = "hidden";
            btnVerMas.Style["Visibility"] = "visible";
        }

        public void cargarDetalle()
        {
            try
            {
                List<Medico> Lista = (List<Medico>)Session["ListaMedicos"];

                IdMedico = int.Parse(Request.QueryString["idMedico"]);

                Medico MedicoDetalle = Lista.Find(x => x.ID == IdMedico);

                TextBoxNombre.Text = MedicoDetalle.Nombre;
                TextBoxApellido.Text = MedicoDetalle.Apellido;
                TextBoxLegajo.Text = MedicoDetalle.Legajo;

                Especialidades = Negocio.ListarEspecialidadesMedico(IdMedico);
                ObraSocial = Negocio.ListarObrasSocialesMedico(IdMedico);
                DiaHorario = Negocio.ListarDiasHorariosMedicos(IdMedico);
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
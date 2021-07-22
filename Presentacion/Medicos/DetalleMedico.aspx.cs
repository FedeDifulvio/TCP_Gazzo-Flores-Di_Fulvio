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
        public List<EspecialidadDeMedico> Especialidades = new List<EspecialidadDeMedico>();
        public List<ObraSocialDeMedico> ObraSocial = new List<ObraSocialDeMedico>();
        public List<DiaHorarioTrabajo> DiaHorario = new List<DiaHorarioTrabajo>();
        public MedicoNegocio Negocio = new MedicoNegocio();
        public int IdMedico; 
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["table"] == "obra")
                {

                    Negocio.ElimObraSocialMedico(int.Parse(Request.QueryString["idObra"]));

                }

                if (Request.QueryString["table"] == "esp")
                {

                    Negocio.ElimEspecialidadMedico(int.Parse(Request.QueryString["idEspe"]));

                }

                if (Request.QueryString["table"] == "dia")
                {

                    Negocio.ElimDiaMedico(int.Parse(Request.QueryString["idDia"]));

                }

                ocultarDllObra();
                ocultarDllEspecialidad();
                ocultarDllDia();

                cargarDetalle();

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            } 
            
        }

        protected void btnAgregarObra_Click(object sender, EventArgs e)
        {
            
            ddlObraSocial.Style["Visibility"] = "visible";
            btnAltaObra.Style["Visibility"] = "visible";
            btnCancelarObra.Style["Visibility"] = "visible";
            btnVerMas.Style["Visibility"] = "hidden";
            CargarDdlObra();

        }

        protected void btnCancelarObra_Click(object sender, EventArgs e)
        {
            ocultarDllObra(); 
           
        }

        protected void btnAltaObra_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(ddlObraSocial.SelectedValue);

                if (ObraSocial.Find(x => x.obraSocial.ID == id) == null)
                {
                    Negocio.AgregarObraSocialMedico(id, IdMedico);
                    ObraSocial = Negocio.ListarObrasSocialesMedico(IdMedico);
                    ocultarDllObra();
                    IdMedico = int.Parse(Request.QueryString["idMedico"]);
                    Response.Redirect("DetalleMedico.aspx?idMedico=" + IdMedico);
                }
                else
                {
                    ddlObraSocial.Style["Visibility"] = "hidden";
                    btnAltaObra.Style["Visibility"] = "hidden";
                    btnCancelarObra.Style["Visibility"] = "hidden";
                    ObraError.Style["Visibility"] = "visible";



                }
            }
            catch (Exception ex )
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }

        }

        public void CargarDdlObra()
        {
            try
            {
                ObraSocialNegocio negocio = new ObraSocialNegocio();

                ddlObraSocial.DataSource = negocio.listar(); 
                ddlObraSocial.DataValueField = "ID";
                ddlObraSocial.DataTextField = "Nombre";

                ddlObraSocial.DataBind();

            }
            catch (Exception ex )
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }

        }  

        

        public void ocultarDllObra() 
        {   
            ObraError.Style["Visibility"] = "hidden";
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
            catch (Exception ex )
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }

        public void ocultarDllEspecialidad()
        {
            errorEspe.Style["Visibility"] = "hidden";
            ddlEspecialidades.Style["Visibility"] = "hidden";
            btnAltaEspecialidad.Style["Visibility"] = "hidden";
            btnCancelarEspe.Style["Visibility"] = "hidden";
            btnVerMasEspe.Style["Visibility"] = "visible";
        } 

        public void cargarDllEspecialidades()
        {
            try
            {
               EspecialidadesNegocio negocio = new EspecialidadesNegocio();

                ddlEspecialidades.DataSource = negocio.Listar();
                ddlEspecialidades.DataValueField = "ID";
                ddlEspecialidades.DataTextField = "Nombre";

                ddlEspecialidades.DataBind();

            }
            catch (Exception ex )
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }

        protected void btnVerMasEspe_Click(object sender, EventArgs e)
        {
            ddlEspecialidades.Style["Visibility"] = "visible";
            btnAltaEspecialidad.Style["Visibility"] = "visible";
            btnCancelarEspe.Style["Visibility"] = "visible";
            btnVerMasEspe.Style["Visibility"] = "hidden";
            cargarDllEspecialidades();
        }

        protected void btnAltaEspecialidad_Click(object sender, EventArgs e)
        { 
            
            try
            {
                int id = int.Parse(ddlEspecialidades.SelectedValue);

                if (Especialidades.Find(x => x.especialidad.ID== id) == null)
                {
                    Negocio.AgregarEspecialidadMedico(id, IdMedico);
                    Especialidades = Negocio.ListarEspecialidadesMedico(IdMedico);
                    ocultarDllEspecialidad(); 
                    IdMedico = int.Parse(Request.QueryString["idMedico"]);
                    Response.Redirect("DetalleMedico.aspx?idMedico=" + IdMedico);
                }
                else
                {
                    ddlEspecialidades.Style["Visibility"] = "hidden";
                    btnAltaEspecialidad.Style["Visibility"] = "hidden";
                   btnCancelarEspe.Style["Visibility"] = "hidden";
                    errorEspe.Style["Visibility"] = "visible";



                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            } 

            
        } 

         public void ocultarDllDia()
        {
            ErrorDia.Style["Visibility"] = "hidden";
            ddlDias.Style["Visibility"] = "hidden";
            ddlHoraInicio.Style["Visibility"] = "hidden";
            ddlHoraFin.Style["Visibility"] = "hidden";
           btnAgregarDia.Style["Visibility"] = "hidden";
            btnCancelarDia.Style["Visibility"] = "hidden";
            verMasDia.Style["Visibility"] = "visible";

        }

        protected void verMasDia_Click(object sender, EventArgs e)
        {
            
            ddlDias.Style["Visibility"] = "visible";
            ddlHoraInicio.Style["Visibility"] = "visible";
            ddlHoraFin.Style["Visibility"] = "visible";
            btnAgregarDia.Style["Visibility"] = "visible";
            btnCancelarDia.Style["Visibility"] = "visible";
            verMasDia.Style["Visibility"] = "hidden";

            cargarDdlDias();
        }

        protected void btnCancelarDia_Click(object sender, EventArgs e)
        {
            ocultarDllDia();
        } 

        public void cargarDdlDias()
        {
            ddlDias.Items.Clear(); 

            ddlDias.Items.Add(new ListItem("Lunes", "1"));
            ddlDias.Items.Add(new ListItem("Martes", "2"));
            ddlDias.Items.Add(new ListItem("Miercoles", "3"));
            ddlDias.Items.Add(new ListItem("Jueves", "4"));
            ddlDias.Items.Add(new ListItem("Viernes", "5"));
            ddlDias.Items.Add(new ListItem("Sabado", "6"));

            ddlHoraInicio.Items.Clear(); 

            ddlHoraInicio.Items.Add(new ListItem("9", "1"));
            ddlHoraInicio.Items.Add(new ListItem("10", "2"));
            ddlHoraInicio.Items.Add(new ListItem("11", "3"));
            ddlHoraInicio.Items.Add(new ListItem("12", "4"));
            ddlHoraInicio.Items.Add(new ListItem("13" ,"5")); 
            ddlHoraInicio.Items.Add(new ListItem("14", "6")); 
            ddlHoraInicio.Items.Add(new ListItem("15", "7"));
            ddlHoraInicio.Items.Add(new ListItem("16", "8"));
            ddlHoraInicio.Items.Add(new ListItem("17", "9"));
            ddlHoraInicio.Items.Add(new ListItem("18", "10"));

            ddlHoraFin.Items.Clear(); 

            ddlHoraFin.Items.Add(new ListItem("9", "1"));
            ddlHoraFin.Items.Add(new ListItem("10", "2"));
            ddlHoraFin.Items.Add(new ListItem("11", "3"));
            ddlHoraFin.Items.Add(new ListItem("12", "4"));
            ddlHoraFin.Items.Add(new ListItem("13", "5"));
            ddlHoraFin.Items.Add(new ListItem("14", "6"));
            ddlHoraFin.Items.Add(new ListItem("15", "7"));
            ddlHoraFin.Items.Add(new ListItem("16", "8"));
            ddlHoraFin.Items.Add(new ListItem("17", "9"));
            ddlHoraFin.Items.Add(new ListItem("18", "10"));



        }

        protected void btnAgregarDia_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(ddlDias.SelectedValue);

                if (DiaHorario.Find(x => x.idDia == id) == null)
                {
                    Negocio.AgregarDiaMedico(id, IdMedico, ddlHoraInicio.SelectedItem.ToString(), ddlHoraFin.SelectedItem.ToString());
                    DiaHorario = Negocio.ListarDiasHorariosMedicos(IdMedico);
                    ocultarDllDia(); 
                    IdMedico = int.Parse(Request.QueryString["idMedico"]);
                    Response.Redirect("DetalleMedico.aspx?idMedico=" + IdMedico);
                }
                else
                {
                    ErrorDia.Style["Visibility"] = "visible";
                    ddlDias.Style["Visibility"] = "hidden";
                    ddlHoraInicio.Style["Visibility"] = "hidden";
                    ddlHoraFin.Style["Visibility"] = "hidden";
                    btnAgregarDia.Style["Visibility"] = "hidden";
                    btnCancelarDia.Style["Visibility"] = "hidden";



                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }
    }
}
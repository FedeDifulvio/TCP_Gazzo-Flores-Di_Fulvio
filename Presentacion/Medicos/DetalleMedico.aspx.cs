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
        public List<ObraSocial> ObraSocial = new List<ObraSocial>();
        public List<DiaHorarioTrabajo> DiaHorario = new List<DiaHorarioTrabajo>(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            MedicoNegocio Negocio = new MedicoNegocio();
            List<Medico> Lista = (List<Medico>)Session["ListaMedicos"];

            int ID = int.Parse(Request.QueryString["id"]);

            Medico MedicoDetalle = Lista.Find(x => x.ID == ID);

            TextBoxNombre.Text =   MedicoDetalle.Nombre;
            TextBoxApellido.Text = MedicoDetalle.Apellido;
            TextBoxLegajo.Text =   MedicoDetalle.Legajo;

            Especialidades = Negocio.ListarEspecialidadesMedico(ID);
            ObraSocial = Negocio.ListarObrasSocialesMedico(ID);
            DiaHorario = Negocio.ListarDiasHorariosMedicos(ID);
        }
    }
}
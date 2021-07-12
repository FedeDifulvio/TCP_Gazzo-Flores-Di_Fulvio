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
    public partial class NuevoTurno : System.Web.UI.Page
    {
        Paciente Paciente = new Paciente();
        PacienteNegocio PacienteNegocio = new PacienteNegocio();
        EspecialidadesNegocio EspecialidadesDDL = new EspecialidadesNegocio();
        MedicoNegocio MedicoNegocio = new MedicoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DniBtn_Click(object sender, EventArgs e)
        {
            string Dni = DniTxt.Text;

            Paciente = PacienteNegocio.Listar().Find(x => x.DNI == Dni);

            if (Paciente== null)
            {
                DniLBL.Visible = true;
                return;
            }

            NombreTxt.Text = Paciente.Nombre;
            ApellidoTxt.Text = Paciente.Apellido;
            dniTextBox.Text = Paciente.DNI;
            ObraSocialTxt.Text = Paciente.ObraSocial.Nombre;
           
            NombreTxt.Visible = true;
            ApellidoTxt.Visible = true;
            dniTextBox.Visible = true;
            ObraSocialTxt.Visible = true;

            NombreLbl.Visible = true;
            ApellidoLbl.Visible = true;
            DniLabel.Visible = true;
            ObraSocialLbl.Visible = true;

            Especialidades.Visible = true;
            DdlEspecialidades.Visible = true;

            LblMedico.Visible = true;
            DdlMedicos.Visible = true;


            DdlEspecialidades.DataSource = EspecialidadesDDL.Listar();
            DdlEspecialidades.DataValueField = "ID";
            DdlEspecialidades.DataTextField = "Nombre";
            DdlEspecialidades.DataBind();

            
        


        }

        protected void DdlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = int.Parse(DdlEspecialidades.SelectedItem.Value);
            DdlMedicos.DataSource = MedicoNegocio.Listar().FindAll(x => x.ID == id);
            DdlMedicos.DataValueField = "ID";
            DdlMedicos.DataTextField = "Apellido";
            DdlMedicos.DataBind();

        }
    }
}
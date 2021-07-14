﻿using System;
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
            if (!IsPostBack)
            {
                DdlEspecialidades.DataSource = EspecialidadesDDL.Listar();
                DdlEspecialidades.DataValueField = "ID";
                DdlEspecialidades.DataTextField = "Nombre";
                DdlEspecialidades.DataBind();
            }
          
        }

        protected void DniBtn_Click(object sender, EventArgs e)
        {

            string Dni = DniTxt.Text;

            Paciente = PacienteNegocio.Listar().Find(x => x.DNI == Dni);
            Session.Add("PacienteTurno", Paciente); 

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

            DdlEspecialidades.Items.Clear();
            DdlEspecialidades.Items.Insert(0 , "--Seleccione Dato--" );
            DdlEspecialidades.DataSource = EspecialidadesDDL.Listar();
            DdlEspecialidades.DataValueField = "ID";
            DdlEspecialidades.DataTextField = "Nombre";
            DdlEspecialidades.DataBind();
            
        }

            
          
        protected void DdlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idEspecialidad = int.Parse(DdlEspecialidades.SelectedItem.Value);
                DdlMedicos.Items.Clear();
                DdlMedicos.Items.Insert(0, "--Seleccione Médico--");
                DdlMedicos.DataSource = MedicoNegocio.Listar().FindAll(x => validadEspecialidad(x.ID, idEspecialidad));
                DdlMedicos.DataValueField = "ID";
                DdlMedicos.DataTextField = "Apellido";
                DdlMedicos.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
            

        }  



        public bool validadEspecialidad(int idMedico, int idEspecialidad )
        {
           
            List<ObraSocialDeMedico> ObrasDeMedico = MedicoNegocio.ListarObrasSocialesMedico(idMedico);
            Paciente paciente = (Paciente)Session["PacienteTurno"]; 
           if( ObrasDeMedico.Find(x=>x.obraSocial.ID == paciente.ObraSocial.ID)== null)
           {
                return false; 
           }

            List<EspecialidadDeMedico> EspecialidadesMedico = MedicoNegocio.ListarEspecialidadesMedico(idMedico);

            if (EspecialidadesMedico.Find(x => x.especialidad.ID == idEspecialidad) == null)
            {
                return false;
            }
            else
            {
                return true; 
            }

        }

        protected void DdlMedicos_TextChanged(object sender, EventArgs e)
        {
            Calendario.Visible = true;
            int idMedico =int.Parse(DdlMedicos.SelectedValue);
            List<DiaHorarioTrabajo> DiasMedico = MedicoNegocio.ListarDiasHorariosMedicos(idMedico); 

           /* foreach(var item in DiasMedico)
            {
                switch (item.idDia)
                {
                    case 1: 
                }
            }*/

        }

        protected void Calendario_DayRender(object sender, DayRenderEventArgs e)
        {
            int idMedico = int.Parse(DdlMedicos.SelectedValue);
            List<DiaHorarioTrabajo> DiasMedico = MedicoNegocio.ListarDiasHorariosMedicos(idMedico);

            if(e.Day.Date < DateTime.Today)
            {
                e.Day.IsSelectable = false; 
            }


            foreach (var item in DiasMedico)
             {
                 switch (item.idDia)
                 {
                    case 1:
                        if ( e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Monday )
                        {
                            e.Cell.BackColor = System.Drawing.Color.Yellow;
                        }
                        
                        break;
                    case 2:
                        if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Tuesday )
                        {
                            e.Cell.BackColor = System.Drawing.Color.Yellow;
                        }
                       
                        break;
                    case 3:
                        if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            e.Cell.BackColor = System.Drawing.Color.Yellow;
                        }
                      
                        break;
                    case 4:
                        if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Thursday )
                        {
                            e.Cell.BackColor = System.Drawing.Color.Yellow;
                        }

                        break;

                    case 5:
                        if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Friday)
                        {
                            e.Cell.BackColor = System.Drawing.Color.Yellow;
                        }

                        break;

                    case 6:
                        if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Saturday )
                        {
                            e.Cell.BackColor = System.Drawing.Color.Yellow;
                        }

                        break;


                }
             } 

            if(e.Cell.BackColor != System.Drawing.Color.Yellow)
            {
                e.Day.IsSelectable = false;
            }
    
        }

        protected void Calendario_SelectionChanged(object sender, EventArgs e)
        {
            List<string> HorariosDisponibles = new List<string>();


            lblFecha.Visible = true;
            lblFecha.Text = "Horarios disponibles para el día " + Calendario.SelectedDate.ToShortDateString(); 
            ddlHorarios.Visible = true;

            HorariosDisponibles = Horario_Disponibles(int.Parse(DdlMedicos.SelectedValue), Calendario.SelectedDate);

            int cont=0;
            ddlHorarios.Items.Clear();
            foreach (var item in HorariosDisponibles)
            {
                ddlHorarios.Items.Add(new ListItem(item,cont++.ToString()));
                
            } 


        }

        public List<string> Horario_Disponibles(int IdMedico, DateTime Fecha)
        {
            TurnoNegocio Negocio = new TurnoNegocio();
            List<Turno> ListaTurnos = new List<Turno>();
            DiaHorarioTrabajo HoraTrabajo = new DiaHorarioTrabajo();
            List<string> HorariosDisponibles = new List<string>();

            ///Lista turnos: Guardamos todos los turnos que tiene ese medico en ese Fecha
            ListaTurnos = Negocio.Listar().FindAll(x => x.Medico.ID == IdMedico && x.Fecha == Fecha); 
            /// HoraTrabajo: Cargamos el horario de inicio y de fin del medico en el dia que corresponde a la fecha
            HoraTrabajo = MedicoNegocio.ListarDiasHorariosMedicos(IdMedico).Find(x => x.idDia == (int)Fecha.DayOfWeek);



            /// Carga HorariosDisponibles con todas las horas entre la hora de inicio y fin
            for (int i = int.Parse(HoraTrabajo.HoraInicio); i <= int.Parse(HoraTrabajo.HoraFin); i++)
            {

                HorariosDisponibles.Add(i.ToString());
              
            }

            /// Busca el turno asignado dentro de HorariosDisponibles y lo remueve
            foreach (var item in ListaTurnos)
            {

               string aux = HorariosDisponibles.Find(x => x == item.Hora);
             
                if (aux!=null)
                {
                    HorariosDisponibles.Remove(aux);
                }
                

            }
            return HorariosDisponibles;
        }

    }
}
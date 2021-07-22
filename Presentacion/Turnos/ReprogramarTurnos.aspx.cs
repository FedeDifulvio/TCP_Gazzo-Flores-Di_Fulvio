using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;


namespace Presentacion.Turnos
{
    public partial class ReprogramarTurnos : System.Web.UI.Page
    {
        TurnoNegocio turnoNegocio = new TurnoNegocio();
        Paciente paciente = new Paciente();
        PacienteNegocio pacienteNegocio = new PacienteNegocio();
        MedicoNegocio medicoNegocio = new MedicoNegocio();
        public List<Turno> lista;
        public Turno turno;
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                id = int.Parse(Request.QueryString["id"]);
                lista = (List<Turno>)Session["ListaTurnos"];
                turno = lista.Find(x => x.ID == id);
                Session.Add("turno", turno); 

                paciente = pacienteNegocio.Listar().Find(x => x.ID == turno.Paciente.ID);

                NombreTxt.Text = paciente.Nombre;
                ApellidoTxt.Text = paciente.Apellido;
                dniTextBox.Text = paciente.DNI;
                ObraSocialTxt.Text = paciente.ObraSocial.Nombre;
                LblEspecialidad.Text = "Especialidad: " + turno.Especialidad.Nombre;
                LblMedico.Text = "Médico: " + turno.Medico.Nombre + " " + turno.Medico.Apellido;
                

            }
            catch (Exception ex )
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
            

        }

        protected void Calendario_DayRender(object sender, DayRenderEventArgs e)
        {
            try
            {
                int idMedico = turno.Medico.ID;
                List<DiaHorarioTrabajo> DiasMedico = medicoNegocio.ListarDiasHorariosMedicos(idMedico);

                if (e.Day.Date < DateTime.Today)
                {
                    e.Day.IsSelectable = false;
                }


                foreach (var item in DiasMedico)
                {
                    switch (item.idDia)
                    {
                        case 1:
                            if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Monday)
                            {
                                e.Cell.BackColor = System.Drawing.Color.Yellow;
                            }

                            break;
                        case 2:
                            if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Tuesday)
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
                            if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Thursday)
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
                            if (e.Day.Date > DateTime.Today && e.Day.Date.DayOfWeek == DayOfWeek.Saturday)
                            {
                                e.Cell.BackColor = System.Drawing.Color.Yellow;
                            }

                            break;


                    }
                }

                if (e.Cell.BackColor != System.Drawing.Color.Yellow)
                {
                    e.Day.IsSelectable = false;
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }

        public List<string> Horario_Disponibles(int IdMedico, DateTime Fecha)
        {
            TurnoNegocio Negocio = new TurnoNegocio();
            List<Turno> ListaTurnos = new List<Turno>();
            DiaHorarioTrabajo HoraTrabajo = new DiaHorarioTrabajo();
            List<string> HorariosDisponibles = new List<string>();

            ///Lista turnos: Guardamos todos los turnos que tiene ese medico en ese Fecha
            ListaTurnos = Negocio.Listar().FindAll(x => x.Medico.ID == IdMedico && x.Fecha == Fecha && x.Estado != "Cancelado");
            /// HoraTrabajo: Cargamos el horario de inicio y de fin del medico en el dia que corresponde a la fecha
            HoraTrabajo = medicoNegocio.ListarDiasHorariosMedicos(IdMedico).Find(x => x.idDia == (int)Fecha.DayOfWeek);



            /// Carga HorariosDisponibles con todas las horas entre la hora de inicio y fin
            for (int i = int.Parse(HoraTrabajo.HoraInicio); i <= int.Parse(HoraTrabajo.HoraFin); i++)
            {

                HorariosDisponibles.Add(i.ToString());

            }

            /// Busca el turno asignado dentro de HorariosDisponibles y lo remueve
            foreach (var item in ListaTurnos)
            {

                string aux = HorariosDisponibles.Find(x => x == item.Hora);

                if (aux != null)
                {
                    HorariosDisponibles.Remove(aux);
                }


            }
            return HorariosDisponibles;
        }

        protected void Calendario_SelectionChanged(object sender, EventArgs e)
        {
            List<string> HorariosDisponibles = new List<string>();

            lblFecha.Visible = true;
            lblFecha.Text = "Horarios disponibles para el día " + Calendario.SelectedDate.ToShortDateString();
            ddlHorarios.Visible = true;
            btnAlterarTurno.Visible = true;
            txtObservaciones.Visible = true;
            txtObservaciones.Text = turno.Observacion;

            try
            {
                HorariosDisponibles = Horario_Disponibles(turno.Medico.ID, Calendario.SelectedDate);

                int cont = 0;
                ddlHorarios.Items.Clear();
                foreach (var item in HorariosDisponibles)
                {
                    ddlHorarios.Items.Add(new ListItem(item, cont++.ToString()));

                }
            }
            catch (Exception ex )
            {
                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");

            }

            
        }

        protected void btnAlterarTurno_Click(object sender, EventArgs e)
        {
           
         
            EnvioMail envioMail = new EnvioMail();
            
             Turno aux = (Turno)Session["turno"]; 
            try
            {   
                aux.Fecha = Calendario.SelectedDate; 
                aux.Hora = ddlHorarios.SelectedItem.ToString();
                aux.Observacion = txtObservaciones.Text;
                aux.Estado = "Reprogramado";

                turnoNegocio.ModificarTurno(aux.ID,aux.Fecha,aux.Hora, aux.Observacion, aux.Estado);


                envioMail.armarCorreo(aux, 2);
                envioMail.EnviarEmail();


                string script = "confirmarAccion( 2, 'RegistroTurnos.aspx')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeOk", script, true);

            }
            catch (Exception ex )
            {

                Session.Add("error", ex.Message.ToString());
                Response.Redirect("../Info/PagError.aspx");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Turnos/RegistroTurnos.aspx");
        }

    }
}
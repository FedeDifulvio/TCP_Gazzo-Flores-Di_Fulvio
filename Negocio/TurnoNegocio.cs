using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class TurnoNegocio
    {
        public List<Turno> Listar()
        {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "select t.ID,t.Fecha,t.Hora,t.Estado,m.ID as IdMedico,m.Nombre as NombreMedico,m.Apellido as ApellidoMedico,p.Apellido as ApellidoPaciente,p.Nombre as NombrePaciente, p.Mail as MailPaciente, e.ID as IdEspecialidad,e.Nombre as NombreEspecialidad,p.ID as IdPaciente,T.Observacion from turnos t inner join medicos m on t.IdMedico = m.ID inner join Pacientes p on  t.IdPaciente= p.ID inner join Especialidades e on e.ID=t.IdEspecialidad";

            try
            {

                datos.SetearConsulta(consulta);
                datos.LeerConsulta();


                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();

                    aux.ID = (int)datos.Lector["ID"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Hora = (string)datos.Lector["Hora"];
                    aux.Estado = (string)datos.Lector["Estado"];

                    aux.Medico = new Medico();
                    aux.Medico.ID = (int)datos.Lector["IdMedico"];
                    aux.Medico.Nombre = (string)datos.Lector["NombreMedico"];
                    aux.Medico.Apellido = (string)datos.Lector["ApellidoMedico"];

                    aux.Paciente = new Paciente();
                    aux.Paciente.Apellido = (string)datos.Lector["ApellidoPaciente"];
                    aux.Paciente.Nombre = (string)datos.Lector["NombrePaciente"];
                    aux.Paciente.ID = (int)datos.Lector["IdPaciente"];
                    aux.Paciente.Mail = (string)datos.Lector["MailPaciente"];

                    aux.Especialidad = new Especialidad();
                    aux.Especialidad.Nombre = (string)datos.Lector["NombreEspecialidad"];
                    aux.Especialidad.ID = (int)datos.Lector["IdEspecialidad"];

                    aux.Observacion = (string)datos.Lector["Observacion"];


                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


        public void Agregar(Turno turno )
        {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "Insert into Turnos Values(@IdMedico,@IdPaciente,@IdEspecialidad,@Fecha,@Hora,@Observacion,@Estado)";

            try
            {

                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@IdMedico", turno.Medico.ID);
                datos.AgregarParametro("@IdPaciente", turno.Paciente.ID);
                datos.AgregarParametro("@IdEspecialidad", turno.Especialidad.ID);  
                datos.AgregarParametro("@Fecha", turno.Fecha);
                datos.AgregarParametro("@Hora", turno.Hora);
                datos.AgregarParametro("@Observacion", turno.Observacion);
                datos.AgregarParametro("@Estado", turno.Estado);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }

        public void CancelarTurno(int id) {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();

            string consulta ="Update Turnos set Estado='Cancelado' Where id=@ID";

            try
            {

                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", id);
                
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public void ReprogramarTurno(int id, DateTime fecha, string hora, string observacion)
        {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "Update Turnos Set Fecha=@Fecha, Hora=@Hora, Observacion=@Observacion, Estado='Reprogramado' Where ID=@IdTurno";

            try
            {
                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@Fecha", fecha);
                datos.AgregarParametro("@IdTurno", id);
                datos.AgregarParametro("@Hora", hora);
                datos.AgregarParametro("@Observacion", observacion);

                datos.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

    }
}

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

            string consulta = "select t.ID,t.Fecha,t.Hora,t.Estado,m.ID as IdMedico, m.Nombre as NombreMedico,m.Apellido as ApellidoMedico,p.Apellido as ApellidoPaciente,p.Nombre as NombrePaciente, p.ID as IdPaciente from turnos t inner join medicos m on t.IdMedico = m.ID inner join Pacientes p on  t.IdPaciente= p.ID";

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MedicoNegocio
    {
        public List<Medico> Listar()
        {
            List<Medico> lista = new List<Medico>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "SELECT ID, Nombre, Apellido, Legajo, Estado from Medicos ";

            try
            {

                datos.SetearConsulta(consulta);
                datos.LeerConsulta();


                while (datos.Lector.Read())
                {
                    Medico aux = new Medico();

                    aux.ID = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Legajo = (string)datos.Lector["Legajo"];
                    aux.Estado = (bool)datos.Lector["Estado"];

            

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

        public void Agregar(Medico aux)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Insert into Medicos Values(@nombre,@apellido,@legajo,1)";

            try
            {

                datos.SetearConsulta(consulta);

                datos.AgregarParametro("@nombre", aux.Nombre);
                datos.AgregarParametro("@apellido", aux.Apellido);
                datos.AgregarParametro("@legajo", aux.Legajo);

                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


        public List<EspecialidadDeMedico> ListarEspecialidadesMedico(int ID)
        {
            List<EspecialidadDeMedico> lista = new List<EspecialidadDeMedico>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "select  EM.ID, EM.idMedicos, EM.idEspecialidad, E.Nombre from EspecialidadesPorMedico as EM inner join Especialidades as E on EM.IdEspecialidad = E.ID where EM.IdMedicos=@ID" ;

            try
            {

                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);
                datos.LeerConsulta();



                while (datos.Lector.Read())
                {
                    EspecialidadDeMedico aux = new EspecialidadDeMedico();


                    aux.id = (int)datos.Lector["ID"];
                    aux.idMedico = (int)datos.Lector["idMedicos"];
                    aux.especialidad = new Especialidad((int)datos.Lector["IdEspecialidad"], (string)datos.Lector["Nombre"]);

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

        public List<ObraSocialDeMedico> ListarObrasSocialesMedico(int ID)
        {
            List<ObraSocialDeMedico> lista = new List<ObraSocialDeMedico>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "select OM.ID, OM.IdMedicos,OM.IdObraSocial,O.Nombre from ObraSocialesPorMedico OM inner join ObraSocial O on O.ID = OM.IdObraSocial where OM.IdMedicos = @ID";
           
            try
            {

                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);
                datos.LeerConsulta();
                
                while (datos.Lector.Read())
                {
                    ObraSocialDeMedico aux = new ObraSocialDeMedico();
                    aux.id = (int)datos.Lector["ID"];
                    aux.idMedico = (int)datos.Lector["IdMedicos"];
                    aux.obraSocial = new ObraSocial((int)datos.Lector["IdObraSocial"],(string)datos.Lector["Nombre"]);
                     
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


        public List<DiaHorarioTrabajo> ListarDiasHorariosMedicos(int ID)
        {
            List<DiaHorarioTrabajo> lista = new List<DiaHorarioTrabajo>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "select  DM.ID, DM.idMedico, D.Nombre, DM.HoraInicio, DM.HoraFin, D.ID as IdDia From DiasPorMedico as DM inner join Dias as D on DM.IdDia = D.ID where DM.IdMedico =@ID" ;

            try
            {

                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);
                datos.LeerConsulta();


                while (datos.Lector.Read())
                {
                    DiaHorarioTrabajo aux = new DiaHorarioTrabajo();

                    aux.ID = (int)datos.Lector["ID"];
                    aux.idMedico = (int)datos.Lector["idMedico"];
                    aux.Dia = (string)datos.Lector["Nombre"];
                    aux.idDia = (int)datos.Lector["idDia"];
                    aux.HoraInicio = (string)datos.Lector["HoraInicio"];
                    aux.HoraFin = (string)datos.Lector["HoraFin"];
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


        public void AgregarObraSocialMedico(int idObraSocial,int idMedico)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Insert into ObraSocialesPorMedico Values(@idObraSocial,@idMedico)";

            try
            {
                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@idObraSocial", idObraSocial);
                datos.AgregarParametro("@idMedico", idMedico);
                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }

        } 

        public void AgregarEspecialidadMedico( int idEspecialidad, int idMedico)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Insert into EspecialidadesPorMedico Values(@idEspecialidad,@idMedico)";

            try
            {
                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@idEspecialidad", idEspecialidad);
                datos.AgregarParametro("@idMedico", idMedico);
                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AgregarDiaMedico(int idDia, int idMedico, string horaInicio, string horaFin)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Insert into DiasPorMedico Values(@idDia,@idMedico, @horainicio, @horafin)";

            try
            {
                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@idDia", idDia);
                datos.AgregarParametro("@idMedico", idMedico);
                datos.AgregarParametro("@horainicio", horaInicio);
                datos.AgregarParametro("@horafin", horaFin);
                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void ElimObraSocialMedico(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Delete from ObraSocialesPorMedico Where Id=@ID";


            try
            {
                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);
                
                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }

        } 

        public void ElimEspecialidadMedico(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Delete from EspecialidadesPorMedico Where Id=@ID";


            try
            {
                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);

                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ElimDiaMedico(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Delete from DiasPorMedico Where Id=@ID";


            try
            {
                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);

                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

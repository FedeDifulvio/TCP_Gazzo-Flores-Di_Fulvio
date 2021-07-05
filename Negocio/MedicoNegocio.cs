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




        public List<Especialidad> ListarEspecialidadesMedico(int ID)
        {
            List<Especialidad> lista = new List<Especialidad>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "select  EM.ID, E.Nombre from EspecialidadesPorMedico as EM inner join Especialidades as E on EM.IdEspecialidad = E.ID where EM.IdMedicos=@ID" ;

            try
            {

                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);
                datos.LeerConsulta();



                while (datos.Lector.Read())
                {
                    Especialidad aux = new Especialidad();


                    aux.ID = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

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

        public List<ObraSocial> ListarObrasSocialesMedico(int ID)
        {
            List<ObraSocial> lista = new List<ObraSocial>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "select  O.ID, O.Nombre from ObraSocialesPorMedico as OM inner join  ObraSocial as O on OM.IdObraSocial = O.ID where OM.IdMedicos =@ID";
           
            try
            {

                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);
                datos.LeerConsulta();
                
                while (datos.Lector.Read())
                {
                    ObraSocial aux = new ObraSocial();

                    aux.ID = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
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

            string consulta = "select  DM.ID, D.Nombre, DM.HoraInicio, DM.HoraFin From DiasPorMedico as DM inner join Dias as D on DM.IdDia = D.ID where DM.IdMedico =@ID" ;

            try
            {

                datos.SetearConsulta(consulta);
                datos.AgregarParametro("@ID", ID);
                datos.LeerConsulta();


                while (datos.Lector.Read())
                {
                    DiaHorarioTrabajo aux = new DiaHorarioTrabajo();

                    aux.ID = (int)datos.Lector["ID"];
                    aux.Dia = (string)datos.Lector["Nombre"];
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
    }
}

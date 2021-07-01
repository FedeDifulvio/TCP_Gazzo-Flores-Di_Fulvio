using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EspecialidadesNegocio
    {
        public List<Especialidad> Listar()
        {

            List<Especialidad> lista = new List<Especialidad>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Id, Nombre from Especialidades");
                datos.LeerConsulta();

                while (datos.Lector.Read())
                {
                    lista.Add(new Especialidad((int)datos.Lector["Id"], (string)datos.Lector["Nombre"]));
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

        public void Agregar(Especialidad aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetearConsulta("insert into Especialidades values (@nombre)");
                datos.AgregarParametro("@nombre", aux.Nombre);

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

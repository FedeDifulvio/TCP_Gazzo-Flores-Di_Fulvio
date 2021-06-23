using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ObraSocialNegocio
    {
        public List<ObraSocial> listar()
        {

            List<ObraSocial> lista = new List<ObraSocial>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Id, Nombre from ObraSocial");
                datos.LeerConsulta();

                while (datos.Lector.Read())
                {
                    lista.Add(new ObraSocial((int)datos.Lector["Id"], (string)datos.Lector["Nombre"]));
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

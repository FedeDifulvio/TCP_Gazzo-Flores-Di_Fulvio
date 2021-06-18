using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;



namespace Negocio
{
    public class PacienteNegocio
    {
        public List<Paciente> Listar() {
            List<Paciente> lista = new List<Paciente>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "select P.ID,P.Nombre,P.Apellido, P.DNI, P.Direccion, P.FechaNacimiento, P.Mail, P.Telefono, O.Nombre as ObraSocial, O.ID as IdObraSocial from Pacientes P inner join ObraSocial O on P.IdObraSocial = O.ID";

            try
            {

                datos.SetearConsulta(consulta);
                datos.LeerConsulta();


                while (datos.Lector.Read())
                {
                    Paciente aux = new Paciente();

                    aux.ID = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.DNI = (string)datos.Lector["DNI"];
                    aux.ObraSocial = new ObraSocial((int)datos.Lector["IdObraSocial"],(string)datos.Lector["ObraSocial"]);
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    aux.Mail = (string)datos.Lector["Mail"];
                    aux.Telefono = (string)datos.Lector["Telefono"];


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

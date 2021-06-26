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

            string consulta = "select P.Estado,P.ID,P.Nombre,P.Apellido, P.DNI, P.Direccion, P.FechaNacimiento, P.Mail, P.Telefono, O.Nombre as ObraSocial, O.ID as IdObraSocial from Pacientes P inner join ObraSocial O on P.IdObraSocial = O.ID";

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
        public void Agregar(Paciente aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetearConsulta("insert into Pacientes(Nombre, Apellido, DNI, IdObraSocial, Direccion, FechaNacimiento, Mail, Telefono) values ( @nombre, @apellido, @dni, @idObraSocial, @direccion, @fechaNacimiento, @mail, @telefono)");
                datos.AgregarParametro("@nombre", aux.Nombre);
                datos.AgregarParametro("@apellido", aux.Apellido);
                datos.AgregarParametro("@dni", aux.DNI);
                datos.AgregarParametro("@idObraSocial", aux.ObraSocial.ID);
                datos.AgregarParametro("@direccion", aux.Direccion);
                datos.AgregarParametro("@fechaNacimiento", aux.FechaNacimiento);
                datos.AgregarParametro("@mail", aux.Mail);
                datos.AgregarParametro("@telefono", aux.Telefono);



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

        public void Modificar(Paciente aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update Pacientes set nombre = @nombre, apellido = @apellido, dni = @dni, mail = @mail, telefono = @telefono, direccion = @direccion, fechaNacimiento = @fechaNacimiento, idObraSocial = @idObraSocial Where id = @id");
                
                datos.AgregarParametro("@nombre", aux.Nombre);
                datos.AgregarParametro("@apellido", aux.Apellido);
                datos.AgregarParametro("@dni", aux.DNI);
                datos.AgregarParametro("@mail", aux.Mail);
                datos.AgregarParametro("@telefono", aux.Telefono);
                datos.AgregarParametro("@direccion", aux.Direccion);
                datos.AgregarParametro("@fechaNacimiento", aux.FechaNacimiento);
                datos.AgregarParametro("@idObraSocial", aux.ObraSocial.ID);
                datos.AgregarParametro("@id", aux.ID);
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

        public void bajaLogica(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("update Pacientes set estado = 0 Where id = @id");
                datos.AgregarParametro("@id", id);
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


    }

    
}

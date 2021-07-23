using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class UsuarioNegocio
    {

        public bool Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();           
            try
            {
                datos.SetearConsulta("Select U.Id, U.TipoUsuario, U.Token,TU.Nombre as NombreTipo from Usuarios U inner join TipoUsuario TU on TU.ID=U.TipoUsuario  Where U.Username = @user AND U.Pass = @pass");
                datos.AgregarParametro("@user", usuario.User);
                datos.AgregarParametro("@pass", usuario.Pass);

                datos.LeerConsulta();
                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.TipoUsuario = new TipoUsuario((int)datos.Lector["TipoUsuario"], (string)datos.Lector["NombreTipo"]); 
                    
                    if(usuario.TipoUsuario.Id != 1 && usuario.TipoUsuario.Id != 2)
                    {
                        usuario.Token =(string)datos.Lector["Token"];

                    }
                    return true;
                }
                return false;
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



        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();

            string consulta = "select U.ID, U.Username, U.Pass, U.Token, U.TipoUsuario, TU.Nombre from Usuarios U inner join TipoUsuario TU on U.TipoUsuario = TU.ID";

            try
            {

                datos.SetearConsulta(consulta);
                datos.LeerConsulta();


                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();

                    aux.Id = (int)datos.Lector["ID"];
                    aux.User =(string)datos.Lector["Username"];
                    aux.Pass =(string)datos.Lector["Pass"];
                    aux.TipoUsuario= new TipoUsuario((int)datos.Lector["TipoUsuario"], (string)datos.Lector["Nombre"]);

                    if (aux.TipoUsuario.Id == 3)
                    {
                        aux.Token = (string)datos.Lector["Token"];
                    }
                    
                    

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


        public List<TipoUsuario> ListarTiposUsuarios()
        {

            List<TipoUsuario> lista = new List<TipoUsuario>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select ID, Nombre from TipoUsuario");
                datos.LeerConsulta();

                while (datos.Lector.Read())
                {
                    lista.Add(new TipoUsuario((int)datos.Lector["ID"], (string)datos.Lector["Nombre"]));
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

        public void AgregarUsuario( Usuario aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetearConsulta("insert into Usuarios(Username, Pass, TipoUsuario, Token) values(@Username,@Pass,@TipoUsuario,@Token)");
                datos.AgregarParametro("@Username", aux.User);
                datos.AgregarParametro("@Pass", aux.Pass);
                datos.AgregarParametro("@TipoUsuario", aux.TipoUsuario.Id);
                datos.AgregarParametro("@Token", aux.Token);
                
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

        public void EliminarUsuario(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetearConsulta("delete from Usuarios where id = @id");
                datos.AgregarParametro("@id", id);

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

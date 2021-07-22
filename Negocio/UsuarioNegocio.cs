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
    }
}

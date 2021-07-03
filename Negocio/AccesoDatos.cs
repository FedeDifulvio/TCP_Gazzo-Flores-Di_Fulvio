using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    
    public class AccesoDatos
    {
        public string conexionFede = "data source=(local); initial catalog= DiFulvio_Flores_Gazzo_DB; integrated security=SSPI";
        public string conexionparatodes = "data source=(local)\\SQLEXPRESS; initial catalog= DiFulvio_Flores_Gazzo_DB; integrated security=SSPI";
        private SqlConnection conexion;

        private SqlCommand comando;

        private SqlDataReader lector;

        public AccesoDatos()
        {
            conexion = new SqlConnection(conexionFede);
            comando = new SqlCommand();
        }

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }
        public void AgregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void LeerConsulta()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();


        }
        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();

        }
        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
        }



    }
}

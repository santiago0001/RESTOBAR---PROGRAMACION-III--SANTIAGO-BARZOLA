using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;
using Dominio;

namespace Negocio
{
  public   class Estadisticas
    {
        public List<EmpleadoEstadistica> listaEmpleadosCan()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<EmpleadoEstadistica> listado = new List<EmpleadoEstadistica>();
            EmpleadoEstadistica nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "VwCantPlatos ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new  EmpleadoEstadistica();
                    nuevo.Nombre = lector.GetString(0);
                    nuevo.CantidadPlatos = lector.GetInt64(1);

                    listado.Add(nuevo);

                }

                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }


    }
}

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
        public List<EmpleadoEstadistica> listaEmpleadosCan(string inicio, string fin)
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
                comando.CommandText = " spEstadisticaEmpleados '"+inicio+ "','"+ fin+"'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new  EmpleadoEstadistica();
                    nuevo.Nombre = lector.GetString(0);
                    nuevo.CantidadPlatos = lector.GetInt32(1);
                    nuevo.Dni = lector.GetInt32(2);


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


        public List<PlatoEstadistica> ListarPlatoEst(string inicio, string fin)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<PlatoEstadistica> listado = new List<PlatoEstadistica>();
            PlatoEstadistica nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "spEstadisticaPlato '"+ inicio+"','"+fin+"'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new PlatoEstadistica();
                    nuevo.Nombre = lector.GetString(0);
                    nuevo.Cantidad = lector.GetInt64(1);

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



        public List<DiaEstadistica> ListarDiasEst()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<DiaEstadistica> listado = new List<DiaEstadistica>();
            DiaEstadistica nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select * from  EstadisticaRecaudacionMes order by dia desc";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new DiaEstadistica();
                    nuevo.Dia = lector.GetInt32(0);
                    nuevo.Recaudacion = Math.Round( lector.GetDecimal(1),2);

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

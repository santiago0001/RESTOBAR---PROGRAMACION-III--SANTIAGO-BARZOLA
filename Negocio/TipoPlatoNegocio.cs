using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;
namespace Negocio
{
    public class TipoPlatoNegocio
    {

        public List<TipoPlato> listarTipoPlatoEliminado()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<TipoPlato> listado = new List<TipoPlato>();
            TipoPlato nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT id,nombre,estado FROM TIPO_PLATO";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new TipoPlato();
                    nuevo.id = lector.GetInt64(0);
                    nuevo.nombre = lector.GetString(1);
                    nuevo.estado = lector.GetBoolean(2);


                    if (!nuevo.estado)
                    {
                        listado.Add(nuevo);
                    }

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

        public List<TipoPlato> listarTipoPlato()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<TipoPlato> listado = new List<TipoPlato>();
            TipoPlato nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT id,nombre,estado FROM TIPO_PLATO";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new TipoPlato();
                    nuevo.id = lector.GetInt64(0);
                    nuevo.nombre = lector.GetString(1);
                    nuevo.estado = lector.GetBoolean(2);


                    if (!nuevo.estado)
                    {
                        listado.Add(nuevo);
                    }

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






        public void agregarMarca(TipoPlato nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into TIPO_PLATO (nombre, estado) VALUES ";
                comando.CommandText += "('" + nuevo.nombre + "',1)";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

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

        public void modificarMarca(TipoPlato modificar)
            {
                AccesoDatosManager accesoDatos = new AccesoDatosManager();
                try
                {

                    accesoDatos.setearConsulta("update Tipo_plato Set Nombre=@Nombre Where Id=" + modificar.id.ToString());
                    accesoDatos.Comando.Parameters.Clear();
                    accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.nombre);
                    accesoDatos.abrirConexion();
                    accesoDatos.ejecutarAccion();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    accesoDatos.cerrarConexion();
                }
            }

            public void DeleteTipo(TipoPlato nuevo)
            {
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                try
                {
                    conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                    comando.CommandText = "update tipo_plato set estado =0 where id=" + nuevo.id;
                    comando.Connection = conexion;
                    conexion.Open();

                    comando.ExecuteNonQuery();

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



            public void RestaurarTipo(TipoPlato viejo)
            {
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                try
                {
                    conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                    comando.CommandText = "UPDATE tipo_plato SET ESTADO=1 where id=" + viejo.id;
                    comando.Connection = conexion;
                    conexion.Open();

                    comando.ExecuteNonQuery();

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

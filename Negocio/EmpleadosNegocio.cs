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
   public class EmpleadosNegocio
    {
        public List<Empleado> listarEmpleadoTotal()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Empleado> listado = new List<Empleado>();
            Empleado nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT *from empleado";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Empleado();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Apellido = lector.GetString(2);
                    nuevo.Puesto = lector.GetString(3);
                    nuevo.Dni = lector.GetInt32(4);
                    nuevo.Estado = lector.GetBoolean(5);

                    nuevo.Usuario = lector.GetString(6);
                    nuevo.Contraseña = lector.GetString(7);

                    
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

        public List<Empleado> listarEmpleado()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Empleado> listado = new List<Empleado>();
            Empleado nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT *from empleado";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Empleado();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Apellido = lector.GetString(2);
                    nuevo.Puesto = lector.GetString(3);
                    nuevo.Dni= lector.GetInt32(4);
                    nuevo.Estado = lector.GetBoolean(5);

                    nuevo.Usuario = lector.GetString(6);
                    nuevo.Contraseña = lector.GetString(7);
                    
                    if (nuevo.Estado) {
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

        public List<Empleado> listarMeseros()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Empleado> listado = new List<Empleado>();
            Empleado nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT *from vw_mesero";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Empleado();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Puesto = lector.GetString(2);
                    nuevo.Dni = lector.GetInt32(3);
                    nuevo.Estado = lector.GetBoolean(4);

                    nuevo.Usuario = lector.GetString(5);
                    nuevo.Contraseña = lector.GetString(6);

                    if (nuevo.Estado && nuevo.Puesto=="Mesero")
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

        public List<Empleado> listarEmpleadoEliminados()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Empleado> listado = new List<Empleado>();
            Empleado nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT *from empleado";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Empleado();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Apellido = lector.GetString(2);
                    nuevo.Puesto = lector.GetString(3);
                    nuevo.Dni = lector.GetInt32(4);
                    nuevo.Estado = lector.GetBoolean(5);

                    nuevo.Usuario = lector.GetString(6);
                    nuevo.Contraseña = lector.GetString(7);

                    if (!nuevo.Estado)
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



        public void agregarEmpleado(Empleado nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into empleado (nombre,apellido,puesto,dni,estado,usuario,contrasena) VALUES ";
                comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.Apellido + "','" +
                  nuevo.Puesto + "'," + nuevo.Dni + ",1,'" + nuevo.Usuario + "','" + nuevo.Contraseña + "')";
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

        public void modificarEmpleado(Empleado modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update empleado Set Nombre=@Nombre, apellido=@apellido, " +
               "puesto=@puesto,dni=@dni,usuario=@usuario,contrasena=@contrasena  Where Id=" + modificar.Id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@apellido", modificar.Apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@puesto", modificar.Puesto);
                accesoDatos.Comando.Parameters.AddWithValue("@dni", modificar.Dni);
                accesoDatos.Comando.Parameters.AddWithValue("@usuario", modificar.Usuario);
                accesoDatos.Comando.Parameters.AddWithValue("@contrasena", modificar.Contraseña);

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

        public void DeleteEmpleado(Empleado nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "UPDATE empleado SET ESTADO=0 where id=" + nuevo.Id;
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

        public void RestaurarEmpleado(Empleado viejo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "UPDATE empleado SET ESTADO=1 where id=" + viejo.Id;
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

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
    public class PlatoNegocio 
    {
        public List<Plato> listarPlatosEliminados()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Plato> listado = new List<Plato>();
            Plato nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select id,nombre,precio,tipo,idtipo,estado,descripcion From view_platos ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Plato();
                    nuevo.id = lector.GetInt64(0);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Precio = lector.GetDecimal(2);
                    nuevo.Tipo = new TipoPlato();
                    nuevo.Tipo.nombre = lector["tipo"].ToString();
                    nuevo.Tipo.id = (Int64)lector["idtipo"];
                    nuevo.Estado = lector.GetBoolean(5);




                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.
                    // if (!Convert.IsDBNull(lector["Debilidad"]))
                    //    nuevo.Debilidad = lector.GetString(2);

                    if (!Convert.IsDBNull(lector["descripcion"]))
                        nuevo.Descripcion = (string)lector["descripcion"];

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


        public List<Plato> listarPlatos()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Plato> listado = new List<Plato>();
            Plato nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select id,nombre,precio,tipo,idtipo,estado,descripcion From view_platos ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Plato();
                    nuevo.id = lector.GetInt64(0);
                   nuevo.Nombre = lector.GetString(1);
                    nuevo.Precio = lector.GetDecimal(2);
                    nuevo.Tipo = new TipoPlato();
                    nuevo.Tipo.nombre = lector["tipo"].ToString();
                    nuevo.Tipo.id = (Int64)lector["idtipo"];
                    nuevo.Estado = lector.GetBoolean(5);




                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.
                    // if (!Convert.IsDBNull(lector["Debilidad"]))
                    //    nuevo.Debilidad = lector.GetString(2);

                    if (!Convert.IsDBNull(lector["descripcion"]))
                       nuevo.Descripcion = (string)lector["descripcion"];

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



        public void agregarPlato(Plato nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "INSERT INTO CARTA (NOMBRE,cantidad) values";
               comando.CommandText += "('" + nuevo.Nombre + "', " + nuevo.Cantidad +")";
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

        public void modificarPlato(Plato modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update carta Set Nombre=@Nombre, precio=@precio,tipo=@tipo, tenedor=@tenedor, cuchillo=@cuchillo, cuchara=@cuchara Where idplato=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Tipo", modificar.Tipo);

                accesoDatos.Comando.Parameters.AddWithValue("@precio", modificar.Precio);


                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
                //hola
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

        public void DeletePlato(Plato nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "update plato set estado=0 where id=" + nuevo.id;
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

        public void RestaurarPlato(Plato nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "update plato set estado=1 where id=" + nuevo.id;
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

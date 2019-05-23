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
  public  class VajillaNegocio
    {
        public List<Insumo> listarInsumosEliminados()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Insumo> listado = new List<Insumo>();
            Insumo nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select  V.ID,V.NOMBRE, V.CANTIDAD,estado From VAJILLA as V";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Insumo();
                    nuevo.id = lector.GetInt32(0);
                    nuevo.Nombre = lector.GetString(1);

                    nuevo.Estado = lector.GetBoolean(3);



                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.

                    if (!Convert.IsDBNull(lector["Cantidad"]))
                        nuevo.Cantidad = lector.GetInt32(2);


                    //  if (!Convert.IsDBNull(lector["Precio"]))
                    //      nuevo.Precio = lector.GetDecimal(3);


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





        public List<Insumo> listarInsumos()
            {
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;
                List<Insumo> listado = new List<Insumo>();
                Insumo nuevo;
                try
                {
                    conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                    comando.CommandText = "select  V.ID,V.NOMBRE, V.CANTIDAD,estado From VAJILLA as V";
                    comando.Connection = conexion;
                    conexion.Open();
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        nuevo = new Insumo();
                    nuevo.id = lector.GetInt32(0);                                   
                    nuevo.Nombre = lector.GetString(1);

                    nuevo.Estado = lector.GetBoolean(3);



                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.

                    if (!Convert.IsDBNull(lector["Cantidad"]))
                        nuevo.Cantidad = lector.GetInt32(2);


                    //  if (!Convert.IsDBNull(lector["Precio"]))
                    //      nuevo.Precio = lector.GetDecimal(3);


                    if (nuevo.Estado)
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

            public void agregarVajilla(Insumo nuevo)
            {
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into VAJILLA (Nombre, Cantidad,estado) values";
                comando.CommandText += "('" + nuevo.Nombre + "', " + nuevo.Cantidad + ",1)";
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

            public void modificarInsumo(Insumo modificar)
            {
                AccesoDatosManager accesoDatos = new AccesoDatosManager();
                try
                {

                accesoDatos.setearConsulta("update vajilla Set Nombre=@Nombre, cantidad=@cantidad Where Id=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@cantidad", modificar.Cantidad);

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

        public void DeleteVajilla(Insumo nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "update vajilla set estado=0 where id="+nuevo.id;
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


        public void RestaurarVajilla(Insumo nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "update vajilla set estado=1 where id=" + nuevo.id;
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

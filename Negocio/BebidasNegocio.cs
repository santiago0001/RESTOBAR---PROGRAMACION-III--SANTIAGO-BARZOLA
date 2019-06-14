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
    public class BebidasNegocio
    {
        public List<Bebida> listarBebidasEliminadas()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Bebida> listado = new List<Bebida>();
            Bebida nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT B.ID,B.nombre_bebida,B.DESCRIPCION,B.PRECIO,B.COPA,B.CANTIDAD,b.Marca,b.marcaid,b.estado  FROM View_marca AS B";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Bebida();
                    nuevo.id = lector.GetInt64(0);
                    //  nuevo.idMarca = lector.GetInt64(1);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Precio = lector.GetDecimal(3);
                    nuevo.Copa = lector.GetBoolean(4);
                    // nuevo.marca.Nombre = lector.GetString(6);
                    nuevo.marca = new Marca();
                    nuevo.marca.Id = (Int64)lector["marcaid"];
                    nuevo.marca.Nombre = lector["Marca"].ToString();
                    nuevo.Estado = lector.GetBoolean(8);






                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.



                    if (!Convert.IsDBNull(lector["Descripcion"]))
                        nuevo.Descripcion = lector.GetString(2);
                    if (!Convert.IsDBNull(lector["Cantidad"]))
                        nuevo.Cantidad = lector.GetInt32(5);



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



        public List<Bebida> listarBebidas()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Bebida> listado = new List<Bebida>();
            Bebida nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT B.ID,B.nombre_bebida,B.DESCRIPCION,B.PRECIO,B.COPA,B.CANTIDAD,b.Marca,b.marcaid,b.estado  FROM View_marca AS B";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Bebida();
                    nuevo.id = lector.GetInt64(0);
                  //  nuevo.idMarca = lector.GetInt64(1);
                    nuevo.Nombre = lector.GetString(1);
                   nuevo.Precio = lector.GetDecimal(3);
                    nuevo.Copa = lector.GetBoolean(4);
                    // nuevo.marca.Nombre = lector.GetString(6);
                    nuevo.marca = new Marca();
                    nuevo.marca.Id = (Int64)lector["marcaid"];
                    nuevo.marca.Nombre = lector["Marca"].ToString();
                    nuevo.Estado = lector.GetBoolean(8);






                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.



                    if (!Convert.IsDBNull(lector["Descripcion"]))
                        nuevo.Descripcion = lector.GetString(2);
                    if (!Convert.IsDBNull(lector["Cantidad"]))
                         nuevo.Cantidad = lector.GetInt32(5);



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

        public void agregarBebida(Bebida nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into bebida (IDMARCA,NOMBRE,DESCRIPCION,PRECIO,COPA,CANTIDAD,ESTADO ) VALUES ";
                comando.CommandText += "("+ nuevo.marca.Id + ", '" + nuevo.Nombre + "','"+
                  nuevo.Descripcion + "',"+ nuevo.Precio + ",'"+ nuevo.Copa+ "',"+nuevo.Cantidad+",1)";
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

        public void modificarInsumo(Bebida modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update bebida Set Nombre=@Nombre, cantidad=@cantidad, descripcion=@descripcion,copa=@copa,idmarca=@idMarca,precio=@precio Where Id=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@descripcion", modificar.Descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@cantidad", modificar.Cantidad);
                accesoDatos.Comando.Parameters.AddWithValue("@copa", modificar.Copa);
                accesoDatos.Comando.Parameters.AddWithValue("@idMarca", modificar.marca.Id);
                accesoDatos.Comando.Parameters.AddWithValue("@precio", modificar.Precio);

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

        public void DeleteBebida(Bebida nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "UPDATE BEBIDA SET ESTADO=0 where id=" + nuevo.id;
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

        public void RestaurarBebida(Bebida viejo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "UPDATE BEBIDA SET ESTADO=1 where id=" + viejo.id;
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




        public List<Bebida> listarBebidasXmarca(Int64 idmarca)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Bebida> listado = new List<Bebida>();
            Bebida nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "BebidasxMarca "+idmarca;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Bebida();
                    nuevo.id = lector.GetInt64(1);
                    //  nuevo.idMarca = lector.GetInt64(1);
                    nuevo.Nombre = lector.GetString(0);
                    nuevo.Descripcion = lector.GetString(2);



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


        public string DescripcionBebida(Int64 idBebida)
        {
            string descr;
            descr = " nada";
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {

                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "descripcionBebida " + idBebida;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    descr = lector.GetString(0);


                }
                return descr;


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


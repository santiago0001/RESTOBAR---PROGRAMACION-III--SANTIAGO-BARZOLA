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
                comando.CommandText = "select *From CARTA AS  R";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Plato();
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Precio = lector.GetInt32(0);
                    nuevo.TipoPlato = lector.GetString(1);


                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.
                   // if (!Convert.IsDBNull(lector["Debilidad"]))
                    //    nuevo.Debilidad = lector.GetString(2);

                   // if (!Convert.IsDBNull(lector["UsaCapa"]))
                   //     nuevo.UsaCapa = (bool)lector["UsaCapa"];

                   // if (!Convert.IsDBNull(lector["Volador"]))
                   //     nuevo.Volador = (bool)lector["Volador"];



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

        public void agregarPlato(Plato nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "INSERT INTO CARTA (NOMBRE,PRECIO,TIPO,TENEDOR,CUCHILLO,CUCHARA) values";
               comando.CommandText += "('" + nuevo.Nombre + "', " + nuevo.Precio 
               + ", '" + nuevo.TipoPlato + "', " + nuevo.Tenedor + ", " 
               + nuevo.Cuchillo  +", " + nuevo.Cuchara;
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

                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Debilidad", modificar.Precio);
                accesoDatos.Comando.Parameters.AddWithValue("@UC", modificar.TipoPlato);

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

    }
}

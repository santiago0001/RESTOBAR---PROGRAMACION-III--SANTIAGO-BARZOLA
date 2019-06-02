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
  public  class MesaNegocio
    {
        public List<Mesa> listarMesasEliminada()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Mesa> listado = new List<Mesa>();
            Mesa nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT *from vw_mesas";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Mesa();
                    nuevo.IdMesa = lector.GetInt64(0);
                    nuevo.NomApe = lector.GetString(1);
                    nuevo.IdMesero = lector.GetInt64(2);
                    nuevo.estado = lector.GetBoolean(3);
                    nuevo.ocupado = lector.GetBoolean(4);
                    if (nuevo.ocupado)
                    { nuevo.stOcupado = "Ocupado"; }
                    else { nuevo.stOcupado = "Libre"; }


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


        public List<Mesa> listarMesa()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Mesa> listado = new List<Mesa>();
            Mesa nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT *from vw_mesas";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Mesa();
                    nuevo.IdMesa = lector.GetInt64(0);
                    nuevo.NomApe = lector.GetString(1);
                    nuevo.IdMesero = lector.GetInt64(2);
                    nuevo.estado = lector.GetBoolean(3);
                    nuevo.ocupado = lector.GetBoolean(4);
                    if (nuevo.ocupado)
                    { nuevo.stOcupado = "Ocupado"; }
                    else { nuevo.stOcupado = "Libre"; }


                    if (nuevo.estado)
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

        public void agregarMesa(Empleado nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into mesa (idmesero,ocupado,estado)  VALUES ";
                comando.CommandText += "(" + nuevo.Id +  ",0,1)";
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

        public void modificarMesero(Mesa mesa,Empleado em)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update mesa set idmesero=@idmesero where id=" + mesa.IdMesa.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idmesero", em.Id);

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

        public void DeleteMesa(Mesa mesa)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update mesa set estado=0 where id=" + mesa.IdMesa.ToString());
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


        public void RestaurarMesa(Mesa mesa)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update mesa set estado=1 where id=" + mesa.IdMesa.ToString());
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

    }
}

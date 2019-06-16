using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;


namespace Negocio
{
    public class PedidoNegocio
    {
        public List<PedidoPlato> ListarPlatosXmesa(Int64 idMesa)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<PedidoPlato> listado = new List<PedidoPlato>();
            PedidoPlato nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "platoxmesa "+idMesa;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new PedidoPlato();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.CantPla = lector.GetInt64(1);
                    nuevo.NomPlato = lector.GetString(2);
                    nuevo.precioPla = lector.GetDecimal(4);
                    if (lector.GetBoolean(6))
                    {
                        nuevo.Entregado = "Entregado";
                    }
                    else
                    {
                        nuevo.Entregado = "Pendiente";
                    }




                    if (!Convert.IsDBNull(lector["descripcion"]))
                        nuevo.DescripPla = (string)lector["descripcion"];

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

        public List<PedidoBebida> ListarBebidasPedido(Int64 idMesa)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<PedidoBebida> listado = new List<PedidoBebida>();
            PedidoBebida nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "bebidaxmesa " + idMesa;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new PedidoBebida();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.Cant = lector.GetInt64(4);
                    nuevo.Nom = lector.GetString(1);
                    nuevo.precio = lector.GetDecimal(3);

                    if (lector.GetBoolean(5))
                    {
                        nuevo.Entregado = "Entregado";
                    }
                    else
                    {
                        nuevo.Entregado = "Pendiente";
                    }

                    if (!Convert.IsDBNull(lector["descripcion"]))
                        nuevo.Descr = (string)lector["descripcion"];

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

        public void AgregarPedidoPla(Int64 idplato, Int64 idmesa, Int64 cantidad)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "AgregarPlatoPedido "+ idplato + ","+ idmesa +","+ cantidad;
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

        public void AgregarBebidaPla(Int64 idbebida, Int64 idmesa, Int64 cantidad)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "AgegarBebidaPedido " + idmesa + "," + idbebida + "," + cantidad;
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


        public List<PedidoPlato> ListarPlatoPendiente(Int64 idMesa)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<PedidoPlato> listado = new List<PedidoPlato>();
            PedidoPlato nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "spPlatosPendientes " + idMesa;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new PedidoPlato();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.CantPla = lector.GetInt64(3);
                    nuevo.NomPlato = lector.GetString(1);
                    nuevo.precioPla = lector.GetDecimal(2);
                    nuevo.Entregado = "Pendiente";
               

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
        public List<PedidoBebida> ListarBebidasPendiente(Int64 idMesa)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<PedidoBebida> listado = new List<PedidoBebida>();
            PedidoBebida nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "spBebidasPendientes " + idMesa;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new PedidoBebida();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.Cant = lector.GetInt64(4);
                    nuevo.Nom = lector.GetString(1);
                    nuevo.precio = lector.GetDecimal(3);
                    nuevo.Descr = lector.GetString(2);
                    nuevo.Entregado = "Pendiente";


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

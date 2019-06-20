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
                    nuevo.Cantidad = lector.GetInt64(1);
                    nuevo.Plato = lector.GetString(2);
                    nuevo.Precio = Math.Round(lector.GetDecimal(4), 2);
                    if (lector.GetBoolean(6))
                    {
                        nuevo.Estado = "Entregado";
                    }
                    else
                    {
                        nuevo.Estado = "Pendiente";
                    }




                    if (!Convert.IsDBNull(lector["descripcion"]))
                        nuevo.Descripcion = (string)lector["descripcion"];

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
                    nuevo.Cantiadad = lector.GetInt64(4);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Precio = Math.Round(lector.GetDecimal(3), 2);

                    if (lector.GetBoolean(5))
                    {
                        nuevo.Estado = "Entregado";
                    }
                    else
                    {
                        nuevo.Estado = "Pendiente";
                    }

                    if (!Convert.IsDBNull(lector["descripcion"]))
                        nuevo.Descripcion = (string)lector["descripcion"];

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
                    nuevo.Cantidad = lector.GetInt64(3);
                    nuevo.Plato = lector.GetString(1);
                    nuevo.Precio = Math.Round(lector.GetDecimal(2), 2);
                    nuevo.Estado = "Pendiente";
               

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
                    nuevo.Cantiadad = lector.GetInt64(4);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Precio = Math.Round(lector.GetDecimal(3), 2) ;
                    nuevo.Descripcion = lector.GetString(2);
                    nuevo.Estado = "Pendiente";


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


        public void Entregado(Int64 idpedido)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "spEntregado " + idpedido ;
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


        public List<PedidoPlato> CobrarPlatos(Int64 idMesa)
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
                comando.CommandText = "SpCobrarPlatos " + idMesa;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new PedidoPlato();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.Cantidad = lector.GetInt64(3);
                    nuevo.Plato = lector.GetString(1);
                    nuevo.Precio = Math.Round(lector.GetDecimal(2), 2);


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


        public List<PedidoBebida> CobrarBebidas(Int64 idMesa)
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
                comando.CommandText = "SpCobrarBebidas " + idMesa;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new PedidoBebida();
                    nuevo.Id = lector.GetInt64(0);
                    nuevo.Cantiadad = lector.GetInt64(4);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Precio = Math.Round(lector.GetDecimal(3), 2);
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

        public void CobrarPedidos(Int64 idmesa)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "SPcobrarMesa " + idmesa;
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

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



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AccesoDato
{
    public partial class SqlConsultas
    {

        public SqlConnection conexion = new SqlConnection("data source=LAB3-2-58\\SQLEXPRESS; initial catalog=RESTAURANTE; integrated security=sspi");
        public DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select C.IDPLATO,C.NOMBRE,C.PRECIO,C.TIPO,C.TENEDOR,C.CUCHILLO,C.CUCHARA  from Carta as C", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable Buscar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Negocio where Nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

      /*  public bool Insertar(string nombre, string precio, string tipo, string tenedor, string cuchillo, string cuchara)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO CARTA (NOMBRE,PRECIO,TIPO, TENEDOR,CUCHILLO,CUCHARA)VALUES( '{0}', {1}, '{2}', '{3}','{4}','{5}')", new string[] { nombre, precio, tipo, tenedor, cuchillo, cuchara }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }*/

        public bool Eliminar(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Negocio where ID = {0}", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        
    }
}

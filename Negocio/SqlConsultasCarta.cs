using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDato;

namespace Negocio
{
   public class SqlConsultasCarta
    {
        SqlConsultas consultas = new SqlConsultas();
        
        public bool Insertar(string nombre, string precio, string tipo, string tenedor, string cuchillo, string cuchara)
        {
          consultas.conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO CARTA (NOMBRE,PRECIO,TIPO, TENEDOR,CUCHILLO,CUCHARA)VALUES( '{0}', {1}, '{2}', '{3}','{4}','{5}')", new string[] { nombre, precio, tipo, tenedor, cuchillo, cuchara }), consultas.conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            consultas.conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar(string id, string nombre, string precio, string tipo, string tenedor, string cuchillo, string cuchara)
        {
            consultas.conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update carta set Nombre = '{0}',precio= {1} , tipo='{2}', tenedor= '{3}',cuchillo = '{4}',cuchara=  '{5}' where idplato = {6}", new string[] { nombre, precio, tipo, tenedor, cuchillo, cuchara, id }), consultas.conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            consultas.conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
    }
}
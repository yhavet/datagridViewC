using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public class CustomerController
    {
        private Conexion conexion = new Conexion();
        MySqlDataReader leer; 
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable mostrarventas()
        {
            comando.Connection = conexion.Conectar();
            comando.CommandText = "Select * from Ventas"; 
            leer = comando.ExecuteReader();

            tabla.Load(leer);
            return tabla;
        }

        public static int AgregarVentas(ListasVentas ObjVentas)
        {
            int retorno = 0;
            String consulta = "insert into ventas (Cantidad, Almacen) values('"
                + ObjVentas.Cantidad + "','" + +ObjVentas.Almacen+ "')";

            MySqlCommand cmd = new MySqlCommand(consulta, Conexion.ConectarMysql());

            retorno = cmd.ExecuteNonQuery();

            return retorno;
            
        }
    }
}

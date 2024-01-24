using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp3
{
    public class Conexion
    {
        private MySqlConnection conexion = new MySqlConnection("server=localhost; port=3306; username=root; password =; database=datagridview");

        public MySqlConnection Conectar()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
            }
            catch(Exception ex) 
            { 
                  MessageBox.Show("hubo un error en la conexion, intente otra vez" +ex.Message);
            }
            return conexion;
        }

        public MySqlConnection cerraConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();

            return conexion;
        }

        internal static MySqlConnection ConectarMysql()
        {
            throw new NotImplementedException();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.DAO
{
    public class Conexion
    {

        private string cad;

        protected MySqlConnection con;
        protected MySqlCommand cmd;
        protected MySqlDataAdapter da;
        protected DataTable dt;
        protected string query;
        protected MySqlConnection Open()
        {
            try
            {
                cad = "Server=localhost;Database=bqe9bjeut8gp5frtxwl6;Uid=root;" +
                    "Pwd=Root;Port=3306; ";
                con = new MySqlConnection(cad);
                con.Open();
                return con;
            }
            catch (Exception)
            {
                throw new Exception("Error al conectar con la base de datos");
            }
        }

        protected void Close()
        {
            try
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();

            }
            catch (Exception)
            {
                throw new Exception("Error al cerrar la conexion con la base de datos");
            }
        }

    }
}

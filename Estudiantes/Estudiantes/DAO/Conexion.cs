using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Estudiantes.DAO
{
    public class Conexion
    {
        private string cad;
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected string query;
        
        public Conexion()
        {
            cad = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        }


        protected void Open()
        {
            if (con == null)
                con = new SqlConnection(cad);

            if (con.State != ConnectionState.Open)
                con.Open();
        }

        protected void Close()
        {
            if (con != null && con.State == ConnectionState.Open)
                con.Close();
        }
    }
}

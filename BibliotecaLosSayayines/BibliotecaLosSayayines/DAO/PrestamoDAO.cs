using BibliotecaLosSayayines.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaLosSayayines.DAO
{
    public class PrestamoDAO : Conexion
    {
        public void Add(Prestamo ob)
        {
            Open();
            try
            {
                DateTime fechaEntrega = DateTime.Now.AddDays(20);

                query = "INSERT INTO prestamo (id_cliente, id_usuario, fecha_entrega, observaciones) " +
                        "VALUES (@id_cliente, @id_usuario, @fecha_entrega, @observaciones)";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id_cliente", ob.IdCliente);
                cmd.Parameters.AddWithValue("@id_usuario", ob.IdUsuario);
                cmd.Parameters.AddWithValue("@fecha_entrega", fechaEntrega);
                cmd.Parameters.AddWithValue("@observaciones", ob.Observaciones);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el préstamo: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }
        public List<Prestamo> GetAll()
        {
            Open();
            try
            {
                List<Prestamo> lista = new List<Prestamo>();

                query = "SELECT * FROM prestamo";
                cmd = con.CreateCommand();
                cmd.CommandText = query;

                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new Prestamo()
                    {
                        IdPrestamo = Convert.ToInt32(row["id_prestamo"]),
                        IdCliente = Convert.ToInt32(row["id_cliente"]),
                        IdUsuario = Convert.ToInt32(row["id_usuario"]),
                        FechaPrestamo = Convert.ToDateTime(row["fecha_prestamo"]),
                        FechaEntrega = row["fecha_entrega"] == DBNull.Value
                               ? DateTime.MinValue
                               : Convert.ToDateTime(row["fecha_entrega"]),
                        Observaciones = row["observaciones"].ToString()
                    });
                }

                cmd.Dispose();
                Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error, no se pudieron obtener los préstamos");
            }
            finally
            {
                Close();
            }
        }


        public Prestamo GetById(object id)
        {
            Open();
            try
            {
                Prestamo ob = null;

                query = "SELECT * FROM prestamo WHERE id_prestamo = @id";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ob = new Prestamo()
                    {
                        IdPrestamo = Convert.ToInt32(row["id_prestamo"]),
                        IdCliente = Convert.ToInt32(row["id_cliente"]),
                        IdUsuario = Convert.ToInt32(row["id_usuario"]),
                        FechaPrestamo = Convert.ToDateTime(row["fecha_prestamo"]),
                        FechaEntrega = row["fecha_entrega"] == DBNull.Value
                               ? DateTime.MinValue
                               : Convert.ToDateTime(row["fecha_entrega"]),
                        Observaciones = row["observaciones"].ToString()
                    };
                }

                cmd.Dispose();
                return ob;
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener el préstamo");
            }
            finally
            {
                Close();
            }
        }

    }
}

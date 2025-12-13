using BibliotecaLosSayayines.DAO.INTERFACE;
using BibliotecaLosSayayines.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.DAO
{
    public class DetallePrestamoDAO : Conexion
    {
        public void Add(DetallePrestamo ob)
        {
            Open();
            try
            {
                query = @"INSERT INTO detalle_prestamo 
                 (id_prestamo, id_libro, fecha_devolucion_real, estado)
                 VALUES (@id_prestamo, @id_libro, @fecha_devolucion_real, @estado)";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id_prestamo", ob.IdPrestamo);
                cmd.Parameters.AddWithValue("@id_libro", ob.IdLibro);

                // Manejo de posible fecha NULL
                if (ob.FechaDevolucionReal == DateTime.MinValue)
                    cmd.Parameters.AddWithValue("@fecha_devolucion_real", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@fecha_devolucion_real", ob.FechaDevolucionReal);

                // Si el estado está vacío, usar "prestado" por defecto
                var estado = string.IsNullOrWhiteSpace(ob.Estado) ? "prestado" : ob.Estado;
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el detalle de préstamo: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }
        public List<DetallePrestamo> GetAll()
        {
            Open();
            try
            {
                List<DetallePrestamo> lista = new List<DetallePrestamo>();

                query = "SELECT * FROM detalle_prestamo";
                cmd = con.CreateCommand();
                cmd.CommandText = query;

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new DetallePrestamo()
                    {
                        IdDetalle = Convert.ToInt32(row["id_detalle"]),
                        IdPrestamo = Convert.ToInt32(row["id_prestamo"]),
                        IdLibro = Convert.ToInt32(row["id_libro"]),

                        FechaDevolucionReal = row["fecha_devolucion_real"] == DBNull.Value
                                              ? DateTime.MinValue
                                              : Convert.ToDateTime(row["fecha_devolucion_real"]),

                        Estado = row["estado"].ToString()
                    });
                }

                return lista;
            }
            catch
            {
                throw new Exception("Error, no se pudieron obtener los detalles de préstamo");
            }
            finally
            {
                Close();
            }
        }
        public DetallePrestamo GetById(object id)
        {
            Open();
            try
            {
                DetallePrestamo ob = null;

                query = "SELECT * FROM detalle_prestamo WHERE id_detalle = @id";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ob = new DetallePrestamo()
                    {
                        IdDetalle = Convert.ToInt32(row["id_detalle"]),
                        IdPrestamo = Convert.ToInt32(row["id_prestamo"]),
                        IdLibro = Convert.ToInt32(row["id_libro"]),

                        FechaDevolucionReal = row["fecha_devolucion_real"] == DBNull.Value
                                              ? DateTime.MinValue
                                              : Convert.ToDateTime(row["fecha_devolucion_real"]),

                        Estado = row["estado"].ToString()
                    };
                }

                return ob;
            }
            catch
            {
                throw new Exception("Error al obtener el detalle de préstamo");
            }
            finally
            {
                Close();
            }
        }

    }



}
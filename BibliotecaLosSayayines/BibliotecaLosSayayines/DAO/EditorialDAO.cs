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
    public class EditorialDAO : Conexion,
        Iservice<Editorial>
    {
        public void Add(Editorial ob)
        {
            Open();
            try
            {
                query = "INSERT INTO editorial (nombre, pais, telefono) " +
                        "VALUES (@nombre, @pais, @telefono)";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", ob.nombre);
                cmd.Parameters.AddWithValue("@pais", ob.pais);
                cmd.Parameters.AddWithValue("@telefono", ob.telefono);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la editorial: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void Delete(object id)
        {
            Open();
            try
            {
                query = "DELETE FROM editorial WHERE id_editorial = @id_editorial";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_editorial", Convert.ToInt32(id));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw new Exception("Error, No se pudo eliminar la editorial");
            }
            finally
            {
                Close();
            }
        }

        public List<Editorial> GetAll()
        {
            Open();
            try
            {
                List<Editorial> ls = new List<Editorial>();
                query = "select * from editorial";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new Editorial()
                    {
                        id_editorial = Convert.ToInt32(x[0]),
                        nombre = x[1].ToString(),
                        pais = x[2].ToString(),
                        telefono = x[3].ToString()
                    });
                }
                cmd.Dispose();
                Close();
                return ls;
            }
            catch (Exception)
            {
                throw new Exception("Error, no se pudieron obtener las editoriales");
            }
        }

        public Editorial GetById(object id)
        {
            Open();
            try
            {
                Editorial ob = null;
                query = "select * from editorial where id_editorial =@id";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ob = new Editorial()
                    {
                        id_editorial = Convert.ToInt32(x[0]),
                        nombre = x[1].ToString(),
                        pais = x[2].ToString(),
                        telefono = x[3].ToString()
                    };
                }
                cmd.Dispose();
                Close();
                return ob;
            }
            catch (Exception)
            {
                throw new Exception("Error al conseguir el registro");
            }
            finally
            {
                Close();
            }
        }

        public void Update(Editorial ob)
        {
            Open();
            try
            {
                query = "UPDATE editorial SET nombre=@nombre, pais=@pais, telefono=@telefono " +
                        "WHERE id_editorial=@id_editorial";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@nombre", ob.nombre);
                cmd.Parameters.AddWithValue("@pais", ob.pais);
                cmd.Parameters.AddWithValue("@telefono", ob.telefono);
                cmd.Parameters.AddWithValue("@id_editorial", ob.id_editorial);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la editorial: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}

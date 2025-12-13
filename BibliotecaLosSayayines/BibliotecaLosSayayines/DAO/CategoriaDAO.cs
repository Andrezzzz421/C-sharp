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
    public class CategoriaDAO : Conexion,
        Iservice<Categoria>
    {
        public void Add(Categoria ob)
        {
            Open();
            try
            {
                query = "INSERT INTO categoria(nombre, descripcion) VALUES (@nombre, @descripcion)";
                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@nombre", ob.nombre);
                cmd.Parameters.AddWithValue("@descripcion", ob.descripcion);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la categoría: " + ex.Message);
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
                query = "DELETE FROM categoria WHERE id_categoria = @id_categoria";
                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id_categoria", Convert.ToInt32(id));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch
            {
                throw new Exception("Error, no se pudo eliminar la categoría");
            }
            finally
            {
                Close();
            }
        }

        public List<Categoria> GetAll()
        {
            Open();
            try
            {
                List<Categoria> ls = new List<Categoria>();
                query = "SELECT * FROM categoria";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new Categoria()
                    {
                        id_categoria = Convert.ToInt32(x[0]),
                        nombre = x[1].ToString(),
                        descripcion = x[2].ToString()
                    });
                }

                cmd.Dispose();
                return ls;
            }
            catch
            {
                throw new Exception("Error, no se pudieron obtener las categorías");
            }
            finally
            {
                Close();
            }
        }

        public Categoria GetById(object id)
        {
            {
                Open();
                try
                {
                    Categoria ob = null;
                    query = "SELECT * FROM categoria WHERE id_categoria = @id";

                    cmd = con.CreateCommand();
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow x in dt.Rows)
                    {
                        ob = new Categoria()
                        {
                            id_categoria = Convert.ToInt32(x[0]),
                            nombre = x[1].ToString(),
                            descripcion = x[2].ToString()
                        };
                    }

                    cmd.Dispose();
                    return ob;
                }
                catch
                {
                    throw new Exception("Error, no se pudo obtener la categoría");
                }
                finally
                {
                    Close();
                }
            }
        }

        public void Update(Categoria ob)
        {
            Open();
            try
            {
                query = "UPDATE categoria SET nombre=@nombre, descripcion=@descripcion " +
                        "WHERE id_categoria=@id_categoria";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@nombre", ob.nombre);
                cmd.Parameters.AddWithValue("@descripcion", ob.descripcion);
                cmd.Parameters.AddWithValue("@id_categoria", ob.id_categoria);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la categoría: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
    
}

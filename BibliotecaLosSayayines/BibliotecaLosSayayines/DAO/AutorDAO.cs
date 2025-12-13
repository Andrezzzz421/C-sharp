using BibliotecaLosSayayines.DAO.INTERFACE;
using BibliotecaLosSayayines.DTO;
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
    public class AutorDAO : Conexion,
        Iservice<Autor>
    {
        public void Add(Autor ob)
        {
            Open();
            try
            {
                query = "INSERT INTO autor (nombre, apellido, id_genero, pais_origen, fecha_nacimiento, biografia) " +
                        "VALUES (@nombre, @apellido, @id_genero, @pais_origen, @fecha_nacimiento, @biografia)";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@nombre", ob.nombre);
                cmd.Parameters.AddWithValue("@apellido", ob.apellido);
                cmd.Parameters.AddWithValue("@id_genero", ob.id_genero);
                cmd.Parameters.AddWithValue("@pais_origen", ob.pais_origen);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", ob.fehcanacimiento);
                cmd.Parameters.AddWithValue("@biografia", ob.biografia);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el autor: " + ex.Message);
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
                query = "Delete from autor where id_autor = @id_autor";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_autor", Convert.ToInt32(id));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw new Exception("Error,No se pudo eliminar el" +
                    "autor");
            }
            finally
            {
                Close();
            }
        }

        public List<Autor> GetAll()
        {
            Open();
            try
            {
                List<Autor> ls = new List<Autor>();
                query = "select * from autor";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new Autor()
                    {
                        id_autor = Convert.ToInt32(x[0]),
                        nombre = x[1].ToString(),
                        apellido = x[2].ToString(),
                        id_genero = Convert.ToInt32(x[3]),
                        pais_origen = x[4].ToString(),
                        fehcanacimiento = Convert.ToDateTime(x[5]),
                        biografia = x[6].ToString()
                    });
                }
                cmd.Dispose();
                Close();
                return ls;
            }
            catch (Exception)
            {
                throw new Exception("Error, no se pudieron obtener los autores");
            }
            finally
            {
                Close();
            }
        }

        public Autor GetById(object id)
        {
            Open();
            try
            {
                Autor ob = null;
                query = "select * from autor where id_autor =@id";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ob = new Autor()
                    {
                        id_autor = Convert.ToInt32(x[0]),
                        nombre = x[1].ToString(),
                        apellido = x[2].ToString(),
                        id_genero = Convert.ToInt32(x[3]),
                        pais_origen = x[4].ToString(),
                        fehcanacimiento = Convert.ToDateTime(x[5]),
                        biografia = x[6].ToString()
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

        public void Update(Autor ob)
        {
            Open();
            try
            {
                query = "UPDATE autor SET nombre=@nombre, apellido=@apellido, " +
                        "id_genero=@id_genero, pais_origen=@pais_origen, " +
                        "fecha_nacimiento=@fecha_nacimiento, biografia=@biografia " +
                        "WHERE id_autor=@id_autor";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@nombre", ob.nombre);
                cmd.Parameters.AddWithValue("@apellido", ob.apellido);
                cmd.Parameters.AddWithValue("@id_genero", ob.id_genero);
                cmd.Parameters.AddWithValue("@pais_origen", ob.pais_origen);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", ob.fehcanacimiento);
                cmd.Parameters.AddWithValue("@biografia", ob.biografia);
                cmd.Parameters.AddWithValue("@id_autor", ob.id_autor); // ← IMPORTANTE

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el autor: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }


        public List<AutorDTO> GetDTO()
        {
            List<AutorDTO> ls = new List<AutorDTO>();

            try
            {
                Open();

                query =
                    "SELECT a.id_autor, " +
                    "a.nombre, " +
                    "a.apellido, " +
                    "g.nombre AS genero, " +
                    "a.pais_origen, " +
                    "a.fecha_nacimiento, " +
                    "a.biografia " +
                    "FROM autor a " +
                    "INNER JOIN genero g ON a.id_genero = g.id_genero";

                cmd = con.CreateCommand();
                cmd.CommandText = query;
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new AutorDTO()
                    {
                        id_autor = Convert.ToInt32(x["id_autor"]),
                        nombre = x["nombre"].ToString(),
                        apellido = x["apellido"].ToString(),
                        nombregenero = x["genero"].ToString(),
                        pais_origen = x["pais_origen"].ToString(),
                        fecha_nacimiento = Convert.ToDateTime(x["fecha_nacimiento"]),
                        biografia = x["biografia"].ToString()
                    });
                }

                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los autores: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}

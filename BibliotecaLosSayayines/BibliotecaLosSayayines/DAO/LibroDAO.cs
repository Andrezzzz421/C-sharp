using BibliotecaLosSayayines.DAO.INTERFACE;
using BibliotecaLosSayayines.DTO;
using BibliotecaLosSayayines.HELPER;
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
    public class LibroDAO : Conexion,
        Iservice<Libro>
    {
        public void Add(Libro ob)
        {
            Open();
            try
            {
                query = "INSERT INTO libro (titulo, id_autor, id_editorial, id_categoria, anio_publicacion , descripcion , portada, estado) " +
                        "VALUES (@Titulo, @Id_autor, @Id_editorial, @Id_Categoria, @AnioPublicacion, @Descripcion, @Portada, @Estado)";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Titulo", ob.Titulo);
                cmd.Parameters.AddWithValue("@Id_autor", ob.Id_autor);
                cmd.Parameters.AddWithValue("@Id_editorial", ob.Id_editorial);
                cmd.Parameters.AddWithValue("@Id_Categoria", ob.Id_Categoria);
                cmd.Parameters.AddWithValue("@AnioPublicacion", ob.AnioPublicacion);
                cmd.Parameters.AddWithValue("@Descripcion", ob.Descripcion);
                if (ob.Portada != null)
                    cmd.Parameters.Add("@Portada", MySqlDbType.Blob).Value = ob.Portada;
                else
                    cmd.Parameters.Add("@Portada", MySqlDbType.Blob).Value = DBNull.Value;

                cmd.Parameters.AddWithValue("@Estado", ob.Estado);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el libro: " + ex.Message);
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
                query = "DELETE FROM libro WHERE id_libro = @Id_libro";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_libro", Convert.ToInt32(id));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw new Exception("Error,No se pudo eliminar el" +
                    "libro");
            }
            finally
            {
                Close();
            }
        }

        public List<Libro> GetAll()
        {
            Open();
            try
            {
                List<Libro> ls = new List<Libro>();
                query = "SELECT * FROM libro";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new Libro()
                    {
                        Id_libro = Convert.ToInt32(x[0]),
                        Titulo = x[1].ToString(),
                        Id_editorial = Convert.ToInt32(x[2]),
                        Id_autor = Convert.ToInt32(x[3]),
                        Id_Categoria = Convert.ToInt32(x[4]),
                        AnioPublicacion = Convert.ToInt32(x[5]),
                        Descripcion = x[6].ToString(),
                        Portada = x["portada"] != DBNull.Value ? (byte[])x["portada"] : null,
                        Estado = x[8].ToString()
                    });
                }
                cmd.Dispose();
                Close();
                return ls;
            }
            catch (Exception)
            {
                throw new Exception("Error,No se pudieron obtener los" +
                    "libros");
            }
            finally
            {
                Close();
            }
        }

        public Libro GetById(object id)
        {
            Open();
            try
            {
                Libro ob = null;
                query = "select * from libro where id_libro=@id";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ob = new Libro()
                    {
                        Id_libro = Convert.ToInt32(x[0]),
                        Titulo = x[1].ToString(),
                        Id_editorial = Convert.ToInt32(x[2]),
                        Id_autor = Convert.ToInt32(x[3]),
                        Id_Categoria = Convert.ToInt32(x[4]),
                        AnioPublicacion = Convert.ToInt32(x[5]),
                        Descripcion = x[6].ToString(),
                        Portada = x["portada"] != DBNull.Value ? (byte[])x["portada"] : null,
                        Estado = x[8].ToString()
                    };
                }
                cmd.Dispose();
                Close();
                return ob;
            }
            catch (Exception)
            {
                throw new Exception("Error al conseguir el resgistro");
            }
            finally
            {
                Close();
            }
        }

        public void Update(Libro ob)
        {
            Open();
            try
            {
                query = "UPDATE libro SET titulo=@Titulo, id_autor=@Id_autor, id_editorial=@Id_editorial, " +
                        "id_categoria=@Id_Categoria, anio_publicacion=@AnioPublicacion, descripcion=@Descripcion, " +
                        "portada=@Portada, estado=@Estado WHERE Id_libro=@Id_libro";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Titulo", ob.Titulo);
                cmd.Parameters.AddWithValue("@Id_autor", ob.Id_autor);
                cmd.Parameters.AddWithValue("@Id_editorial", ob.Id_editorial);
                cmd.Parameters.AddWithValue("@Id_Categoria", ob.Id_Categoria);
                cmd.Parameters.AddWithValue("@AnioPublicacion", ob.AnioPublicacion);
                cmd.Parameters.AddWithValue("@Descripcion", ob.Descripcion);
                if (ob.Portada != null)
                    cmd.Parameters.AddWithValue("@Portada", MySqlDbType.Blob).Value = ob.Portada;
                else
                    cmd.Parameters.AddWithValue("@Portada", MySqlDbType.Blob).Value = DBNull.Value;

                cmd.Parameters.AddWithValue("@Estado", ob.Estado);
                cmd.Parameters.AddWithValue("@Id_libro", ob.Id_libro);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el libro: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public List<LibroDTO> GetDTO()
        {
            List<LibroDTO> ls = new List<LibroDTO>();

            try
            {
                Open();
                query =
                    "SELECT l.id_libro, " +
                    "l.titulo, " +
                    "a.nombre AS autor, " +
                    "e.nombre AS editorial, " +
                    "c.nombre AS categoria, " +
                    "l.anio_publicacion, " +
                    "l.descripcion, " +
                    "l.portada, " +
                    "l.estado " +
                    "FROM libro l " +
                    "INNER JOIN autor a ON l.id_autor = a.id_autor " +
                    "INNER JOIN editorial e ON l.id_editorial = e.id_editorial " +
                    "INNER JOIN categoria c ON l.id_categoria = c.id_categoria";

                cmd = con.CreateCommand();
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow x in dt.Rows)
                {

                    ls.Add(new LibroDTO()
                    {
                        id_libro = Convert.ToInt32(x[0]),
                        titulo = x[1].ToString(),
                        Nombreautor = x[2].ToString(),
                        Nombreeditorial = x[3].ToString(),
                        Nombrecategoria = x[4].ToString(),
                        anio_publicacion = Convert.ToInt32(x[5]),
                        descripcion = x[6].ToString(),
                        Portada = x["Portada"] != DBNull.Value ? BSHelper.toImage((byte[])x["portada"]) : null,
                        Estado = x[8].ToString()
                    });
                }

                cmd.Dispose();
                Close();
                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los libros: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }


        public List<LibroDTO> FindByTitle(string name)
        {
            Open();
            try
            {
                name = $"%{name.ToUpper()}%";

                List<LibroDTO> ls = new List<LibroDTO>();

                query = @"SELECT l.id_libro, l.titulo,
                         a.nombre AS autor,
                         e.nombre AS editorial,
                         c.nombre AS categoria,
                         l.anio_publicacion,
                         l.descripcion,
                         l.portada,
                         l.estado
                  FROM libro l
                  INNER JOIN autor a ON l.id_autor = a.id_autor
                  INNER JOIN editorial e ON l.id_editorial = e.id_editorial
                  INNER JOIN categoria c ON l.id_categoria = c.id_categoria
                  WHERE UPPER(l.titulo) LIKE @name";

                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@name", name);

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new LibroDTO()
                    {
                        id_libro = Convert.ToInt32(x["id_libro"]),
                        titulo = x["titulo"].ToString(),
                        Nombreautor = x["autor"].ToString(),
                        Nombreeditorial = x["editorial"].ToString(),
                        Nombrecategoria = x["categoria"].ToString(),
                        anio_publicacion = Convert.ToInt32(x["anio_publicacion"]),
                        descripcion = x["descripcion"].ToString(),
                        Portada = x["portada"] != DBNull.Value ? BSHelper.toImage((byte[])x["portada"]) : null,
                        Estado = x["estado"].ToString()
                    });
                }

                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los libros: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public List<LibroDTO> FindByCategory(string category)
        {
            Open();
            try
            {
                category = $"%{category.ToUpper()}%";

                List<LibroDTO> ls = new List<LibroDTO>();

                query = @"SELECT l.id_libro, l.titulo,
                         a.nombre AS autor,
                         e.nombre AS editorial,
                         c.nombre AS categoria,
                         l.anio_publicacion,
                         l.descripcion,
                         l.portada,
                         l.estado
                  FROM libro l
                  INNER JOIN categoria c ON l.id_categoria = c.id_categoria
                  INNER JOIN autor a ON l.id_autor = a.id_autor
                  INNER JOIN editorial e ON l.id_editorial = e.id_editorial
                  WHERE UPPER(c.nombre) LIKE @category";

                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@category", category);

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new LibroDTO()
                    {
                        id_libro = Convert.ToInt32(x["id_libro"]),
                        titulo = x["titulo"].ToString(),
                        Nombreautor = x["autor"].ToString(),
                        Nombreeditorial = x["editorial"].ToString(),
                        Nombrecategoria = x["categoria"].ToString(),
                        anio_publicacion = Convert.ToInt32(x["anio_publicacion"]),
                        descripcion = x["descripcion"].ToString(),
                        Portada = x["portada"] != DBNull.Value ? BSHelper.toImage((byte[])x["portada"]) : null,
                        Estado = x["estado"].ToString()
                    });
                }

                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los libros: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }


        public List<LibroDTO> FindByAuthor(string author)
        {
            Open();
            try
            {
                author = $"%{author.ToUpper()}%";

                List<LibroDTO> ls = new List<LibroDTO>();

                query = @"SELECT l.id_libro, l.titulo,
                         a.nombre AS autor,
                         e.nombre AS editorial,
                         c.nombre AS categoria,
                         l.anio_publicacion,
                         l.descripcion,
                         l.portada,
                         l.estado
                  FROM libro l
                  INNER JOIN autor a ON l.id_autor = a.id_autor
                  INNER JOIN editorial e ON l.id_editorial = e.id_editorial
                  INNER JOIN categoria c ON l.id_categoria = c.id_categoria
                  WHERE UPPER(a.nombre) LIKE @author";

                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@author", author);

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new LibroDTO()
                    {
                        id_libro = Convert.ToInt32(x["id_libro"]),
                        titulo = x["titulo"].ToString(),
                        Nombreautor = x["autor"].ToString(),
                        Nombreeditorial = x["editorial"].ToString(),
                        Nombrecategoria = x["categoria"].ToString(),
                        anio_publicacion = Convert.ToInt32(x["anio_publicacion"]),
                        descripcion = x["descripcion"].ToString(),
                        Portada = x["portada"] != DBNull.Value ? BSHelper.toImage((byte[])x["portada"]) : null,
                        Estado = x["estado"].ToString()
                    });
                }

                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar por autor: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public List<LibroDTO> FindByPublisher(string publisher)
        {
            Open();
            try
            {
                publisher = $"%{publisher.ToUpper()}%";

                List<LibroDTO> ls = new List<LibroDTO>();

                query = @"SELECT l.id_libro, l.titulo,
                         a.nombre AS autor,
                         e.nombre AS editorial,
                         c.nombre AS categoria,
                         l.anio_publicacion,
                         l.descripcion,
                         l.portada,
                         l.estado
                  FROM libro l
                  INNER JOIN editorial e ON l.id_editorial = e.id_editorial
                  INNER JOIN autor a ON l.id_autor = a.id_autor
                  INNER JOIN categoria c ON l.id_categoria = c.id_categoria
                  WHERE UPPER(e.nombre) LIKE @publisher";

                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@publisher", publisher);

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new LibroDTO()
                    {
                        id_libro = Convert.ToInt32(x["id_libro"]),
                        titulo = x["titulo"].ToString(),
                        Nombreautor = x["autor"].ToString(),
                        Nombreeditorial = x["editorial"].ToString(),
                        Nombrecategoria = x["categoria"].ToString(),
                        anio_publicacion = Convert.ToInt32(x["anio_publicacion"]),
                        descripcion = x["descripcion"].ToString(),
                        Portada = x["portada"] != DBNull.Value ? BSHelper.toImage((byte[])x["portada"]) : null,
                        Estado = x["estado"].ToString()
                    });
                }

                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar editorial: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}

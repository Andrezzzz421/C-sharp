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
    public class GeneroDAO : Conexion,
        Iservice<Genero>
    {
        public void Add(Genero ob)
        {
            Open();
            try
            {
                query = "Insert into genero(nombre) values (@nombre)";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", ob.nombre);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar editorial" + ex.Message);
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
                query = "Delete from genero where id_genero = @id_genero";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_genero", Convert.ToInt32(id));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw new Exception("Error, No se pudo eliminar el genero");
            }
            finally
            {
                Close();
            }
        }

        public List<Genero> GetAll()
        {
            Open();
            try
            {
                List<Genero> ls = new List<Genero>();
                query = "Select * from genero";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new Genero()
                    {
                        id_genero = Convert.ToInt32(x[0]),
                        nombre = x[1].ToString()
                    });
                }
                cmd.Dispose();
                Close();
                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los generos: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public Genero GetById(object id)
        {
            Open();
            try
            {
                Genero ob = null;
                query = "Select * from genero where id_genero = @id_genero";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_genero", Convert.ToInt32(id));
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ob = new Genero()
                    {
                        id_genero = Convert.ToInt32(x[0]),
                        nombre = x[1].ToString()
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

        public void Update(Genero ob)
        {
            Open();
            try
            {
                query = "update genero set nombre = @nombre where id_genero = @id_genero";
                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@nombre", ob.nombre);
                cmd.Parameters.AddWithValue("@id_genero", ob.id_genero);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw new Exception("Error al actualizar el genero");
            }
            finally
            {
                Close();
            }
        }
    }
}

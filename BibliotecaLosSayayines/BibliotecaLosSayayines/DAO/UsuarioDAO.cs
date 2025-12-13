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
    public class UsuarioDAO : Conexion
    {

        private Usuario MapUsuario(DataRow dr)
        {
            return new Usuario
            {
                IdUsuario = Convert.ToInt32(dr["id_usuario"]),
                Nombre = dr["nombre"].ToString(),
                Apellido = dr["apellido"].ToString(),
                NombreUsuario = dr["usuario"].ToString(),
                Password = dr["password"].ToString(),
                Rol = dr["rol"].ToString(),
                Email = dr["email"].ToString(),
                Telefono = dr["telefono"].ToString(),
                Foto = dr["foto"] != DBNull.Value ? (byte[])dr["foto"] : null,
                Estado = Convert.ToBoolean(dr["estado"])
            };
        }
        public void Add(Usuario obj)
        {
            Open();
            try
            {
                query = @"INSERT INTO usuario (nombre, apellido, usuario, password, rol, email, telefono, foto, estado)
                          VALUES (@nombre, @apellido, @usuario, @pass, @rol, @correo, @tel, @foto, @estado)";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@usuario", obj.NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", obj.Password);
                cmd.Parameters.AddWithValue("@rol", obj.Rol);
                cmd.Parameters.AddWithValue("@correo", obj.Email);
                cmd.Parameters.AddWithValue("@tel", obj.Telefono);
                cmd.Parameters.Add("@foto", MySqlDbType.Blob).Value =
                     obj.Foto ?? (object)DBNull.Value;
                cmd.Parameters.AddWithValue("@estado", obj.Estado);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario: " + ex.Message);
            }
            finally { Close(); }
        }


        public void Delete(object id)
        {
            Open();
            try
            {
                query = "DELETE FROM usuario WHERE id_usuario = @id";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Error al eliminar usuario");
            }
            finally { Close(); }
        }


        public List<Usuario> GetAll()
        {
            Open();
            try
            {
                query = "SELECT * FROM usuario";
                da = new MySqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<Usuario> lista = new List<Usuario>();
                foreach (DataRow dr in dt.Rows)
                    lista.Add(MapUsuario(dr));

                return lista;
            }
            catch
            {
                throw new Exception("Error al obtener usuarios");
            }
            finally { Close(); }
        }

        public Usuario GetById(object id)
        {
            Open();
            try
            {
                query = "SELECT * FROM usuario WHERE id_usuario = @id";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? MapUsuario(dt.Rows[0]) : null;
            }
            catch
            {
                throw new Exception("Error al obtener usuario por ID");
            }
            finally { Close(); }
        }
        public void Update(Usuario obj)
        {
            Open();
            try
            {
                query = @"UPDATE usuario SET 
                              nombre = @nombre, apellido = @apellido, usuario = @usuario, 
                              password = @pass, rol = @rol, email = @correo, telefono = @tel,
                              foto = @foto, estado = @estado
                          WHERE id_usuario = @id";

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@usuario", obj.NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", obj.Password);
                cmd.Parameters.AddWithValue("@rol", obj.Rol);
                cmd.Parameters.AddWithValue("@correo", obj.Email);
                cmd.Parameters.AddWithValue("@tel", obj.Telefono);
                cmd.Parameters.Add("@foto", MySqlDbType.Blob).Value =
                     obj.Foto ?? (object)DBNull.Value;
                cmd.Parameters.AddWithValue("@estado", obj.Estado);
                cmd.Parameters.AddWithValue("@id", obj.IdUsuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario: " + ex.Message);
            }
            finally { Close(); }
        }

        public Usuario Login(string dato, string pass)
        {
            try
            {
                con = Open();

                query = @"SELECT id_usuario, nombre, apellido, usuario, password, rol, email, telefono, foto FROM usuario WHERE (usuario = @dato OR email = @dato) AND password = @pass AND estado = 1";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dato", dato);
                cmd.Parameters.AddWithValue("@pass", pass);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.IdUsuario = dr.GetInt32("id_usuario");
                    u.Nombre = dr.GetString("nombre");
                    u.Apellido = dr.GetString("apellido");
                    u.NombreUsuario = dr.GetString("usuario");
                    u.Password = dr.GetString("password");
                    u.Rol = dr.GetString("rol");
                    u.Email = dr.GetString("email");
                    u.Telefono = dr.GetString("telefono");
                    if (!dr.IsDBNull(dr.GetOrdinal("foto")))
                    {
                        u.Foto = (byte[])dr["foto"];
                    }
                    return u;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el login: " + ex.Message);
            }
            finally { con.Close(); }
        }

        public Usuario GetByUserOrEmail(string dato)
        {
            try
            {
                con = Open();
                query = @"SELECT * FROM usuario 
                          WHERE usuario = @dato OR email = @dato";

                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dato", dato);

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? MapUsuario(dt.Rows[0]) : null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar usuario: " + ex.Message);
            }
            finally { Close(); }
        }


        public bool UpdatePassword(string dato, string newPass)
        {
            try
            {
                con = Open();
                query = @"UPDATE usuario SET password = @newPass
                          WHERE usuario = @dato OR email = @dato";

                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newPass", newPass);
                cmd.Parameters.AddWithValue("@dato", dato);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la contraseña: " + ex.Message);
            }
            finally { Close(); }
        }
    }
}

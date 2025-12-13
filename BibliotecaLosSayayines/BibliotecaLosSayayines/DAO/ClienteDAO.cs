using BibliotecaLosSayayines.DAO.INTERFACE;
using BibliotecaLosSayayines.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.DAO
{
    public class ClienteDAO : Conexion,
        Iservice<Cliente>
    {
        public void Add(Cliente ob)
        {
            Open();
            try
            {
                query = "insert into cliente (nombre,apellido,documento,telefono,email,direccion,fecha_registro )" +
                    "values(@nombre,@apellido,@documento,@telefono,@email,@direccion,@fecharegistro)";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", ob.Nombre);
                cmd.Parameters.AddWithValue("@apellido", ob.Apellido);
                cmd.Parameters.AddWithValue("@documento", ob.Documento);
                cmd.Parameters.AddWithValue("@telefono", ob.Telefono);
                cmd.Parameters.AddWithValue("@email", ob.Correo);
                cmd.Parameters.AddWithValue("@direccion", ob.Telefono);
                cmd.Parameters.AddWithValue("@fecharegistro", ob.FechaRegistro);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message);
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
                query = "delete from cliente where id_cliente = @id_cliente";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(id));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw new Exception("Error, No se pudo eliminar el" +
                    "cliente");
            }
        }

        public List<Cliente> GetAll()
        {
            Open();
            try
            {
                List<Cliente> ls = new List<Cliente>();
                query = "select * from cliente";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ls.Add(new Cliente()
                    {
                        IdCliente = Convert.ToInt32(x[0]),
                        Nombre = x[1].ToString(),
                        Apellido = x[2].ToString(),
                        Documento = x[3].ToString(),
                        Telefono = x[4].ToString(),
                        Correo = x[5].ToString(),
                        Direccion = x[6].ToString(),
                        FechaRegistro = Convert.ToDateTime(x[7])
                    });
                }
                cmd.Dispose();
                Close();
                return ls;
            }
            catch (Exception)
            {
                throw new Exception("Error no se pudo obtener los cliente");
            }
            finally
            {
                Close();
            }
        }

        public Cliente GetById(object id)
        {
            Open();
            try
            {
                Cliente ob = null;
                query = "select * from cliente where id_cliente =@id";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow x in dt.Rows)
                {
                    ob = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(x[0]),
                        Nombre = x[1].ToString(),
                        Apellido = x[2].ToString(),
                        Documento = x[3].ToString(),
                        Telefono = x[4].ToString(),
                        Correo = x[5].ToString(),
                        Direccion = x[6].ToString(),
                        FechaRegistro = Convert.ToDateTime(x[7])
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

        public void Update(Cliente ob)
        {
            Open();
            try
            {
                query = "update cliente set nombre=@nombre,apellido=@apellido,documento=@documento,telefono=@telefono,email=@email,direccion=@direccion," +
                    "where id_cliente =@id_cliente";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", ob.Nombre);
                cmd.Parameters.AddWithValue("@apellido", ob.Apellido);
                cmd.Parameters.AddWithValue("@documento", ob.Documento);
                cmd.Parameters.AddWithValue("@telefono", ob.Telefono);
                cmd.Parameters.AddWithValue("@email", ob.Correo);
                cmd.Parameters.AddWithValue("@direccion", ob.Direccion);
                cmd.Parameters.AddWithValue("@id_cliente", ob.IdCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el cliente" + ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
    
}

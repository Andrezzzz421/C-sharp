using Estudiantes.DTO;
using Estudiantes.HELPER;
using Estudiantes.MODEL;
using Microsoft.Data.SqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.DAO
{
    public class EstudianteDAO: Conexion
    {

        public bool Add(Estudiante est)
        {
            try
            {
                Open();
                query = @"INSERT INTO Estudiante
                  (Documento, Nombre, Apellido, TipoSanguineo, Peso, Estatura, 
                   Minoria, Correo, IdCurso, Foto)
                  VALUES (@Documento, @Nombre, @Apellido, @TipoSanguineo, @Peso, 
                          @Estatura, @Minoria, @Correo, @IdCurso, @Foto)";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Documento", est.Documento);
                cmd.Parameters.AddWithValue("@Nombre", est.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", est.Apellido);
                cmd.Parameters.AddWithValue("@TipoSanguineo", est.TipoSanguineo);
                cmd.Parameters.AddWithValue("@Peso", est.Peso);
                cmd.Parameters.AddWithValue("@Estatura", est.Estatura);
                cmd.Parameters.AddWithValue("@Minoria", est.Minoria);
                cmd.Parameters.AddWithValue("@Correo", est.Correo);
                cmd.Parameters.AddWithValue("@IdCurso", est.IdCurso);

                if (est.Foto != null)
                    cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = est.Foto;
                else
                    cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = DBNull.Value;


                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                Close();
            }
        }


        public bool Update(Estudiante est)
        {
            try
            {
                Open();
                query = @"UPDATE Estudiante SET 
                   Documento=@Documento, Nombre=@Nombre, Apellido=@Apellido, 
                   TipoSanguineo=@TipoSanguineo, Peso=@Peso, Estatura=@Estatura, 
                   Minoria=@Minoria, Correo=@Correo, IdCurso=@IdCurso, Foto=@Foto
                  WHERE IdEstudiante=@IdEstudiante";

                using (cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@IdEstudiante", SqlDbType.Int).Value = est.IdEstudiante;
                    cmd.Parameters.Add("@Documento", SqlDbType.NVarChar, 50).Value = est.Documento;
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = est.Nombre;
                    cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = est.Apellido;
                    cmd.Parameters.Add("@TipoSanguineo", SqlDbType.NVarChar, 10).Value = est.TipoSanguineo;
                    cmd.Parameters.Add("@Peso", SqlDbType.Decimal).Value = est.Peso;
                    cmd.Parameters.Add("@Estatura", SqlDbType.Decimal).Value = est.Estatura;
                    cmd.Parameters.Add("@Minoria", SqlDbType.Bit).Value = est.Minoria;
                    cmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = est.Correo;
                    cmd.Parameters.Add("@IdCurso", SqlDbType.Int).Value = est.IdCurso;

                    if (est.Foto != null)
                        cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = est.Foto;
                    else
                        cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = DBNull.Value;


                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            finally
            {
                Close();
            }
        }


        public bool Delete(int id)
        {
            try
            {
                Open();
                query = "DELETE FROM Estudiante WHERE IdEstudiante=@Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                Close();
            }
        }

        public Estudiante GetById(int id)
        {
            Estudiante est = null;
            try
            {
                Open();
                query = "SELECT * FROM Estudiante WHERE IdEstudiante=@Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        est = new Estudiante
                        {
                            IdEstudiante = Convert.ToInt32(dr["IdEstudiante"]),
                            Documento = dr["Documento"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            TipoSanguineo = dr["TipoSanguineo"].ToString(),
                            Peso = Convert.ToDecimal(dr["Peso"]),
                            Estatura = Convert.ToDecimal(dr["Estatura"]),
                            Minoria = Convert.ToBoolean(dr["Minoria"]),
                            Correo = dr["Correo"].ToString(),
                            IdCurso = Convert.ToInt32(dr["IdCurso"]),
                            Foto = dr["Foto"] != DBNull.Value ? (byte[])dr["Foto"] : null
                        };
                    }
                }
            }
            finally
            {
                Close();
            }
            return est;
        }

        public List<Estudiante> GetAll()
        {
            List<Estudiante> lista = new List<Estudiante>();
            try
            {
                Open();
                query = "SELECT * FROM Estudiante";
                cmd = new SqlCommand(query, con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Estudiante
                        {
                            IdEstudiante = Convert.ToInt32(dr["IdEstudiante"]),
                            Documento = dr["Documento"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            TipoSanguineo = dr["TipoSanguineo"].ToString(),
                            Peso = Convert.ToDecimal(dr["Peso"]),
                            Estatura = Convert.ToDecimal(dr["Estatura"]),
                            Minoria = Convert.ToBoolean(dr["Minoria"]),
                            Correo = dr["Correo"].ToString(),
                            IdCurso = Convert.ToInt32(dr["IdCurso"]),
                            Foto = dr["Foto"] != DBNull.Value ? (byte[])dr["Foto"] : null
                        });
                    }
                }
            }
            finally
            {
                Close();
            }
            return lista;
        }

        public List<EstudianteDTO> GetDTO()
        {
            List<EstudianteDTO> lista = new List<EstudianteDTO>();

            try
            {
                Open();
                query = @"SELECT e.IdEstudiante, e.Documento, e.Nombre, e.Apellido, e.TipoSanguineo, 
                         e.Peso, e.Estatura, e.Minoria, e.Correo, e.Foto,
                         c.Nombre AS NombreCurso
                  FROM Estudiante e
                  INNER JOIN Curso c ON e.IdCurso = c.IdCurso";

                cmd = new SqlCommand(query, con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new EstudianteDTO
                        {
                            IdEstudiante = dr.GetInt32(dr.GetOrdinal("IdEstudiante")),
                            Documento = dr["Documento"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            TipoSanguineo = dr["TipoSanguineo"].ToString(),
                            Peso = Convert.ToDecimal(dr["Peso"]),
                            Estatura = Convert.ToDecimal(dr["Estatura"]),
                            Minoria = Convert.ToBoolean(dr["Minoria"]),
                            Correo = dr["Correo"].ToString(),
                            NombreCurso = dr["NombreCurso"].ToString(),
                            Foto = dr["Foto"] != DBNull.Value ? APHelper.toImage((byte[])dr["Foto"]) : null
                        });
                    }
                }
            }
            finally
            {
                Close();
            }

            return lista;
        }

        public List<EstudianteDTO> BuscarPorNombreoApellido(string filtro)
        {
            List<EstudianteDTO> lista = new List<EstudianteDTO>();

            try
            {
                Open();

                query = @"
            SELECT 
                e.IdEstudiante,
                e.Documento,
                e.Nombre,
                e.Apellido,
                e.TipoSanguineo,
                e.Peso,
                e.Estatura,
                e.Minoria,
                e.Correo,
                e.Foto,
                c.Nombre AS NombreCurso
            FROM Estudiante e
            INNER JOIN Curso c ON e.IdCurso = c.IdCurso
            WHERE e.Nombre LIKE @Filtro OR e.Apellido LIKE @Filtro";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        EstudianteDTO dto = new EstudianteDTO
                        {
                            IdEstudiante = dr.GetInt32(dr.GetOrdinal("IdEstudiante")),
                            Documento = dr["Documento"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            TipoSanguineo = dr["TipoSanguineo"].ToString(),
                            Peso = dr["Peso"] != DBNull.Value ? Convert.ToDecimal(dr["Peso"]) : 0,
                            Estatura = dr["Estatura"] != DBNull.Value ? Convert.ToDecimal(dr["Estatura"]) : 0,
                            Minoria = dr["Minoria"] != DBNull.Value && Convert.ToBoolean(dr["Minoria"]),
                            Correo = dr["Correo"].ToString(),
                            NombreCurso = dr["NombreCurso"].ToString(),
                            Foto = dr["Foto"] != DBNull.Value ? APHelper.toImage((byte[])dr["Foto"]) : null
                        };

                        lista.Add(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar estudiantes: " + ex.Message);
            }
            finally
            {
                Close();
            }

            return lista;
        }

        public List<EstudianteDTO> BuscarPorTipoSanguineo(string tipo)
        {
            List<EstudianteDTO> lista = new List<EstudianteDTO>();

            try
            {
                Open();
                query = @"SELECT e.IdEstudiante, e.Documento, e.Nombre, e.Apellido, e.TipoSanguineo,
                         e.Peso, e.Estatura, e.Minoria, e.Correo, e.Foto,
                         c.Nombre AS NombreCurso
                  FROM Estudiante e
                  INNER JOIN Curso c ON e.IdCurso = c.IdCurso
                  WHERE e.TipoSanguineo LIKE @tipo";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@tipo", "%" + tipo + "%");

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new EstudianteDTO
                        {
                            IdEstudiante = dr.GetInt32(dr.GetOrdinal("IdEstudiante")),
                            Documento = dr["Documento"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            TipoSanguineo = dr["TipoSanguineo"].ToString(),
                            Peso = Convert.ToDecimal(dr["Peso"]),
                            Estatura = Convert.ToDecimal(dr["Estatura"]),
                            Minoria = Convert.ToBoolean(dr["Minoria"]),
                            Correo = dr["Correo"].ToString(),
                            NombreCurso = dr["NombreCurso"].ToString(),
                            Foto = dr["Foto"] != DBNull.Value ? APHelper.toImage((byte[])dr["Foto"]) : null
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por tipo sanguíneo: " + ex.Message);
            }
            finally
            {
                Close();
            }

            return lista;
        }

    }
}


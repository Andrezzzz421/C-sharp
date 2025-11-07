using Estudiantes.MODEL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.DAO
{
    public class CursoDAO: Conexion
    {
        public void Add(Curso ob)
        {
            query = "INSERT INTO Curso (Nombre) VALUES (@p1)";
            Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", ob.Nombre);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void Update(Curso ob)
        {
            query = "UPDATE Curso SET Nombre = @p2 WHERE IdCurso = @p1";
            Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", ob.IdCurso);
            cmd.Parameters.AddWithValue("@p2", ob.Nombre);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void Delete(int id)
        {
            query = "DELETE FROM Curso WHERE IdCurso = @p1";
            Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.ExecuteNonQuery();
            Close();
        }

        public Curso GetById(int id)
        {
            query = "SELECT IdCurso, Nombre FROM Curso WHERE IdCurso = @p1";
            Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();

            Curso obj = null;
            if (dr.Read())
            {
                obj = new Curso
                {
                    IdCurso = dr.GetInt32(0),
                    Nombre = dr.GetString(1)
                };
            }
            dr.Close();
            Close();
            return obj;
        }

        public List<Curso> GetAll()
        {
            query = "SELECT IdCurso, Nombre FROM Curso";
            Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            List<Curso> lista = new List<Curso>();
            while (dr.Read())
            {
                lista.Add(new Curso
                {
                    IdCurso = dr.GetInt32(0),
                    Nombre = dr.GetString(1)
                });
            }
            dr.Close();
            Close();
            return lista;
        }
    }
}


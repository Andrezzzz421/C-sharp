using Estudiantes.DAO;
using Estudiantes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.HELPER
{
    public class APHelper
    {
        static CursoDAO cdao = new CursoDAO();
        static EstudianteDAO edao = new EstudianteDAO();

        public static byte[] toByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image toImage(byte[] b)
        {
            using (MemoryStream ms = new MemoryStream(b))
            {
                Image image = Image.FromStream(ms);
                return new Bitmap(image);
            }
        }

        public static EstudianteDTO ToDTO(int id)
        {
            var x = edao.GetById(id);
            if(x != null)
            {
                String nombre = cdao.GetById(x.IdCurso).Nombre;
                EstudianteDTO dto = new EstudianteDTO()
                {
                    IdEstudiante = x.IdEstudiante,
                    Documento = x.Documento,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    TipoSanguineo = x.TipoSanguineo,
                    Peso = x.Peso,
                    Estatura = x.Estatura,
                    Minoria = x.Minoria,
                    Correo = x.Correo,
                    NombreCurso = nombre,
                    Foto = x.Foto != null ? toImage(x.Foto) : null
                };
                return dto;
            }
            return null;
        }
    }
}

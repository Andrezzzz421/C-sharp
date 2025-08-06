using LabPOO.DAO;
using LabPOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO.Helpers
{
    public class WMHelper
    {
        private static LibroDAO dao = new LibroDAO();

        public static void Seed()
        {
            Libro ob1 = new Libro()
            {
                Id = 1,
                Titulo = "La divina comedia".ToUpper(),
                Autor = "Dante".ToUpper(),
                Genero = "Literatura Univeral".ToUpper(),
                Editorial = "Planeta".ToUpper(),
                Portada = "",
                AnioPublicacion = 1321,
                Sinopsis = "Alguien haciendo algo".ToUpper()
                
            };

            Libro ob2 = new Libro()
            {
                Id = 2,
                Titulo = "La celestina".ToUpper(),
                Autor = "Fernando de Rojas".ToUpper(),
                Genero = "Drama".ToUpper(),
                Editorial = "Castalia ediciones".ToUpper(),
                Portada = "",
                AnioPublicacion = 1499,
                Sinopsis = "otro haciendo algo mas".ToUpper()

            };

            dao.Add(ob1);
            dao.Add(ob2);
        }
    }
}

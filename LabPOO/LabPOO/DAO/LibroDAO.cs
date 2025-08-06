using LabPOO.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO.DAO
{
    public class LibroDAO
    {
        private static List<Libro> ls = new List<Libro>();

        public List<Libro> GetAll()
        {
            return ls;
        }
        public Libro? GetById(int id)
        {
            foreach (var x in ls)
            {
                if (x.Id == id) return x;
            }
            return null;
        }

        public void Add(Libro ob)
        {
            ls.Add(ob);

        }

        public void Update(Libro ob)
        {
            var x = GetById(ob.Id);
            if (x != null)
            {
                x.Titulo = ob.Titulo;
                x.Autor = ob.Autor;
                x.AnioPublicacion = ob.AnioPublicacion;
                x.Sinopsis = ob.Sinopsis;
                x.Genero = ob.Genero;
                x.Portada = ob.Portada; 
            }
        }

        public void Delete(int id)
        {
            var x = GetById(id);
            if(x != null)
                ls.Remove(x);
        }
    }
}

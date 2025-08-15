using EmpresaV1.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaV1.DAO
{
    public class CargoDAO
    {
        public static List<Cargo> carg = new List<Cargo>();

        public  List<Cargo> GetAll()
        {
            return carg;
        }

        public Cargo GetById(int id)
        {
            foreach (var c in carg)
            {
                if (c.Id == id) return c;

            }
            return null;
        }

        public void Add(Cargo car)
        {
            
            if (car.Id == 0)
            {
                car.Id = carg.Count > 0 ? carg.Max(c => c.Id) + 1 : 1;
            }

            var existente = GetById(car.Id);
            if (existente == null)
            {
                carg.Add(car);
            }
        }

        public void Update(Cargo car)
        {
            var c = GetById(car.Id);
            if (c != null)
            {
                c.Nombre = car.Nombre;
                c.Estado = car.Estado;
            }
            else
            {
                throw new Exception("No se encontró el cargo para actualizar");
            }
        }
        public void Delete(int id)
        {
            var c = GetById(id);
            if (c != null)
            {
                carg.Remove(c);
            }
            else
            {
                throw new Exception("No se encontró el cargo para eliminar");
            }
        }   
    }
}

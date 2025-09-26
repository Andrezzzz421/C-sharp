using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculo.Model;
using TallerVehiculo.Repositories;

namespace TallerVehiculo.DAO
{
    public class PropietarioDAO : ICrud<Propietario, int>, ICounter
    {
        private static List<Propietario> ls= new List<Propietario>();
        public bool Add(Propietario obj)
        {
            var m = ls.Where(x => x.Id == obj.Id).SingleOrDefault();
            if (m == null) { 
                ls.Add(obj);
                return true;
            }
            return false;
        }

        public int Count()
        {
            return ls.Count(x => x.Id != 0);
        }

        public int Count(DateTime dt, int d = 0)
        {
            var hoy = DateTime.Now;
            return ls.Count(x => x.FechaCreacion <=
            hoy.AddDays(-d) && x.Id != 0);
        }

        public bool Delete(int id)
        {
            VehiculoDAO vDAO = new VehiculoDAO();
            List<Vehiculo> list = vDAO.GetAll();
            var enc = list.Any(x => x.IdPropietario == id);
            if (!enc)
            {
                var pr = ls.Where((x) => x.Id == id).SingleOrDefault();
                ls.Remove(pr);
            }
            return !enc;
        }

        public List<Propietario> GetAll(int id = -1)
        {
            if(id == -1)
                return ls.OrderBy(x => x.Id).ToList();
            return ls.Where(x => x.Id != id).OrderBy(x => x.Id).ToList();
        }

        public Propietario GetById(int id)
        {
            return ls.Where(x => x.Id == id).SingleOrDefault();
        }

        public bool Update(Propietario obj)
        {
            var m = ls.Where(x => x.Id == obj.Id).SingleOrDefault();
            if(m != null)
            {
                ls.Remove(m);
                ls.Add(obj);
                return true;
            }
            return false;

        }
    }
}

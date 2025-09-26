using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculo.Repositories
{
    public interface ICrud<T,T2>
    {
        T GetById(T2 id);
        List<T> GetAll(int id=-1);
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(T2 id);
    }
}

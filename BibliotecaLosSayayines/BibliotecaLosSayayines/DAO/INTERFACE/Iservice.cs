using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.DAO.INTERFACE
{
    public interface Iservice<T>
          where T : class

    { 
        void Add(T ob);
        void Update(T ob);
        void Delete(object id);
        T GetById(object id);
        List<T> GetAll();

    }
}

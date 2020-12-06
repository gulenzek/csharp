using GUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Repository
{
    interface IRepository<T, ID> where T: IEntity
    {
        List<T> FindAll();

        T FindById(ID id);

        T Save(T t);

        List<T> FindWhere(Func<T, bool> t);
    }
}

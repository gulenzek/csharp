using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Entity;

namespace OrderManager.Repository
{
    public interface IRepository<T, ID> where T: class, IEntity, new()
    {
        List<T> FindAll();
        T FindById(ID id);
        T Save(T entity);
        void deleteById(ID id);
        void delete(T entity);
    }
}

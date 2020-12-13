using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Entity;

namespace OrderManager.Repository
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}

using GUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Repository
{
    interface IProductRepository : IRepository<Product, int>
    {
    }
}

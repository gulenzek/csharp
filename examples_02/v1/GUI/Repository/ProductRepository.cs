using GUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Repository
{
    class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        private int _idCounter = 0;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public List<Product> FindAll()
        {
            return _products;
        }

        public Product FindById(int id)
        {
            return _products.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Product> FindWhere(Func<Product, bool> t)
        {
            throw new NotImplementedException();
        }

        public Product Save(Product t)
        {
            if(t.Id == 0)
            {
                t.Id = ++_idCounter;
                _products.Add(t);
            }
            else if(t.Id > 0)
            {
                Product product = FindById(t.Id);
                product.Name = t.Name;
                product.StockAmount = t.StockAmount;
                product.UnitPrice = t.UnitPrice;

                t = product;
            }

            return t;

            

        }
    }
}

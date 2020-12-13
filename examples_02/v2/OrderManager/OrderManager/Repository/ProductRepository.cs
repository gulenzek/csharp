using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Entity;

namespace OrderManager.Repository
{
    class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>();
        private int _idCounter = 0;

        public void delete(Product entity)
        {
            deleteById(entity.Id);
        }

        public void deleteById(int id)
        {
            Product product = FindById(id);
            _products.Remove(product);
        }

        public List<Product> FindAll()
        {
            return _products;
        }

        public Product FindById(int id)
        {
            return _products.Where(p => p.Id == id).FirstOrDefault();
        }

        public Product Save(Product entity)
        {
           if(entity.Id == 0)
            {
                entity.Id = ++_idCounter;
                _products.Add(entity);
            }
           else
            {
                Product product = FindById(entity.Id);
                product.Name = entity.Name;
                product.UnitPrice = entity.UnitPrice;
                product.StockAmount = entity.StockAmount;

                entity = product;
            }

            return entity;
        }
    }
}

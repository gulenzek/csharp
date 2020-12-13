using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Entity;

namespace OrderManager.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private List<Order> _orders = new List<Order>();
        private int _idCounter = 0;

        public void delete(Order entity)
        {
            deleteById(entity.Id);
        }

        public void deleteById(int id)
        {
            Order order = FindById(id);
            _orders.Remove(order);
        }

        public List<Order> FindAll()
        {
            return _orders;
        }

        public Order FindById(int id)
        {
            return _orders.Where(order => order.Id == id).FirstOrDefault();
        }

        public Order Save(Order entity)
        {
            if(entity.Id == 0)
            {
                entity.Id = ++_idCounter;
                _orders.Add(entity);
                entity.Person.Orders.Add(entity);
                entity.Product.Orders.Add(entity);
            }
            else
            {
                Order order = FindById(entity.Id);
                order.Person = entity.Person;
                order.Product = entity.Product;
                order.Amount = entity.Amount;

                entity = order;
            }

            return entity;
        }
    }
}

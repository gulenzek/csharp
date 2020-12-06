using GUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Repository
{
    class OrderRepository : IOrderRepository
    {
        private List<Order> _orders;
        private int idCounter = 0;

        public OrderRepository()
        {
            _orders = new List<Order>();
        }

        public List<Order> FindAll()
        {
            return _orders;
        }

        public Order FindById(int id)
        {
            return _orders.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Order> FindWhere(Func<Order, bool> t)
        {
            throw new NotImplementedException();
        }

        public Order Save(Order t)
        {
            if(t.Id == 0)
            {
                t.Id = ++idCounter;
                _orders.Add(t);
            }
            else if(t.Id > 0)
            {
                Order order = FindById(t.Id);
                order.Person = t.Person;
                order.Product = t.Product;
                order.Amount = t.Amount;

                t = order;
            }

            return t;
        }
    }
}

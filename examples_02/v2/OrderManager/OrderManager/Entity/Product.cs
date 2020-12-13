using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Entity
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int StockAmount { get; set; }
        public double UnitPrice { get; set; }
        public IList<Order> Orders { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Entity
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Person Person { get; set; }
        public int Amount { get; set; }
    }
}

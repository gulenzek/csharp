using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Entity
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String  LastName { get; set; }
        public Gender Gender { get; set; }
        public IList<Order> Orders { get; set; }
    }
}

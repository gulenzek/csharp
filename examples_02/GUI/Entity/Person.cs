using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Entity
{
    class Person : IEntity
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Gender? Gender { get; set; }

        public override string ToString()
        {
            return $"{Id} => {FirstName} {LastName}";
        }
    }
}

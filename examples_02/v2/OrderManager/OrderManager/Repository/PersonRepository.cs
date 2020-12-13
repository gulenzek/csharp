using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Entity;

namespace OrderManager.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> _people = new List<Person>();
        private int _idCounter = 0;

        public void delete(Person entity)
        {
            deleteById(entity.Id);
        }

        public void deleteById(int id)
        {
            Person person = FindById(id);
            _people.Remove(person);
        }

        public List<Person> FindAll()
        {
            return _people;
        }

        public Person FindById(int id)
        {
            return _people.Where(p => p.Id == id).FirstOrDefault();
        }

        public Person Save(Person t)
        {
            if(t.Id == 0)
            {
                t.Id = ++_idCounter;
                _people.Add(t);
            }
            else
            {
                Person person = _people.Where(p => p.Id == t.Id).FirstOrDefault();
                person.FirstName = t.FirstName;
                person.LastName = t.LastName;
                person.Orders = t.Orders;
                person.Gender = t.Gender;

                t = person;
            }

            return t;

        }
    }
}

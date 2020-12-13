using GUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Repository
{
    class PersonRepository : IPersonRepository
    {

        private List<Person> _persons;
        private int _idCounter = 0;

        public PersonRepository()
        {
            _persons = new List<Person>();
        }

        public List<Person> FindAll()
        {
            return _persons;
        }

        public Person FindById(int id)
        {
            return _persons.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Person> FindWhere(Func<Person, bool> t)
        {
            return _persons.Where(t).ToList();
        }

        public Person Save(Person t)
        {
            if(t.Id == 0)
            {
                t.Id = ++_idCounter;
                _persons.Add(t);
            }
            else if(t.Id > 0) {
                Person person = FindById(t.Id);
                person.FirstName = t.FirstName;
                person.LastName = t.LastName;
                person.Gender = t.Gender;

                t = person;
            }
            

            return t;

        }
    }
}

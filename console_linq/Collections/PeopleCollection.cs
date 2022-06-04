using console_linq.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Collections
{
    //public class PeopleCollection : IEnumerable<Person>
    public class PeopleCollection : IEnumerable<Person>, ICollection<Person>
    {
        private readonly List<Person> _people = new List<Person>();

        public int Count => _people.Count();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void AddRange(IEnumerable<Person> people)
        {
            _people.AddRange(people);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Person item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator <Person> GetEnumerator()
        {
            return _people.GetEnumerator();
        }

        public bool Remove(Person item)
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Person>) _people).GetEnumerator();
        }
    }
}

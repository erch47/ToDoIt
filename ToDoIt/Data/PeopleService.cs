using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoIt.Models;

namespace ToDoIt.Data
{
    public class PeopleService
    {
        private static Person[] persons = new Person[0];


        public int size()
        {
            return persons.Length;
        }


        public Person[] FindAll()
        {
            return persons;
        }


        public void Clear() 
        {
            persons = Array.Empty<Person>();
        }

        public Person FindById(int personId)
        {
            Person? person = null;
            foreach(Person p in persons)
            {
                if(p.PersonId == personId)
                {
                    person = p;
                }
            }            
            return person;
        }


        public Person CreatePerson(string firstName, string lastName)
        {
            Array.Resize(ref persons, persons.Length + 1);
            persons[^1] = new Person(firstName, lastName, PersonSequencer.NextPersonId());
            return persons[^1];
        }
    }
}

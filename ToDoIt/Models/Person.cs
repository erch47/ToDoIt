using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoIt.Models
{
    public class Person
    {
        private readonly int id;
        private string firstName;
        private string lastName;


        public Person(int id)
        {
            this.id = id;
        }


        public Person(int id, string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }


        public int PersonId
        {
            get { return id; }
        }


        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (!string.IsNullOrEmpty(value) || value.Length > 0)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
            }              
        }


        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value) || value.Length > 0)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
            }
        }
    }
}

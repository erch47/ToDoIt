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


        public Person(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be empty.");
                }
                else
                {
                    firstName = value;
                }
            }              
        }


        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be empty.");
                }
                else
                {
                    lastName = value;
                }
            }
        }
    }
}

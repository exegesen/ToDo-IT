using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("ToDo-IT-Test")]

namespace ToDo_IT.Model
{
    internal class Person
    {
        private readonly int personID;

        private string firstName;
        public string FirstName

        {
            get { 
                return firstName; 
            }
            set {
                if (value != null && value != string.Empty)
                {
                    firstName = value;
                }
                else {
                    throw new ArgumentException();
                }
            }
        }

        public string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value != null && value != string.Empty)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Person(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

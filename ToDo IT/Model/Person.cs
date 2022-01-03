using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_IT.Model
{
    internal class Person
    {
        private readonly int personID;

        private String FirstName

        {
            get { 
                return FirstName; 
            }
            set {
                if (value != null && value != string.Empty)
                {
                    FirstName = value;
                }
                else {
                    throw new ArgumentException();
                }
            }
        }
        public String LastName;

        public Person(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}

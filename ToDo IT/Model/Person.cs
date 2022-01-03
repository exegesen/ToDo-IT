using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_IT.Model
{
    internal class Person
    {
        private readonly int personID;
        private String firstName
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
        private String lastName;

        public Person() { 
        
        }

    }
}

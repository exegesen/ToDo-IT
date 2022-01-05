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
        public int PersonID { 
        get => personID;
        }
        private String firstName;
        public String FirstName {
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
        public String LastName
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

        public Person(int id, string firstName, string lastName) 
        {
            this.personID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

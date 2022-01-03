using System;
using System.Collections.Generic;
using System.Text;
using ToDo_IT.Model;

namespace ToDo_IT.Data
{
    internal class People
    {
        private static Person[] person = new Person[0];
        public int Size() { 
            return person.Length;
        }

        public Person[] FindAll() {
            return person;
        }

        public Person FindById(int personId) {
            /*d.Add a method 
             * public Person FindById(int personId)
             * that return the person that has a matching personId 
             * as the passed in parameter.*/
            return null;
        }

        public void Clear() { 
        
        }
    }
}

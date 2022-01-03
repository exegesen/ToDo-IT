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
        
        }

        public Person FindById(int personId) { 
        
        }

        public void Clear() { 
        
        }
    }
}

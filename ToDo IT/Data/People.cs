using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ToDo_IT.Model;
[assembly: InternalsVisibleTo("ToDo-IT-Test")]

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
            foreach (Person p in person) {
                if (p.PersonID == personId) { 
                    return p;
                }
            }
            return null;
        }

        public void Clear() {
            person = new Person[0];// Change this probably
        }
        internal People() { 
        
        }

        public Person newPerson(String firstName, String lastName) {
            int nextId = PersonSequencer.nextPersonID();
            Person p = new Person(nextId, firstName, lastName);
            Array.Resize(ref person, person.Length + 1);
                
            person[nextId - 1] = p;

            return p;
        }
        public Person[] removePerson(int personId) {
            Person[] p = new Person[person.Length - 1];

            int i;
            int tempIndex = 0;
            for (i = 0; i < person.Length; i++)
            {
                if (person[i].PersonID != personId)
                {
                    p[tempIndex] = person[i];
                    tempIndex++;
                }
            }
            
            person = p;
            return p;
        }

    }
}

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
            Person p = new Person(firstName,lastName);
            Person[] newArray = new Person[person.Length+1];
            for (int i = 0; i < person.Length; i++) { 
                newArray[i] = person[i];
            } // copy the old array into the new array
            newArray[person.Length] = p;
            person = newArray;
            return p;
        
        }
        public Person[] removePerson(int personId) {
            Person[] p = new Person[person.Length - 1];
            int i;
            for (i = 0; i < person.Length; i++)
            {
                if (person[i].PersonID == personId)
                {
                    break;
                }
            }
            int j;
            for (j = 0; j < i; j++)
            {
                p[j] = person[j];
            }
            for (j = i + 1; j < person.Length; j++)
            {
                p[j] = person[j];
            }
            person = p;
            return p;
        }

    }
}

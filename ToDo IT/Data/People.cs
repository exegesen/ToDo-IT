﻿using System;
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
            Person p = new Person(nextId, firstName,lastName);
            Array.Resize(ref person, person.Length + 1);
            
            for (int i = 0; i < person.Length; i++) { 
                person[i] = p;
            }

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

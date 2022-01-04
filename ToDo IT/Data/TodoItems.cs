using System;
using System.Collections.Generic;
using System.Text;
using ToDo_IT.Model;

namespace ToDo_IT.Data
{
    internal class TodoItems
    {
        private static Todo[] todo = new Todo[0];
        public int Size()
        {
            return todo.Length;
        }
        public Todo[] FindAll()
        {
            return todo;
        }
        public void Clear()
        {
            todo = new Todo[0];// Change this probably
        }
        private TodoItems() { 
        
        }
        public Todo newTodo(int id, String description)
        {
            Todo t = new Todo(id, description);
            Todo[] newArray = new Todo[todo.Length + 1];
            for (int i = 0; i < todo.Length; i++)
            {
                newArray[i] = todo[i];
            } // copy the old array into the new array
            newArray[todo.Length] = t;
            todo = newArray;
            return t;

        }
        public Person FindById(int personId)
        {
            //TODO NOT IMPLEMENTED
            return null;
        }

        
        

    
        public Todo[] FindByDoneStatus(bool doneStatus) {
            int arrsize = 0;
            foreach (Todo t in todo) {
                if (t.done == doneStatus) {
                    arrsize++;
                }
            }
            Todo[] newArray = new Todo[arrsize];
            for (int i = 0; i < arrsize; i++) {
                if (todo[i].done == doneStatus)
                {
                    newArray[i] = todo[i];
                }
            }
            return newArray;

        }
        public Todo[] FindByAssignee(int personId) {
            int arrsize = 0;
            foreach (Todo t in todo)
            {
                if (t.Assignee.PersonID == personId)
                {
                    arrsize++;
                }
            }
            Todo[] newArray = new Todo[arrsize];
            for (int i = 0; i < arrsize; i++)
            {
                if (todo[i].Assignee.PersonID == personId)
                {
                    newArray[i] = todo[i];
                }
            }
            return newArray;
        }
        public Todo[] FindByAssignee(Person assignee) { 
        
        }
        public Todo[] FindUnassignedTodoItems() { 
        
        }
    }
}

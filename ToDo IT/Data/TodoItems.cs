using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ToDo_IT.Model;
[assembly: InternalsVisibleTo("ToDo-IT-Test")]

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
            todo = new Todo[0];
        }
        public TodoItems() { 
        
        }
        public Todo newTodo(String description)
        {
            int nextId = TodoSequencer.nextTodoID();
            Todo t = new Todo(nextId, description);
            Array.Resize(ref todo, todo.Length + 1);
            
            todo[nextId - 1] = t;

            return t;
        }
        public Todo[] removeTodo(int todoId)
        {
            Todo[] t = new Todo[todo.Length - 1];

            int i;
            int tempIndex = 0;
            for (i = 0; i < todo.Length; i++)
            {
                if (todo[i].TodoID != todoId)
                {
                    t[tempIndex] = todo[i];
                    tempIndex++;
                }
            }
            
            todo = t;
            return t;
        }
        public Todo FindById(int todoId)
        {
            foreach (Todo t in todo)
            {
                if (t.TodoID == todoId)
                {
                    return t;
                }
            }
            return null;
        }

        public Todo[] FindByDoneStatus(bool doneStatus) {
            int arrsize = 0;
            foreach (Todo t in todo) {
                if (t.Done == doneStatus) {
                    arrsize++;
                }
            }
            Todo[] newArray = new Todo[arrsize];

            int tempIndex = 0;
            for (int i = 0; i < todo.Length; i++) {
                if (todo[i].Done == doneStatus)
                {
                    newArray[tempIndex] = todo[i];
                    tempIndex++;
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
            int arrsize = 0;
            foreach (Todo t in todo)
            {
                if (t.Assignee.Equals(assignee))
                {
                    arrsize++;
                }
            }
            Todo[] newArray = new Todo[arrsize];
            for (int i = 0; i < arrsize; i++)
            {
                if (todo[i].Assignee.Equals(assignee))
                {
                    newArray[i] = todo[i];
                }
            }
            return newArray;
        }
        public Todo[] FindUnassignedTodoItems() {
            int arrsize = 0;
            foreach (Todo t in todo)
            {
                if (t.Assignee == null)
                {
                    arrsize++;
                }
            }
            Todo[] newArray = new Todo[arrsize];

            int tempIndex = 0;
            for (int i = 0; i <= arrsize; i++)
            {
                if (todo[i].Assignee == null)
                {
                    newArray[tempIndex] = todo[i];
                    tempIndex++;
                }
            }
            return newArray;
        }

    }
}

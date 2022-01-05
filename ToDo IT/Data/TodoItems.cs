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
        public Todo newTodo(int id, String description)
        {
            int nextId = TodoSequencer.nextTodoID();
            Todo t = new Todo(nextId, description);
            Array.Resize(ref todo, todo.Length + 1);

            for (int i = 0; i < todo.Length; i++)
            {
                todo[i] = t;
            }

            return t;
        }
        public Todo[] removeTodo(int todoId)
        {
            Todo[] t = new Todo[todo.Length - 1];
            int i;
            for (i = 0; i < todo.Length; i++)
            {
                if (todo[i].TodoID == todoId)
                {
                    break;
                }
            }
            int j;
            for (j = 0; j < i; j++)
            {
                t[j] = todo[j];
            }
            for (j = i+1; j < todo.Length; j++)
            {
                t[j] = todo[j];
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
            for (int i = 0; i < arrsize; i++) {
                if (todo[i].Done == doneStatus)
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
                if (t.Assignee.Equals(null))
                {
                    arrsize++;
                }
            }
            Todo[] newArray = new Todo[arrsize];
            for (int i = 0; i < arrsize; i++)
            {
                if (todo[i].Assignee.Equals(null))
                {
                    newArray[i] = todo[i];
                }
            }
            return newArray;
        }

    }
}

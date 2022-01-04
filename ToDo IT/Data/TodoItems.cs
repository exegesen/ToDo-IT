﻿using System;
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
            todo = new Todo[0];
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
        public Todo removeTodo(int todoId) { 
        
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

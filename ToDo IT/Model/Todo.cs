using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("ToDo-IT-Test")]

namespace ToDo_IT.Model
{
    internal class Todo
    {
        private readonly int todoId;
        public int TodoId 
        { 
            get 
            {
                return todoId;
            } 
        }
        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        private bool done;
        private Person assignee;

        public Todo(int todoId, string description) 
        {
            this.todoId = todoId;
            this.description = description;
        }
    }
}

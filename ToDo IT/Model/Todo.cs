using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_IT.Model
{
    internal class Todo
    {
        public readonly int todoId;
        private String description;
        public bool done { get; private set; }
        private Person assignee;

        public Todo(int todoId, String description) {
            this.todoId = todoId;
            this.description = description;
        
        }
    }
}

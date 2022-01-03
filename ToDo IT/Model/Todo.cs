using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_IT.Model
{
    internal class Todo
    {
        private readonly int todoId;
        private String description;
        private bool done;
        private Person assignee;

        public Todo(int todoId, String description) {
            this.todoId = todoId;
            this.description = description;
        
        }
    }
}

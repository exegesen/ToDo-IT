using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_IT.Model
{
    internal class Todo
    {
        private readonly int todoId;
        public int TodoID
        {
            get => TodoID;

        }
        private String description;
        private bool done;
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties
        public bool Done {
            get => done;
        }

        private Person assignee;
        public Person Assignee {
            get => assignee;
        }

        public Todo(int todoId, String description) {
            this.todoId = todoId;
            this.description = description;
        
        }
    }
}

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

        public int TodoID
        {
            get => todoId;

        }
        private String description;
        public string Description
        {
            get => description;
            set => description = value;
        }

        }
        private bool done;
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties
        public bool Done {
            get => done;
        }

        private Person assignee;
        public Person Assignee {
            get => assignee;
        }

        public Todo(int todoId, string description) 
        {
            this.todoId = todoId;
            this.description = description;
        }
    }
}

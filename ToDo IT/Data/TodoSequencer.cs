using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_IT.Data
{
    
    internal class TodoSequencer
    {
        private static int todoID = 0;
        static int nextTodoID()
        {
            return todoID++;
        }
        static void reset()
        {
            todoID = 0;
        }
    }
}

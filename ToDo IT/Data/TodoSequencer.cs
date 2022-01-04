using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("ToDo-IT-Test")]

namespace ToDo_IT.Data
{
    internal class TodoSequencer
    {
        private static int todoID = 0;
        internal static int nextTodoID()
        {
            return ++todoID;
        }
        internal static void reset()
        {
            todoID = 0;
        }
    }
}

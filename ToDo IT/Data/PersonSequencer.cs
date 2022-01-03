using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_IT.Data
{
    internal class PersonSequencer
    {
        private static int personID = 0;
        static int nextPersonID() { 
            return personID++;
        }
        static void reset()
        {
            personID = 0;
        }
    }
}

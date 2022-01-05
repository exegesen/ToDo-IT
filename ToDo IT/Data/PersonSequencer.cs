using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("ToDo-IT-Test")]

namespace ToDo_IT.Data
{
    internal class PersonSequencer
    {
        private static int personID = 0;
        
        internal static int nextPersonID() 
        {
            return ++personID;
        }
        internal static int reset()
        {
            personID = 0;
            return personID;
        }
    }
}

using System;
using ToDo_IT.Data;
using ToDo_IT.Model;

namespace ToDo_IT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People pl = new People();
            TodoItems tl = new TodoItems();

            Person p1 = pl.newPerson("testFirstName1", "testLastName1");
            Person p2 = pl.newPerson("testFirstName2", "testLastName2");
            Person p3 = pl.newPerson("testFirstName3", "testLastName3");

            Console.WriteLine(p1.PersonID + " " + p1.FirstName + " " + p1.LastName);
            Console.WriteLine(p2.PersonID + " " + p2.FirstName + " " + p2.LastName);
            Console.WriteLine(p3.PersonID + " " + p3.FirstName + " " + p3.LastName);

            Todo t1 = tl.newTodo( "testTodo1");
            Todo t2 = tl.newTodo( "testTodo2");
            Todo t3 = tl.newTodo( "testTodo3");

            Console.WriteLine(t1.TodoID + " " + t1.Description);
            Console.WriteLine(t2.TodoID + " " + t2.Description);
            Console.WriteLine(t3.TodoID + " " + t3.Description);
        }
    }
}

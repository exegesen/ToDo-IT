using System;
using System.Collections.Generic;
using System.Text;
using ToDo_IT.Model;
using Xunit;

namespace ToDo_IT_Test.ModelTest
{
    public class TodoTest
    {
        [Fact]
        public void TodoClassTest()
        {
            string expectedIdAndDescription = 1  + " testDescription";

            Todo testTodo = new Todo(1, "testDescription");

            Assert.Equal(expectedIdAndDescription, testTodo.TodoID + " " + testTodo.Description);
        }
    }
}

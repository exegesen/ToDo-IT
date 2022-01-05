using System;
using System.Collections.Generic;
using System.Text;
using ToDo_IT.Data;
using ToDo_IT.Model;
using Xunit;

namespace ToDo_IT_Test.DataTest
{
    public class TodoItemsTest
    {
        TodoItems sut = new TodoItems();

        [Fact]
        public void ReturnsTheLegthOfTheArray()
        {
            sut.newTodo(1, "testDescription");
            int expectedArrayLength = 1;

            int actualArrayLength = sut.Size();

            Assert.Equal(expectedArrayLength, actualArrayLength);
        }

        [Fact]
        public void ReturnsTodoArray()
        {
            sut.newTodo(1, "testDescription");
            Todo[] expectedTodoArray = { new Todo(1, "testDescription") };
            Todo[] actualTodoArray = sut.FindAll();

            int expected = expectedTodoArray[0].TodoID;
            int actual = actualTodoArray[0].TodoID;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsTodoIfFindsATodo()
        {
            sut.newTodo(1, "testDescription");

            string expectedTodo = "1 testDescription";

            Todo actualTodo = sut.FindById(1);

            Assert.Equal(expectedTodo, actualTodo.TodoID + " " + actualTodo.Description);
        }

        [Fact]
        public void ReturnsNullIfDoesNotFindATodo()
        {
            Todo expectedTodo = null;

            Todo actualTodo = sut.FindById(1);

            Assert.Equal(expectedTodo, actualTodo);
        }

        [Fact]
        public void CreatesANewTodo()
        {
            Todo newTestTodo = sut.newTodo(1, "testDescription");

            Assert.IsType<Todo>(newTestTodo);
        }

        [Fact]
        public void ClearsAllTodoObjectsFromTheTodoArray()
        {
            sut.newTodo(1, "testDescription");

            sut.Clear();

            Assert.True(sut.Size() == 0);
        }

        [Fact]
        public void FindsTodoItemsByDoneStatus()
        {
            string expectedItemIds = "1, 2, 3";

            sut.newTodo(1, "testDescription");
            sut.newTodo(2, "testDescription");
            sut.newTodo(3, "testDescription");

            Todo[] actualTodoArray = sut.FindByDoneStatus(false);

            Assert.Equal(expectedItemIds, actualTodoArray[0] + ", " + actualTodoArray[1]  + ", " + actualTodoArray[2]);
        }
    }
}

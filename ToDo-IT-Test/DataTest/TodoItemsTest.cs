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
            sut.Clear();
            TodoSequencer.reset();

            sut.newTodo("testDescription");
            int expectedArrayLength = 1;

            int actualArrayLength = sut.Size();

            Assert.Equal(expectedArrayLength, actualArrayLength);

        }

        [Fact]
        public void ReturnsTodoArray()
        {
            sut.Clear();
            TodoSequencer.reset();

            sut.newTodo("testDescription");
            Todo[] expectedTodoArray = { new Todo(1, "testDescription") };
            Todo[] actualTodoArray = sut.FindAll();

            int expected = expectedTodoArray[0].TodoID;
            int actual = actualTodoArray[0].TodoID;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsTodoIfFindsATodo()
        {
            sut.Clear();
            TodoSequencer.reset();

            sut.newTodo("testDescription");

            string expectedTodo = "1 testDescription";

            Todo actualTodo = sut.FindById(1);

            Assert.Equal(expectedTodo, actualTodo.TodoID + " " + actualTodo.Description);

            sut.Clear();
        }

        [Fact]
        public void ReturnsNullIfDoesNotFindATodo()
        {
            sut.Clear();
            TodoSequencer.reset();

            Todo expectedTodo = null;

            Todo actualTodo = sut.FindById(1);

            Assert.Equal(expectedTodo, actualTodo);
        }

        [Fact]
        public void CreatesANewTodo()
        {
            sut.Clear();
            TodoSequencer.reset();

            Todo newTestTodo = sut.newTodo("testDescription");

            Assert.IsType<Todo>(newTestTodo);

            sut.Clear();
        }

        [Fact]
        public void ClearsAllTodoObjectsFromTheTodoArray()
        {
            TodoSequencer.reset();

            sut.newTodo("testDescription");

            sut.Clear();

            Assert.True(sut.Size() == 0);
        }

        [Fact]
        public void FindsTodoItemsByDoneStatus()
        {
            sut.Clear();
            TodoSequencer.reset();

            string expectedItemIds = "1, 2, 3";

            sut.newTodo("testDescription");
            sut.newTodo("testDescription");
            sut.newTodo("testDescription");

            Todo[] actualTodoArray = sut.FindByDoneStatus(false);

            Assert.Equal(expectedItemIds, actualTodoArray[0].TodoID + ", " + actualTodoArray[1].TodoID  + ", " + actualTodoArray[2].TodoID);

            sut.Clear();
        }
    }
}

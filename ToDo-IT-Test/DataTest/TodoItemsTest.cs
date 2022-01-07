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
        public void FindsTodoItemsByDoneStatusFalse()
        {
            sut.Clear();
            TodoSequencer.reset();

            string expectedItemIds = "1, 2, 3";

            sut.newTodo("testDescription");
            sut.newTodo("testDescription");
            sut.newTodo("testDescription");

            Todo[] actualTodoArray = sut.FindByDoneStatus(false);

            Assert.Equal(expectedItemIds, actualTodoArray[0].TodoID + ", " + actualTodoArray[1].TodoID  + ", " + actualTodoArray[2].TodoID);
        }

        [Fact]
        public void FindsTodoItemsByDoneStatusTrue()
        {
            sut.Clear();
            TodoSequencer.reset();

            string expectedItemId = "3, 4";

            sut.newTodo("testDescription");
            sut.newTodo("testDescription");
            Todo doneTrue1 = sut.newTodo("testDescription");
            doneTrue1.Done = true;
            Todo doneTrue2 = sut.newTodo("testDescription");
            doneTrue2.Done = true;

            Todo[] actualTodoArray = sut.FindByDoneStatus(true);

            string actualItemId = actualTodoArray[0].TodoID + ", " + actualTodoArray[1].TodoID;

            Assert.Equal(expectedItemId, actualItemId);

            sut.Clear();
        }

        [Fact]
        public void FindsTodoItemsByAssignee()
        {
            sut.Clear();
            TodoSequencer.reset();

            string expectedAssigneeIds = "1, 1";
            Person testPerson1 = new Person(1 ,"testName", "testLastName");

            Todo assignee1 = sut.newTodo("testDescription");
            assignee1.Assignee = testPerson1;
            Todo assignee2 = sut.newTodo("testDescription");
            assignee2.Assignee = testPerson1;

            Todo[] actualTodoArray = sut.FindByAssignee(1);

            Assert.Equal(expectedAssigneeIds, actualTodoArray[0].Assignee.PersonID + ", " + actualTodoArray[1].Assignee.PersonID);
        }

        [Fact]
        public void FindsTodoItemsByAssigneeWithSentInPerson()
        {
            sut.Clear();
            TodoSequencer.reset();

            string expectedAssigneeIds = "1, 1";
            Person testPerson = new Person(1, "testName", "testLastName");

            Todo assignee1 = sut.newTodo("testDescription");
            assignee1.Assignee = testPerson;
            Todo assignee2 = sut.newTodo("testDescription");
            assignee2.Assignee = testPerson;

            Todo[] actualTodoArray = sut.FindByAssignee(testPerson);

            Assert.Equal(expectedAssigneeIds, actualTodoArray[0].Assignee.PersonID + ", " + actualTodoArray[1].Assignee.PersonID);
        }

        [Fact]
        public void FindsUnassignedTodoItems()
        {
            sut.Clear();
            TodoSequencer.reset();

            string expectedTodoIds = "2, 3";
            Person testPerson = new Person(1, "testName", "testLastName");

            Todo assignee1 = sut.newTodo("testDescription");
            assignee1.Assignee = testPerson;
            sut.newTodo("testDescription");
            sut.newTodo("testDescription");

            Todo[] actualTodoArray = sut.FindUnassignedTodoItems();

            Assert.Equal(expectedTodoIds, actualTodoArray[0].TodoID + ", " + actualTodoArray[1].TodoID);
        }

        [Fact]
        public void RemovesObjectFromArray()
        {
            sut.Clear();
            TodoSequencer.reset();

            Todo testTodo = new Todo(2, "doesNotContainThisTodo");
            
            sut.newTodo("testDescription");
            sut.newTodo("testDescription");
            sut.newTodo("testDescription");

            Todo[] actualTodoArray = sut.removeTodo(2);

            Assert.DoesNotContain<Todo>(testTodo, actualTodoArray);
        }
    }
}

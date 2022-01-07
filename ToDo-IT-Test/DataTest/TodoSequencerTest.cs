using System;
using System.Collections.Generic;
using System.Text;
using ToDo_IT.Data;
using Xunit;

namespace ToDo_IT_Test.DataTest
{
    public class TodoSequencerTest
    {
        [Fact]
        public void IncrementsAndReturnsNextTodoIdValue()
        {
            TodoSequencer.reset();

            int expectedTodoId = 1;
            int actualTodoId = TodoSequencer.nextTodoID();

            Assert.Equal(expectedTodoId, actualTodoId);
        }

        [Fact]
        public void ResetsTodoIdVariable()
        {
            int actualTodoId = TodoSequencer.nextTodoID();
            actualTodoId = TodoSequencer.reset();

            Assert.True(actualTodoId == 0);
        }
    }
}

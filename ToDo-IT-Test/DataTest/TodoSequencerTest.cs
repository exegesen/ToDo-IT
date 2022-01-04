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
            int expectedTodoId = 1;
            int actualTodoId = TodoSequencer.nextTodoID();

            Assert.Equal(expectedTodoId, actualTodoId);
        }
    }
}

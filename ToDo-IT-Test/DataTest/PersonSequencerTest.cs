using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDo_IT.Data;

namespace ToDo_IT_Test.DataTest
{
    public class PersonSequencerTest
    {
        [Fact]
        public void IncrementsAndReturnsNextPersonIdValue()
        {
            int expectedPersonId = 1;
            int actualPersonId = PersonSequencer.nextPersonID();

            Assert.Equal(expectedPersonId, actualPersonId);
        }

        [Fact]
        public void ResetsPersonIdVariable()
        {
            int actualPersonId = PersonSequencer.nextPersonID();
            actualPersonId = PersonSequencer.reset();

            Assert.True(actualPersonId == 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDo_IT.Model;

namespace ToDo_IT_Test.ModelTest
{
    public class PersonTest
    {
        [Fact]
        public void PersonClassTest()
        {
            string expectedFullName = "testName testLastName";

            Person testPerson = new Person("testName", "testLastName");

            Assert.Equal(expectedFullName, testPerson.FirstName + " " + testPerson.LastName);
        }
    }
}

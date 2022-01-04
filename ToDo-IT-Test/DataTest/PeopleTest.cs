using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDo_IT.Data;
using ToDo_IT.Model;

namespace ToDo_IT_Test.DataTest
{
    public class PeopleTest
    {
        People sut = new People();

        [Fact]
        public void ReturnsTheLegthOfTheArray()
        {
            int expectedArrayLength = 0;

            int actualArrayLength = sut.Size();

            Assert.Equal(expectedArrayLength, actualArrayLength);
        }

        [Fact]
        public void ReturnsPersonArray()
        {
            Person[] expectedParsonArray = new Person[0];
            Person[] actualPersonArray = sut.FindAll();

            Assert.Equal(expectedParsonArray, actualPersonArray);
        }

        [Fact]
        public void ReturnsPersonIfFindsAPerson()
        {
            sut.newPerson("testFirstName", "testLastName");

            string expectedPersonName = "testFirstName testLastName";

            Person actualPerson = sut.FindById(0);

            Assert.Equal(expectedPersonName, actualPerson.FirstName + " " + actualPerson.LastName);
        }

        [Fact]
        public void ReturnsNullIfDoesNotFindAPerson()
        {
            Person expectedPerson = null;
            
            Person actualPerson = sut.FindById(1);

            Assert.Equal(expectedPerson, actualPerson);
        }

        [Fact]
        public void CreatesANewPerson()
        {
            Person newTestPerson = sut.newPerson("testFirstName", "testLastName");

            Assert.IsType<Person>(newTestPerson);
        }
    }
}

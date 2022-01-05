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
            sut.newPerson("testFirstName", "testLastName");
            int expectedArrayLength = 1;

            int actualArrayLength = sut.Size();

            Assert.Equal(expectedArrayLength, actualArrayLength);
        }

        [Fact]
        public void ReturnsPersonArray()
        {
            sut.newPerson("testFirstName", "testLastName");
            Person[] expectedParsonArray = { new Person(1, "testFirstNames", "testLastName") };
            Person[] actualPersonArray = sut.FindAll();

            int expected = expectedParsonArray[0].PersonID;
            int actual = actualPersonArray[0].PersonID;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsPersonIfFindsAPerson()
        {
            sut.newPerson("testFirstName", "testLastName");

            string expectedPersonName = "1 testFirstName testLastName";

            Person actualPerson = sut.FindById(1);

            Assert.Equal(expectedPersonName, actualPerson.PersonID + " " + actualPerson.FirstName + " " + actualPerson.LastName);
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

        [Fact]
        public void ClearsAllPersonObjectsFromThePersonArray()
        {
            sut.newPerson("testFirstName", "testLastName");

            sut.Clear();

            Assert.True(sut.Size() == 0);
        }
    }
}

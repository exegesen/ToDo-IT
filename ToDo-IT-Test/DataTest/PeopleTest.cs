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
            sut.Clear();
            PersonSequencer.reset();

            sut.newPerson("testFirstName", "testLastName");
            int expectedArrayLength = 1;

            int actualArrayLength = sut.Size();

            Assert.Equal(expectedArrayLength, actualArrayLength);
        }

        [Fact]
        public void ReturnsPersonArray()
        {
            sut.Clear();
            PersonSequencer.reset();

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
            sut.Clear();
            PersonSequencer.reset();

            sut.newPerson("testFirstName", "testLastName");

            string expectedPersonName = "1 testFirstName testLastName";

            Person actualPerson = sut.FindById(1);

            Assert.Equal(expectedPersonName, actualPerson.PersonID + " " + actualPerson.FirstName + " " + actualPerson.LastName);
        }

        [Fact]
        public void ReturnsNullIfDoesNotFindAPerson()
        {
            sut.Clear();
            PersonSequencer.reset();

            Person expectedPerson = null;
            
            Person actualPerson = sut.FindById(1);

            Assert.Equal(expectedPerson, actualPerson);
        }

        [Fact]
        public void CreatesANewPerson()
        {
            sut.Clear();
            PersonSequencer.reset();

            Person newTestPerson = sut.newPerson("testFirstName", "testLastName");

            Assert.IsType<Person>(newTestPerson);

        }

        [Fact]
        public void ClearsAllPersonObjectsFromThePersonArray()
        {
            PersonSequencer.reset();

            sut.newPerson("testFirstName", "testLastName");

            sut.Clear();

            Assert.True(sut.Size() == 0);

        }

        [Fact]
        public void RemovesObjectFromArray()
        {
            sut.Clear();
            PersonSequencer.reset();

            Person testPerson = new Person(2, "doesNotContainThisFirstName", "doesNotContainThisLastName");

            sut.newPerson("testFisrtName", "testLastName");
            sut.newPerson("testFisrtName", "testLastName");
            sut.newPerson("testFisrtName", "testLastName");

            Person[] actualPersonArray = sut.removePerson(2);

            Assert.DoesNotContain<Person>(testPerson, actualPersonArray);
        }
    }
}

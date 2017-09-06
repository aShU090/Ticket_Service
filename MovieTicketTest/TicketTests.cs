using Apttus.Assignment.MovieTicket;
using Apttus.Assignment.MovieTicket.Enum;
using FakeItEasy;
using NUnit.Framework;
using System.Collections.Generic;

namespace MovieTicketTest
{
    [TestFixture]
    public class TicketTests
    {
        [TestCase]
        public void GetTotalCost_SeniorCitizon_DiscountApplied()
        {
            // Arrange
            var ticket = new Ticket();
            var persons = new List<Persons>();
            for (int i = 0; i < 100; i++)
            {
                persons.Add(new Persons("", 10, Gender.Male));
            }

            // Act
            var cost = ticket.GetTotalCost(persons);

            // Assert
            Assert.AreEqual(cost, 1700);
        }

        [Test]
        public void IsJointFamily_NotAJointFamily_ReturnFalse()
        {
            // Arrange
            var dataAccessorMock = A.Fake<Apttus.MovieTicket.DAL.IDataAccessor>();
            var persons = new List<Persons>()
            {
                new Persons("", 62, Gender.Male),
                new Persons("", 30, Gender.Male),
                new Persons("", 62, Gender.Male),
                new Persons("", 30, Gender.Male),
                new Persons("", 62, Gender.Male)
            };
            A.CallTo(() => dataAccessorMock.GetMembersDetails()).Returns(persons);
            var ticket = new Ticket();

            // Act
            var isJointFamily = ticket.IsJointFamily(dataAccessorMock);

            // Assert
            Assert.IsFalse(isJointFamily);
        }

        [Test]
        public void IsJointFamily_JointFamily_ReturnTrue()
        {
            // Arrange
            var dataAccessorMock = A.Fake<Apttus.MovieTicket.DAL.IDataAccessor>();
            var persons = new List<Persons>()
            {
                new Persons("", 62, Gender.Male),
                new Persons("", 30, Gender.Male),
                new Persons("", 62, Gender.Male),
                new Persons("", 30, Gender.Male),
                new Persons("", 62, Gender.Male),
                new Persons("", 62, Gender.Male)
            };
            A.CallTo(() => dataAccessorMock.GetMembersDetails()).Returns(persons);
            var ticket = new Ticket();

            // Act
            var isJointFamily = ticket.IsJointFamily(dataAccessorMock);

            // Assert
            Assert.IsTrue(isJointFamily);
        }
    }
}
using System;
using NUnit.Framework;

namespace CSharpPlayground.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DisplayEmployeeDetailsTest()
        {
            // Arrange
            Employee employee = new Employee("Matt", "Cook", "mcook@gmail.com", new DateTime(1986, 1, 23), 50);
            string expected = "First name: Matt\nLast name: Cook\nEmail: mcook@gmail.com\nBirthday: 1/23/1986";
            // Act
            string actual = employee.DisplayEmployeeDetails();
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void PerformWorkTest()
        {
            // Arrange
            Employee employee = new Employee("Matt", "Cook", "mcook@gmail.com", new DateTime(1986, 1, 23), 50);
            string expected = "Matt Cook has worked for 1 hour(s)!";
            // Matt Cook has worked for 10 hour(s)!
            // Act
            string actual = employee.PerformWork();
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void PerformWorkWithParamsTest()
        {
            // Arrange
            Employee employee = new Employee("Matt", "Cook", "mcook@gmail.com", new DateTime(1986, 1, 23), 50);
            string expected = "Matt Cook has worked for 10 hour(s)!";
            // Act
            string actual = employee.PerformWork(10);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

}

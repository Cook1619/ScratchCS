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
        public void Test1()
        {
            var mike = new Employee("mike", "pizzle", "1", DateTime.Now);
        }
    }

}

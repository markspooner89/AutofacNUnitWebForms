using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Objects;

namespace Web.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void TestPersonIsActive()
        {
            var person = new Person(1, "Person", "One", DateTime.Now);
            Assert.AreEqual(person.IsActive, true);
        }

        [Test]
        public void TestPersonIsNotActive()
        {
            var person = new Person(1, "Person", "One", DateTime.Now.AddDays(-35));
            Assert.AreEqual(person.IsActive, false);
        }
    }
}
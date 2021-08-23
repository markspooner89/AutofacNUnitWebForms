using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Web.Objects;
using Web.Repository.Interfaces;
using Web.Services;
using Web.Services.Interfaces;

namespace Web.Tests
{
    [TestFixture]
    public class PersonServiceTests
    {
        private IPersonService personService;

        [SetUp]
        public void SetUp()
        {
            var mockRepository = new Mock<IPersonRepository>();

            mockRepository.Setup(repository => repository.GetPeople())
                .Returns(new List<Person>
                {
                    new Person(1, "Person", "One", DateTime.Now.AddDays(-1)),
                    new Person(2, "Person", "Two", DateTime.Now.AddDays(-4)),
                    new Person(3, "Person", "Three", DateTime.Now.AddDays(-33))
                });

            personService = new PersonService(mockRepository.Object);
        }

        [Test]
        public void ReturnsActivePeopleOnlyWithNoParams()
        {
            var results = personService.GetPeople();
            Assert.AreEqual(results.Count(), 2);
        }

        [Test]
        public void ReturnsActivePeopleOnlyWithFalseParam()
        {
            var results = personService.GetPeople(false);
            Assert.AreEqual(results.Count(), 2);
        }

        [Test]
        public void ReturnsAllPeopleOnlyWithTrueParam()
        {
            var results = personService.GetPeople(true);
            Assert.AreEqual(results.Count(), 3);
        }

    }
}
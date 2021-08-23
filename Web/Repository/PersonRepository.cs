using System;
using System.Collections.Generic;
using Web.Objects;
using Web.Repository.Interfaces;

namespace Web.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person(1, "Person", "One", DateTime.Now.AddDays(-1)),
                new Person(2, "Person", "Two", DateTime.Now.AddDays(-4)),
                new Person(3, "Person", "Three", DateTime.Now.AddDays(-33))
            };

            return people;
        }
    }
}
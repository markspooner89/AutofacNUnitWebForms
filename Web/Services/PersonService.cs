using System.Collections.Generic;
using System.Linq;
using Web.Objects;
using Web.Repository.Interfaces;
using Web.Services.Interfaces;

namespace Web.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Person> GetPeople(bool includeInactivePeople = false)
        {
            var people = _repository.GetPeople();

            return includeInactivePeople ?
                people :
                people.Where(person => person.IsActive);
        }
    }
}
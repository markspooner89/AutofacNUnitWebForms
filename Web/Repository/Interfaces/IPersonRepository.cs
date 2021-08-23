using System.Collections.Generic;
using Web.Objects;

namespace Web.Repository.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();
    }
}

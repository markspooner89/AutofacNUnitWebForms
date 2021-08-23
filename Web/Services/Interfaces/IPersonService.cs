using System.Collections.Generic;
using Web.Objects;

namespace Web.Services.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<Person> GetPeople(bool includeInactivePeople = false);
    }
}

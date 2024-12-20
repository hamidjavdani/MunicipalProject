using _0_Framework.Domain;
using PersonManagement.Application.Contracts.Person;
using System.Collections.Generic;

namespace PersonManagement.Domain.PersonAgg;

public interface IPersonRepository : IRepository<long, Person>
{
    EditPerson GetDetails(long id);
    List<PersonViewModel> Search(PersonSearchModel searchModel);
}

using _0_Framework.Application;
using System.Collections.Generic;

namespace PersonManagement.Application.Contracts.Person;

public interface IPersonApplication
{
    OperationResult Create(CreatePerson command);
    OperationResult Edit(EditPerson command);
    OperationResult IsStock(long id);
    OperationResult NotInStock(long id);

    OperationResult Remove(long id);
    OperationResult Restore(long id);

    EditPerson GetDetails(long id);
    List<PersonViewModel> Search(PersonSearchModel searchModel);
}

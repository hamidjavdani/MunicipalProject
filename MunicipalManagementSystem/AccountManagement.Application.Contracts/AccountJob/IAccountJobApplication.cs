using _0_Framework.Application;
using System.Collections.Generic;
namespace AccountManagement.Application.Contracts.AccountJob;

public interface IAccountJobApplication
{
    OperationResult Create(CreateAccountJob command);
    OperationResult Edit(EditAccountJob command);
    OperationResult Remove(long id);
    OperationResult Restore(long id);
    EditAccountJob GetDetails(long id);
    List<AccountJobViewModel> Search(AccountJobSearchModel searchModel);

}

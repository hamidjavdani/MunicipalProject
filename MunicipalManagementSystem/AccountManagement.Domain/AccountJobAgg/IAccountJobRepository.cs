using _0_Framework.Domain;
using AccountManagement.Application.Contracts.AccountJob;
using System.Collections.Generic;

namespace AccountManagement.Domain.AccountJobAgg;

public interface IAccountJobRepository : IRepository<long, AccountJob>
{
    EditAccountJob GetDetails(long id);
    List<AccountJobViewModel> Search(AccountJobSearchModel searchModel);
    //List<TreeViewModel> GetDataforTree();
}

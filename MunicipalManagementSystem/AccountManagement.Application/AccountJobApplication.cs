using _0_Framework.Application;
using AccountManagement.Application.Contracts.AccountJob;
using AccountManagement.Domain.AccountJobAgg;
using System;
using System.Collections.Generic;

namespace AccountManagement.Application;

public class AccountJobApplication : IAccountJobApplication
{
    private readonly IAccountJobRepository _AccountJobRepository;

    public AccountJobApplication(IAccountJobRepository accountJobRepository)
    {
        _AccountJobRepository = accountJobRepository;
    }

    public OperationResult Create(CreateAccountJob command)
    {
        var operation = new OperationResult();
        //   if (_AccountJobRepository.Exists(x => x. == command.JobsChartName))
        //     return operation.Failed(ApplicationMessages.DuplicatedRecord);
        var accountjob = new AccountJob(
            command.AccountId,
            command.JobId,
            command.StartJobName,
            command.EndJobName,
            command.IsHaveJob
           );
        _AccountJobRepository.Create(accountjob);
        _AccountJobRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditAccountJob command)
    {
        throw new NotImplementedException();
    }

    public EditAccountJob GetDetails(long id)
    {
        throw new NotImplementedException();
    }

    public OperationResult Remove(long id)
    {
        throw new NotImplementedException();
    }

    public OperationResult Restore(long id)
    {
        throw new NotImplementedException();
    }

    public List<AccountJobViewModel> Search(AccountJobSearchModel searchModel)
    {
        return _AccountJobRepository.Search(searchModel);

    }
}

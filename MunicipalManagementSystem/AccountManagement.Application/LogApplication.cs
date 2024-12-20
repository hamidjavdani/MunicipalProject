using _0_Framework.Application;
using AccountManagement.Application.Contracts.Log;
using AccountManagement.Domain.LogAgg;
using System.Collections.Generic;

namespace AccountManagement.Application;

public class LogApplication : ILogApplication
{

    private readonly ILogRepository _logRepository;

    public LogApplication(ILogRepository logRepository)
    {
        _logRepository = logRepository;
    }



    public OperationResult Create(CreateLog command)
    {
        var operation = new OperationResult();

        var log = new Log(command.AccountId, command.PermissionId, command.Type);
        _logRepository.Create(log);
        _logRepository.SaveChange();
        return operation.Succedded();
    }


    List<LogViewModel> ILogApplication.List()
    {
        return _logRepository.Getlogs();
    }



    public List<LogViewModel> Search(LogSearchModel searchModel)
    {
        return _logRepository.Search(searchModel);
    }



}

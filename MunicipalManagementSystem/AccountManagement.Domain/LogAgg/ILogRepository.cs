using _0_Framework.Domain;
using AccountManagement.Application.Contracts.Log;
using System.Collections.Generic;

namespace AccountManagement.Domain.LogAgg;

public interface ILogRepository : IRepository<long, Log>
{
    Log GetBy(string username);

    List<LogViewModel> Getlogs();
    List<LogViewModel> Search(LogSearchModel searchModel);


}

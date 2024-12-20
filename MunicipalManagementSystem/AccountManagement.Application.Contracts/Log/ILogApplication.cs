using _0_Framework.Application;
using System.Collections.Generic;

namespace AccountManagement.Application.Contracts.Log;

public interface ILogApplication
{
    OperationResult Create(CreateLog command);

    List<LogViewModel> Search(LogSearchModel searchModel);
    List<LogViewModel> List();

}

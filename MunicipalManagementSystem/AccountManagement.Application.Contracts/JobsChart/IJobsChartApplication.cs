using _0_Framework.Application;
using System.Collections.Generic;

namespace AccountManagement.Application.Contracts.JobsChart;

public interface IJobsChartApplication
{
    OperationResult Create(CreateJobsChart command);
    OperationResult Edit(EditJobsChart command);
    OperationResult Remove(long id);
    OperationResult Restore(long id);
    EditJobsChart GetDetails(long id);
    List<JobsChartViewModel> Search(JobsChartSearchModel searchModel);
    List<TreeViewModel> GetDataforTree();
}

using _0_Framework.Domain;
using AccountManagement.Application.Contracts.JobsChart;
using System.Collections.Generic;

namespace AccountManagement.Domain.JobsChartAgg;

public interface IJobsChartRepository : IRepository<long, JobsChart>
{
    EditJobsChart GetDetails(long id);
    List<JobsChartViewModel> Search(JobsChartSearchModel searchModel);
    List<TreeViewModel> GetDataforTree();
}

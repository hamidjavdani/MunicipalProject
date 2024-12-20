using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.JobsChart;
using AccountManagement.Domain.JobsChartAgg;
using System.Collections.Generic;
using System.Linq;

namespace AccountMangement.Infrastructure.EFCore.Repository
{
    public class JobsChartRepository : RepositoryBase<long, JobsChart>, IJobsChartRepository
    {
        private readonly AccountContext _context;

        public JobsChartRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public EditJobsChart GetDetails(long id)
        {
            return _context.tbljobschart.Select(x => new EditJobsChart
            {
                Id = x.Id,
                JobsChartName = x.JobsChartName,
                JobsChartLevel = x.JobsChartLevel,
                JobsChartDescription = x.JobsChartDescription

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<JobsChartViewModel> Search(JobsChartSearchModel searchModel)
        {
            var query = _context.tbljobschart.Select(x => new JobsChartViewModel
            {

                Id = x.Id

            });
            //if (!string.IsNullOrWhiteSpace(searchModel.Id))
            //    query = query.Where(x => x.Id.Contains(searchModel.Id));
            return query.OrderByDescending(x => x.Id).ToList();
        }

        public List<TreeViewModel> GetDataforTree()
        {
            return _context.tbljobschart.Select(x => new TreeViewModel
            {
                id = x.Id.ToString(),
                parent = x.JobsChartLevel.ToString(),
                text = x.JobsChartName
            }).ToList();
        }

    }
}

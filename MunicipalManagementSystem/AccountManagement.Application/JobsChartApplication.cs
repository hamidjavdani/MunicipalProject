using _0_Framework.Application;
using AccountManagement.Application.Contracts.JobsChart;
using AccountManagement.Domain.JobsChartAgg;
using System.Collections.Generic;

namespace AccountManagement.Application;

public class JobsChartApplication : IJobsChartApplication
{
    private readonly IJobsChartRepository _JobsChartRepository;

    public JobsChartApplication(IJobsChartRepository jobsChartRepository)
    {
        _JobsChartRepository = jobsChartRepository;
    }

    public OperationResult Create(CreateJobsChart command)
    {
        var operation = new OperationResult();
        if (_JobsChartRepository.Exists(x => x.JobsChartName == command.JobsChartName))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        var request = new JobsChart(
            command.JobsChartName,
            command.JobsChartDescription,
            command.JobsChartLevel
           );
        _JobsChartRepository.Create(request);
        _JobsChartRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditJobsChart command)
    {
        var operation = new OperationResult();
        var jobschart = _JobsChartRepository.Get(command.Id);
        if (jobschart == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        if (_JobsChartRepository.Exists(x => x.JobsChartName == command.JobsChartName && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        jobschart.Edit(command.JobsChartName,
            command.JobsChartDescription,
            command.JobsChartLevel);
        _JobsChartRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Remove(long id)
    {
        var operation = new OperationResult();
        var JobsChart = _JobsChartRepository.Get(id);
        if (JobsChart == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);

        JobsChart.Remove();
        _JobsChartRepository.SaveChange();
        return operation.Succedded();
    }
    public OperationResult Restore(long id)
    {
        var operation = new OperationResult();
        var JobsChart = _JobsChartRepository.Get(id);
        if (JobsChart == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);

        JobsChart.Restore();
        _JobsChartRepository.SaveChange();
        return operation.Succedded();
    }

    public EditJobsChart GetDetails(long id)
    {
        return _JobsChartRepository.GetDetails(id);
    }

    public List<JobsChartViewModel> Search(JobsChartSearchModel searchModel)
    {
        return _JobsChartRepository.Search(searchModel);
    }


    public List<TreeViewModel> GetDataforTree()
    {
        return _JobsChartRepository.GetDataforTree();
    }

}
